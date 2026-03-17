package hellocucumber.console;

import io.cucumber.java.en.*;
import static org.junit.Assert.*;
import org.example.Calculator;

public class ConsoleCalculatorSteps {

    double a;
    double b;
    double result;
    Exception exception;

    @Given("I have numbers {double} and {double}")
    public void i_have_numbers(double num1, double num2) {
        a = num1;
        b = num2;
        exception = null;
    }

    @When("I calculate {string}")
    public void i_calculate(String op) {
        try {
            result = Calculator.calculate(a, b, op.charAt(0));
        } catch (Exception e) {
            exception = e;
        }
    }

    @Then("result should be {double}")
    public void result_should_be(double expected) {
        assertEquals(expected, result, 0.0001);
    }

    @Then("error message should be {string}")
    public void error_message_should_be(String expected) {
        assertNotNull(exception);
        assertEquals(expected, exception.getMessage());
    }
}