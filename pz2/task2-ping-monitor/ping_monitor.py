import subprocess
import time
import re
import os
import platform
import xml.etree.ElementTree as ET
from datetime import datetime


def load_hosts(filename="hosts.txt"):
    if not os.path.exists(filename):
        with open(filename, "w", encoding="utf-8") as file:
            file.write("8.8.8.8\ngoogle.com\n")
        print(f"File {filename} was not found. A template has been created.")

    with open(filename, "r", encoding="utf-8") as file:
        return [line.strip() for line in file if line.strip()]


def ping_host(host, count):
    ping_param = "-n" if platform.system().lower() == "windows" else "-c"
    command = ["ping", ping_param, str(count), host]

    try:
        output = subprocess.check_output(
            command,
            stderr=subprocess.STDOUT,
            universal_newlines=True
        )

        if platform.system().lower() == "windows":
            match = re.search(r"Average = (\d+)ms", output)
        else:
            match = re.search(r"=\s*[\d.]+/([\d.]+)/[\d.]+/[\d.]+\s*ms", output)

        return float(match.group(1)) if match else None

    except subprocess.CalledProcessError:
        return None
    except Exception:
        return None


def save_txt_report(filename, results, total_average):
    with open(filename + ".txt", "a", encoding="utf-8") as file:
        file.write(f"\n[{datetime.now().strftime('%Y-%m-%d %H:%M:%S')}]\n")
        for host, response_time in results.items():
            value = f"{response_time:.2f} ms" if response_time is not None else "Error"
            file.write(f"{host}: {value}\n")
        file.write(f"Total average: {total_average:.2f} ms\n")


def save_xml_report(filename, results, total_average):
    xml_file = filename + ".xml"

    if os.path.exists(xml_file):
        tree = ET.parse(xml_file)
        root = tree.getroot()
    else:
        root = ET.Element("PingReports")
        tree = ET.ElementTree(root)

    report = ET.SubElement(
        root,
        "Report",
        timestamp=datetime.now().strftime("%Y-%m-%d %H:%M:%S")
    )

    for host, response_time in results.items():
        host_element = ET.SubElement(report, "Host", name=host)
        host_element.text = f"{response_time:.2f}" if response_time is not None else "Timeout"

    total_average_element = ET.SubElement(report, "TotalAverage")
    total_average_element.text = f"{total_average:.2f}"

    tree.write(xml_file, encoding="utf-8", xml_declaration=True)


def save_html_report(filename, results, total_average):
    html_file = filename + ".html"
    file_exists = os.path.exists(html_file)

    with open(html_file, "a", encoding="utf-8") as file:
        if not file_exists:
            file.write(
                "<html>\n"
                "<head>\n"
                "    <meta charset='UTF-8'>\n"
                "    <title>Ping Report</title>\n"
                "</head>\n"
                "<body style='font-family: sans-serif;'>\n"
                "    <h2>Ping Report</h2>\n"
            )

        file.write(f"<h3>{datetime.now().strftime('%Y-%m-%d %H:%M:%S')}</h3>\n")
        file.write("<table border='1' cellspacing='0' cellpadding='6'>\n")
        file.write("<tr><th>Host</th><th>Average response time</th></tr>\n")

        for host, response_time in results.items():
            value = f"{response_time:.2f} ms" if response_time is not None else "N/A"
            file.write(f"<tr><td>{host}</td><td>{value}</td></tr>\n")

        file.write("</table>\n")
        file.write(f"<p><b>Total average: {total_average:.2f} ms</b></p>\n")
        file.write("<hr>\n")


def main():
    os.makedirs("reports", exist_ok=True)

    print("Choose report format:")
    print("1 - TXT")
    print("2 - XML")
    print("3 - HTML")
    choice = input("Your choice (1-3): ").strip()

    formats = {
        "1": "TXT",
        "2": "XML",
        "3": "HTML"
    }
    report_format = formats.get(choice, "TXT")

    try:
        ping_count = int(input("Enter the number of ping requests: ").strip())
        interval_seconds = int(input("Enter the interval in seconds: ").strip())
    except ValueError:
        print("Error: only integer values are allowed.")
        return

    if ping_count <= 0 or interval_seconds <= 0:
        print("Error: the number of ping requests and the interval must be greater than 0.")
        return

    hosts = load_hosts()
    report_name = f"reports/report_{datetime.now().strftime('%Y%m%d_%H%M%S')}"

    print(f"\nStarting to ping {len(hosts)} hosts...")
    print(f"Report format: {report_format}")

    try:
        while True:
            results = {}
            valid_response_times = []

            for host in hosts:
                response_time = ping_host(host, ping_count)
                results[host] = response_time

                if response_time is not None:
                    valid_response_times.append(response_time)

            total_average = (
                sum(valid_response_times) / len(valid_response_times)
                if valid_response_times else 0
            )

            if report_format == "TXT":
                save_txt_report(report_name, results, total_average)
            elif report_format == "XML":
                save_xml_report(report_name, results, total_average)
            elif report_format == "HTML":
                save_html_report(report_name, results, total_average)

            print(
                f"[{datetime.now().strftime('%H:%M:%S')}] "
                f"Report updated. Total average: {total_average:.2f} ms"
            )
            time.sleep(interval_seconds)

    except KeyboardInterrupt:
        print("\nProgram stopped.")


if __name__ == "__main__":
    main()