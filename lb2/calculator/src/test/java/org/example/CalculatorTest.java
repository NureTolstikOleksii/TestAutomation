package org.example;

import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;
import org.junit.jupiter.params.provider.MethodSource;

import java.math.BigDecimal;
import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.*;

public class CalculatorTest {
    // аналог TestCase
    @ParameterizedTest
    @CsvSource({
            "5,3,8",
            "10,4,14",
            "-5,2,-3",
            "-10,-5,-15",
            "1000000000000000000,1,1000000000000000001"
    })
    void testAdd(String a, String b, String expected) {
        MockLogger logger = new MockLogger();
        Calculator calculator = new Calculator(logger);
        BigDecimal result = calculator.add(
                new BigDecimal(a),
                new BigDecimal(b)
        );
        assertEquals(new BigDecimal(expected), result);
    }

    @ParameterizedTest
    @CsvSource({
            "10,5,5",
            "5,10,-5",
            "-10,-5,-5",
            "1000000000000000000,1,999999999999999999"
    })
    void testSubtract(String a, String b, String expected) {
        MockLogger logger = new MockLogger();
        Calculator calculator = new Calculator(logger);
        BigDecimal result = calculator.subtract(
                new BigDecimal(a),
                new BigDecimal(b)
        );
        assertEquals(new BigDecimal(expected), result);
    }

    // аналог TestCaseSource
    static Stream<Object[]> multiplyData() {
        return Stream.of(
                new Object[]{"2", "3", "6"},
                new Object[]{"-2", "3", "-6"},
                new Object[]{"-2", "-3", "6"},
                new Object[]{"1000000000000000000", "2", "2000000000000000000"}
        );
    }
    @ParameterizedTest
    @MethodSource("multiplyData")
    void testMultiply(String a, String b, String expected) {
        MockLogger logger = new MockLogger();
        Calculator calculator = new Calculator(logger);
        BigDecimal result = calculator.multiply(
                new BigDecimal(a),
                new BigDecimal(b)
        );
        assertEquals(new BigDecimal(expected), result);
    }

    static Stream<Object[]> divideData() {
        return Stream.of(
                new Object[]{"10", "2", "5"},
                new Object[]{"-10", "2", "-5"},
                new Object[]{"-10", "-2", "5"}
        );
    }
    @ParameterizedTest
    @MethodSource("divideData")
    void testDivide(String a, String b, String expected) {
        MockLogger logger = new MockLogger();
        Calculator calculator = new Calculator(logger);

        BigDecimal result = calculator.divide(
                new BigDecimal(a),
                new BigDecimal(b)
        );
        assertEquals(new BigDecimal(expected), result);
    }

    @ParameterizedTest
    @CsvSource({
            "10,0",
            "-5,0"
    })
    void testDivideByZero(String a, String b) {
        MockLogger logger = new MockLogger();
        Calculator calculator = new Calculator(logger);
        assertThrows(
                ArithmeticException.class,
                () -> calculator.divide(new BigDecimal(a), new BigDecimal(b))
        );
    }

    @ParameterizedTest
    @CsvSource({
            "10,5",
            "-10,5",
            "1000000000000000000,1"
    })
    void testLoggerCalled(String a, String b) {
        MockLogger logger = new MockLogger();
        Calculator calculator = new Calculator(logger);
        calculator.add(
                new BigDecimal(a),
                new BigDecimal(b)
        );
        assertEquals(1, logger.calls);
    }
}