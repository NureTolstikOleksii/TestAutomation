package org.example;

import java.math.BigDecimal;

public class Calculator {

    private final ILogger logger;

    public Calculator(ILogger logger) {
        this.logger = logger;
    }

    public BigDecimal add(BigDecimal a, BigDecimal b) {
        BigDecimal result = a.add(b);
        logger.log(a + " + " + b + " = " + result);
        return result;
    }

    public BigDecimal subtract(BigDecimal a, BigDecimal b) {
        BigDecimal result = a.subtract(b);
        logger.log(a + " - " + b + " = " + result);
        return result;
    }

    public BigDecimal multiply(BigDecimal a, BigDecimal b) {
        BigDecimal result = a.multiply(b);
        logger.log(a + " * " + b + " = " + result);
        return result;
    }

    public BigDecimal divide(BigDecimal a, BigDecimal b) {

        if (b.compareTo(BigDecimal.ZERO) == 0) {
            throw new ArithmeticException("Division by zero");
        }

        BigDecimal result = a.divide(b);
        logger.log(a + " / " + b + " = " + result);

        return result;
    }
}