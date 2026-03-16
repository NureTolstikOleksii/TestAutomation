<?php

namespace Unit;

use Calculator;
use Exception;
use PHPUnit\Framework\TestCase;

require_once __DIR__ . '/../../calculator.php';

class CalculatorTest extends TestCase
{
    private Calculator $calc;

    protected function setUp(): void
    {
        $this->calc = new Calculator();
    }

    //  ADD
    public function testAddPositiveNumbers()
    {
        $this->assertEquals(10, $this->calc->add(5, 5));
    }

    public function testAddNegativeNumbers()
    {
        $this->assertEquals(-10, $this->calc->add(-5, -5));
    }

    public function testAddMixedNumbers()
    {
        $this->assertEquals(0, $this->calc->add(-5, 5));
    }

    public function testAddDecimals()
    {
        $this->assertEquals(10.5, $this->calc->add(5.2, 5.3));
    }

    //  SUBTRACT
    public function testSubtractPositive()
    {
        $this->assertEquals(5, $this->calc->subtract(10, 5));
    }

    public function testSubtractNegative()
    {
        $this->assertEquals(-5, $this->calc->subtract(5, 10));
    }

    public function testSubtractDecimals()
    {
        $this->assertEquals(2.5, $this->calc->subtract(5.5, 3));
    }

    //  MULTIPLY
    public function testMultiplyPositive()
    {
        $this->assertEquals(25, $this->calc->multiply(5, 5));
    }

    public function testMultiplyNegative()
    {
        $this->assertEquals(-25, $this->calc->multiply(-5, 5));
    }

    public function testMultiplyZero()
    {
        $this->assertEquals(0, $this->calc->multiply(10, 0));
    }

    public function testMultiplyDecimals()
    {
        $this->assertEquals(6.25, $this->calc->multiply(2.5, 2.5));
    }

    //  DIVIDE
    public function testDividePositive()
    {
        $this->assertEquals(5, $this->calc->divide(10, 2));
    }

    public function testDivideDecimals()
    {
        $this->assertEquals(2.5, $this->calc->divide(5, 2));
    }

    public function testDivideNegative()
    {
        $this->assertEquals(-5, $this->calc->divide(-10, 2));
    }

    public function testDivideByZero()
    {
        $this->expectException(Exception::class);
        $this->calc->divide(10, 0);
    }
}