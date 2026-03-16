<?php
require_once "calculator.php";

$result = "";
$expression = "";

if ($_SERVER["REQUEST_METHOD"] === "POST") {

    $expression = $_POST["expression"] ?? "";

    try {

        if (preg_match('/([\d\.]+)([\+\-\*\/])([\d\.]+)/', $expression, $matches)) {

            $a = (float)$matches[1];
            $op = $matches[2];
            $b = (float)$matches[3];

            $calc = new Calculator();

            switch ($op) {

                case "+":
                    $result = $calc->add($a,$b);
                    break;

                case "-":
                    $result = $calc->subtract($a,$b);
                    break;

                case "*":
                    $result = $calc->multiply($a,$b);
                    break;

                case "/":
                    $result = $calc->divide($a,$b);
                    break;
            }
        }

    } catch(Exception $e){
        $result = $e->getMessage();
    }
}
?>

<!DOCTYPE html>
<html>
<head>
    <title>PHP Calculator</title>
    <link rel="stylesheet" href="style.css">
</head>

<body>

<div class="calculator">

    <h1>Calculator</h1>

    <form method="post" id="calcForm">

        <input
                type="text"
                name="expression"
                id="display"
                value="<?php echo htmlspecialchars($expression); ?>"
                readonly
        >

        <div class="buttons">

            <button type="button" onclick="press('7')">7</button>
            <button type="button" onclick="press('8')">8</button>
            <button type="button" onclick="press('9')">9</button>
            <button type="button" onclick="press('/')">÷</button>

            <button type="button" onclick="press('4')">4</button>
            <button type="button" onclick="press('5')">5</button>
            <button type="button" onclick="press('6')">6</button>
            <button type="button" onclick="press('*')">×</button>

            <button type="button" onclick="press('1')">1</button>
            <button type="button" onclick="press('2')">2</button>
            <button type="button" onclick="press('3')">3</button>
            <button type="button" onclick="press('-')">−</button>

            <button type="button" onclick="clearDisplay()">C</button>
            <button type="button" onclick="press('0')">0</button>
            <button type="submit">=</button>
            <button type="button" onclick="press('+')">+</button>

        </div>

    </form>

    <?php if($result !== ""): ?>

        <div class="result">
            Result: <?php echo $result; ?>
        </div>

    <?php endif; ?>

</div>

<script>

    function press(val){
        document.getElementById("display").value += val;
    }

    function clearDisplay(){
        document.getElementById("display").value = "";
    }

</script>

</body>
</html>