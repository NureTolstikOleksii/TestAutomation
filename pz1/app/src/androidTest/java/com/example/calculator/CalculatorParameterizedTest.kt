package com.example.calculator

import androidx.test.ext.junit.rules.ActivityScenarioRule
import androidx.test.espresso.Espresso.onView
import androidx.test.espresso.action.ViewActions.*
import androidx.test.espresso.assertion.ViewAssertions.matches
import androidx.test.espresso.matcher.ViewMatchers.*
import org.junit.Rule
import org.junit.Test
import org.junit.runner.RunWith
import org.junit.runners.Parameterized

@RunWith(Parameterized::class)
class CalculatorParameterizedTest(
    private val first: String,
    private val second: String,
    private val operationBtnId: Int,
    private val expectedResult: String
) {

    @get:Rule
    val activityRule = ActivityScenarioRule(MainActivity::class.java)

    companion object {
        @JvmStatic
        @Parameterized.Parameters(name = "{index}: {0} (Btn:{2}) {1} = {3}")
        fun data(): Collection<Array<Any>> {
            return listOf(
                arrayOf("10.5", "5.2", R.id.btnAdd, "15.7"),
                arrayOf("-10", "5", R.id.btnAdd, "-5.0"),
                arrayOf("-20.5", "-30.5", R.id.btnAdd, "-51.0"),
                arrayOf("999999", "1", R.id.btnAdd, "1000000.0"),
                arrayOf("0", "0", R.id.btnAdd, "0.0"),

                arrayOf("0", "15.5", R.id.btnSub, "-15.5"),
                arrayOf("100", "100", R.id.btnSub, "0.0"),
                arrayOf("-10", "-5", R.id.btnSub, "-5.0"),
                arrayOf("5", "-10", R.id.btnSub, "15.0"),
                arrayOf("0.0001", "0.00005", R.id.btnSub, "5.0E-5"),

                arrayOf("5", "0", R.id.btnMul, "0.0"),
                arrayOf("-2", "4", R.id.btnMul, "-8.0"),
                arrayOf("-5", "-5", R.id.btnMul, "25.0"),
                arrayOf("0.5", "0.5", R.id.btnMul, "0.25"),
                arrayOf("1000000", "1000000", R.id.btnMul, "1.0E12"),

                arrayOf("10", "4", R.id.btnDiv, "2.5"),
                arrayOf("1", "3", R.id.btnDiv, "0.3333333333333333"),
                arrayOf("0", "10", R.id.btnDiv, "0.0"),
                arrayOf("-10", "2", R.id.btnDiv, "-5.0"),
                arrayOf("-10", "-2", R.id.btnDiv, "5.0"),
                arrayOf("100", "0.1", R.id.btnDiv, "1000.0")
            )
        }
    }

    @Test
    fun testOperations() {
        onView(withId(R.id.etFirstNumber)).perform(replaceText(first), closeSoftKeyboard())
        onView(withId(R.id.etSecondNumber)).perform(replaceText(second), closeSoftKeyboard())
        onView(withId(operationBtnId)).perform(click())
        onView(withId(R.id.tvResult)).check(matches(withText(expectedResult)))
    }
}