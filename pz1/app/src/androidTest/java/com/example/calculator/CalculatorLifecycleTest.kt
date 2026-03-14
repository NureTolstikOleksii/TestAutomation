package com.example.calculator

import android.content.Context
import androidx.test.core.app.ActivityScenario
import androidx.test.core.app.ApplicationProvider
import androidx.test.espresso.Espresso.onView
import androidx.test.espresso.action.ViewActions.*
import androidx.test.espresso.assertion.ViewAssertions.matches
import androidx.test.espresso.matcher.ViewMatchers.*
import org.junit.After
import org.junit.Before
import org.junit.Test

class CalculatorLifecycleTest {

    private val PREFS_NAME = "calc_prefs"

    @Before
    fun setUp() {
        val context = ApplicationProvider.getApplicationContext<Context>()
        context.getSharedPreferences(PREFS_NAME, Context.MODE_PRIVATE).edit().clear().commit()
    }

    @After
    fun tearDown() {
        val context = ApplicationProvider.getApplicationContext<Context>()
        context.getSharedPreferences(PREFS_NAME, Context.MODE_PRIVATE).edit().clear().commit()
    }

    @Test
    fun testResultPersistsAfterRestart() {
        var scenario = ActivityScenario.launch(MainActivity::class.java)
        onView(withId(R.id.etFirstNumber)).perform(replaceText("12"), closeSoftKeyboard())
        onView(withId(R.id.etSecondNumber)).perform(replaceText("3"), closeSoftKeyboard())
        onView(withId(R.id.btnMul)).perform(click())

        onView(withId(R.id.tvResult)).check(matches(withText("36.0")))
        scenario.close()

        scenario = ActivityScenario.launch(MainActivity::class.java)

        onView(withId(R.id.tvResult)).check(matches(withText("36.0")))
        scenario.close()
    }
}