package com.example.calculator

import org.junit.Assert.assertEquals
import org.junit.Test
import org.mockito.ArgumentMatchers.anyString
import org.mockito.Mockito.*

class CalculatorLoggerUnitTest {
    private val mockLogger = mock(ILogger::class.java)
    private val calculator = Calculator(mockLogger)

    @Test
    fun testAdd_CallsLoggerOnceAndReturnsCorrect() {
        val result = calculator.add(10.0, 5.0)
        assertEquals(15.0, result, 0.001)
        verify(mockLogger, times(1)).log(anyString())
    }

    @Test
    fun testDivide_CallsLoggerOnce() {
        calculator.divide(20.0, 4.0)
        verify(mockLogger, times(1)).log(contains("Div"))
    }
}