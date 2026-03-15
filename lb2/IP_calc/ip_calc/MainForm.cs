using System;
using System.Windows.Forms;

namespace IP_calc
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        private readonly IpCalculator _calc = new IpCalculator();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ip1.Select();
            ip1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Робота з маскою через префікс
                string fullMask = _calc.GetBinaryMaskFromPrefix(int.Parse(masc_pref.Text));
                if (fullMask == null) { MessageBox.Show("Неприпустимий префікс."); return; }

                masc1.Text = fullMask.Substring(0, 8);
                masc2.Text = fullMask.Substring(8, 8);
                masc3.Text = fullMask.Substring(16, 8);
                masc4.Text = fullMask.Substring(24, 8);

                // 2. IP в двійкову форму
                ip21.Text = _calc.ToBinaryOctet(ip1.Text);
                ip22.Text = _calc.ToBinaryOctet(ip2.Text);
                ip23.Text = _calc.ToBinaryOctet(ip3.Text);
                ip24.Text = _calc.ToBinaryOctet(ip4.Text);

                // 3. Адреса мережі (Побітове AND)
                netAddr1.Text = _calc.BitwiseAnd(masc1.Text, ip21.Text);
                netAddr2.Text = _calc.BitwiseAnd(masc2.Text, ip22.Text);
                netAddr3.Text = _calc.BitwiseAnd(masc3.Text, ip23.Text);
                netAddr4.Text = _calc.BitwiseAnd(masc4.Text, ip24.Text);

                // 4. Адреса вузла
                nodeAddr1.Text = _calc.BitwiseAnd(_calc.InvertBinary(masc1.Text), ip21.Text);
                nodeAddr2.Text = _calc.BitwiseAnd(_calc.InvertBinary(masc2.Text), ip22.Text);
                nodeAddr3.Text = _calc.BitwiseAnd(_calc.InvertBinary(masc3.Text), ip23.Text);
                nodeAddr4.Text = _calc.BitwiseAnd(_calc.InvertBinary(masc4.Text), ip24.Text);

                // 5. Кількість вузлів
                int bits = _calc.CountMaskBits(masc1.Text) + _calc.CountMaskBits(masc2.Text) +
                           _calc.CountMaskBits(masc3.Text) + _calc.CountMaskBits(masc4.Text);
                numberOfNodesTextBox.Text = (Math.Pow(2, 32 - bits) - 2).ToString();

                // 6. Порядковий номер комп'ютера
                int zeroBits = _calc.CountZeroBits(masc1.Text) + _calc.CountZeroBits(masc2.Text) +
                               _calc.CountZeroBits(masc3.Text) + _calc.CountZeroBits(masc4.Text);
                string fullIpBin = ip21.Text + ip22.Text + ip23.Text + ip24.Text;
                computerNumberTextBox.Text = Convert.ToInt32(fullIpBin.Substring(32 - zeroBits), 2).ToString();

                // 7. Клас мережі
                networkClassTextBox.Text = _calc.GetNetworkClass(ip21.Text);

                // 8. Десяткові представлення
                decimalMaskTextBox.Text = $"{Convert.ToInt32(masc1.Text, 2)}.{Convert.ToInt32(masc2.Text, 2)}.{Convert.ToInt32(masc3.Text, 2)}.{Convert.ToInt32(masc4.Text, 2)}";
                decimalNetworkAddrTextBox.Text = $"{Convert.ToInt32(netAddr1.Text, 2)}.{Convert.ToInt32(netAddr2.Text, 2)}.{Convert.ToInt32(netAddr3.Text, 2)}.{Convert.ToInt32(netAddr4.Text, 2)}";
                decimalNodeAddrTextBox.Text = $"{Convert.ToInt32(nodeAddr1.Text, 2)}.{Convert.ToInt32(nodeAddr2.Text, 2)}.{Convert.ToInt32(nodeAddr3.Text, 2)}.{Convert.ToInt32(nodeAddr4.Text, 2)}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка даних: " + ex.Message);
            }
        }
    }
}
