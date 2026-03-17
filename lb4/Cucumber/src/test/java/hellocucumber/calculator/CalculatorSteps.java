package hellocucumber.calculator;

import io.cucumber.java.en.*;
import static org.junit.Assert.*;

public class CalculatorSteps {

    int a;
    int b;
    int result;
    String errorMessage;

    @Given("I have numbers {int} and {int}")
    public void i_have_numbers(int num1, int num2) {
        a = num1;
        b = num2;
        errorMessage = null;
    }

    @When("I perform {string}")
    public void i_perform_operation(String operation) {

        switch (operation) {

            case "add":
                result = a + b;
                break;

            case "subtract":
                result = a - b;
                break;

            case "multiply":
                result = a * b;
                break;

            case "divide":

                if (b == 0) {
                    errorMessage = "Cannot divide by zero";
                    return;
                }

                result = a / b;
                break;
        }
    }

    @Then("result should be {int}")
    public void result_should_be(int expected) {
        assertEquals(expected, result);
    }

    @Then("error message should be {string}")
    public void error_message_should_be(String expected) {
        assertEquals(expected, errorMessage);
    }
}