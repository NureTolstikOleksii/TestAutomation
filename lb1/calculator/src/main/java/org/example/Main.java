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

        double result;

        switch (operation) {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0) {
                    result = num1 / num2;
                } else {
                    System.out.println("Помилка: Ділення на нуль неможливе!");
                    return;
                }
                break;
            default:
                System.out.println("Помилка: Невідома операція!");
                return;
        }

        System.out.println("Результат: " + result);
        scanner.close();
    }
}