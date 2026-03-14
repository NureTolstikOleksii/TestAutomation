package com.example.calculator

import androidx.test.core.app.ActivityScenario
import androidx.test.espresso.Espresso.onView
import androidx.test.espresso.action.ViewActions.*
import androidx.test.espresso.assertion.ViewAssertions.matches
import androidx.test.espresso.matcher.ViewMatchers.*
import org.junit.Test
import org.mockito.Mockito.*

class CalculatorLoggerUITest {

    @Test
    fun testUIInteraction_VerifiesLoggingCalledOnce() {
        val mockLogger = mock(ILogger::class.java)
        val scenario = ActivityScenario.launch(MainActivity::class.java)

        scenario.onActivity { activity ->
            activity.logger = mockLogger
            activity.setupCalculator()
        }

        onView(withId(R.id.etFirstNumber)).perform(replaceText("10"), closeSoftKeyboard())
        onView(withId(R.id.etSecondNumber)).perform(replaceText("2"), closeSoftKeyboard())
        onView(withId(R.id.btnDiv)).perform(click())
        onView(withId(R.id.tvResult)).check(matches(withText("5.0")))

        verify(mockLogger, times(1)).log(contains("Div"))
        verify(mockLogger, times(1)).log(contains("5.0"))

        scenario.close()
    }
}