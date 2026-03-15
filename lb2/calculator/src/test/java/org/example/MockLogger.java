package org.example;

public class MockLogger implements ILogger {

    public int calls = 0;

    @Override
    public void log(String message) {
        calls++;
    }

}