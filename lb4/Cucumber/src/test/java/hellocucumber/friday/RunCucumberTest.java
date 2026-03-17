package hellocucumber.friday;

import org.junit.runner.RunWith;
import io.cucumber.junit.Cucumber;
import io.cucumber.junit.CucumberOptions;

@RunWith(Cucumber.class)

@CucumberOptions(
        features = "src/test/resources/hellocucumber/is_it_friday_yet.feature",
        glue = {"hellocucumber.friday"},
        plugin = {"pretty"}
)

public class RunCucumberTest {
}