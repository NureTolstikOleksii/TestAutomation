package hellocucumber.friday;

import io.cucumber.java.en.*;
import static org.junit.Assert.*;

public class StepDefinitions {

    String today;
    String answer;

    @Given("today is {string}")
    public void today_is(String today) {
        this.today = today;
    }

    @When("I ask whether it's Friday yet")
    public void i_ask_whether_its_friday_yet() {
        answer = isItFriday(today);
    }

    @Then("I should be told {string}")
    public void i_should_be_told(String expectedAnswer) {
        assertEquals(expectedAnswer, answer);
    }

    public static String isItFriday(String today) {
        if ("Friday".equals(today)) {
            return "Yes";
        } else {
            return "Nope";
        }
    }
}