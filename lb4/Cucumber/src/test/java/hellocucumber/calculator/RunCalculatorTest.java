package hellocucumber.calculator;

import org.junit.runner.RunWith;
import io.cucumber.junit.Cucumber;
import io.cucumber.junit.CucumberOptions;

@RunWith(Cucumber.class)

@CucumberOptions(
        features = "src/test/resources/hellocucumber/calculator.feature",
        glue = "hellocucumber.calculator",
        plugin = {"pretty"}
)

public class RunCalculatorTest {
}