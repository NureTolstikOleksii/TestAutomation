package org.example;

import java.math.BigDecimal;
import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        Calculator calculator = new Calculator(new ConsoleLogger());

        System.out.println("Консольний калькулятор");

        System.out.print("Введіть перше число: ");
        BigDecimal num1 = scanner.nextBigDecimal();

        System.out.print("Введіть операцію (+, -, *, /): ");
        char operation = scanner.next().charAt(0);

        System.out.print("Введіть друге число: ");
        BigDecimal num2 = scanner.nextBigDecimal();

        BigDecimal result;

        switch (operation) {

            case '+':
                result = calculator.add(num1, num2);
                break;

            case '-':
                result = calculator.subtract(num1, num2);
                break;

            case '*':
                result = calculator.multiply(num1, num2);
                break;

            case '/':
                result = calculator.divide(num1, num2);
                break;

            default:
                System.out.println("Помилка: Невідома операція!");
                return;
        }

        System.out.println("Результат: " + result);
    }
}