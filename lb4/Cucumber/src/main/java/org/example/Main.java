package org.example;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        System.out.println("Консольний калькулятор");

        System.out.print("Введіть перше число: ");
        if (!scanner.hasNextDouble()) {
            System.out.println("Помилка: значення має бути числом!");
            return;
        }
        double num1 = scanner.nextDouble();

        System.out.print("Введіть операцію (+, -, *, /): ");
        char operation = scanner.next().charAt(0);

        System.out.print("Введіть друге число: ");
        if (!scanner.hasNextDouble()) {
            System.out.println("Помилка: значення має бути числом!");
            return;
        }
        double num2 = scanner.nextDouble();

        try {
            double result = Calculator.calculate(num1, num2, operation);
            System.out.println("Результат: " + result);
        } catch (Exception e) {
            System.out.println("Помилка: " + e.getMessage());
        }

        scanner.close();
    }
}