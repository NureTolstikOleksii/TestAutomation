package org.example;

import org.junit.jupiter.api.Test;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.CsvSource;

import java.io.ByteArrayInputStream;
import java.io.ByteArrayOutputStream;
import java.io.PrintStream;

import static org.junit.jupiter.api.Assertions.assertTrue;

public class CalculatorTest {

    // TC-01-02
    @Test
    void testProgramStart() {
        String input = "1\n+\n1\n";

        ByteArrayInputStream in = new ByteArrayInputStream(input.getBytes());
        System.setIn(in);

        ByteArrayOutputStream out = new ByteArrayOutputStream();
        System.setOut(new PrintStream(out));

        Main.main(new String[]{});

        String output = out.toString();
        assertTrue(output.contains("Консольний калькулятор"));
        assertTrue(output.contains("Введіть перше число"));
    }

    // TC-03-09
    @ParameterizedTest
    @CsvSource({
            "5,+,3,8.0",
            "10,-,4,6.0",
            "6,*,7,42.0",
            "20,/,5,4.0",
            "-5,+,2,-3.0",
            "5.5,*,2,11.0",
            "10,*,0,0.0"
    })
    void testCalculatorOperations(String first, String operation, String second, String expected) {
        java.util.Locale.setDefault(java.util.Locale.US);

        String input = first + "\n" + operation + "\n" + second + "\n";
        ByteArrayInputStream in = new ByteArrayInputStream(input.getBytes());
        System.setIn(in);

        ByteArrayOutputStream out = new ByteArrayOutputStream();
        System.setOut(new PrintStream(out));

        Main.main(new String[]{});

        String output = out.toString();
        assertTrue(output.contains("Результат: " + expected));
    }

    // TC-10-11
    @ParameterizedTest
    @CsvSource({
            "10,/,0,Помилка: Ділення на нуль неможливе!",
            "5,%,2,Помилка: Невідома операція!"
    })
    void testCalculatorErrors(String first, String operation, String second, String expectedMessage) {

        String input = first + "\n" + operation + "\n" + second + "\n";

        ByteArrayInputStream in = new ByteArrayInputStream(input.getBytes());
        System.setIn(in);

        ByteArrayOutputStream out = new ByteArrayOutputStream();
        System.setOut(new PrintStream(out));

        Main.main(new String[]{});

        String output = out.toString();
        assertTrue(output.contains(expectedMessage));
    }

    // TC-12
    @Test
    void testInvalidFirstNumber() {

        String input = "abc\n";

        ByteArrayInputStream in = new ByteArrayInputStream(input.getBytes());
        System.setIn(in);

        ByteArrayOutputStream out = new ByteArrayOutputStream();
        System.setOut(new PrintStream(out));

        Main.main(new String[]{});

        String output = out.toString();
        assertTrue(output.contains("Помилка: значення має бути числом!"));
    }

    // TC-13
    @Test
    void testInvalidSecondNumber() {

        String input = "5\n+\nabc\n";

        ByteArrayInputStream in = new ByteArrayInputStream(input.getBytes());
        System.setIn(in);

        ByteArrayOutputStream out = new ByteArrayOutputStream();
        System.setOut(new PrintStream(out));

        Main.main(new String[]{});

        String output = out.toString();
        assertTrue(output.contains("Помилка: значення має бути числом!"));
    }
}