package com.example.calculator

import androidx.test.ext.junit.rules.ActivityScenarioRule
import androidx.test.espresso.Espresso.onView
import androidx.test.espresso.action.ViewActions.*
import androidx.test.espresso.assertion.ViewAssertions.matches
import androidx.test.espresso.matcher.ViewMatchers.*
import org.junit.Rule
import org.junit.Test

class CalculatorErrorHandlingTest {

    @get:Rule
    val activityRule = ActivityScenarioRule(MainActivity::class.java)

    @Test
    fun testDivisionByZero_DisplaysMeaningfulError() {
        onView(withId(R.id.etFirstNumber)).perform(replaceText("10"), closeSoftKeyboard())
        onView(withId(R.id.etSecondNumber)).perform(replaceText("0"), closeSoftKeyboard())
        onView(withId(R.id.btnDiv)).perform(click())
        onView(withId(R.id.tvResult)).check(matches(withText("Division by zero is not allowed")))
    }

    @Test
    fun testInvalidInput_DisplaysError() {
        onView(withId(R.id.etFirstNumber)).perform(replaceText("abc"), closeSoftKeyboard())
        onView(withId(R.id.etSecondNumber)).perform(replaceText("5"), closeSoftKeyboard())
        onView(withId(R.id.btnAdd)).perform(click())
        onView(withId(R.id.tvResult)).check(matches(withText("Invalid input")))
    }
}