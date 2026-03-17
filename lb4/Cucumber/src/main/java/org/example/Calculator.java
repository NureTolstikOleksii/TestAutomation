package org.example;

public class Calculator {

    public static double calculate(double num1, double num2, char operation) {

        switch (operation) {
            case '+':
                return num1 + num2;

            case '-':
                return num1 - num2;

            case '*':
                return num1 * num2;

            case '/':
                if (num2 == 0) {
                    throw new IllegalArgumentException("Cannot divide by zero");
                }
                return num1 / num2;

            default:
                throw new IllegalArgumentException("Unknown operation");
        }
    }
}