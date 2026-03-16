<?php

use Tests\Support\AcceptanceTester;

class CalculatorCest
{

    public function openCalculator(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->see('Calculator');
    }

    // ADD
    public function addPositiveNumbers(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->fillField('#display','7+5');
        $I->click('=');

        $I->see('Result: 12');
    }

    public function addDecimals(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->fillField('#display','5.5+2.5');
        $I->click('=');

        $I->see('Result: 8');
    }

    // SUBTRACT
    public function subtractNumbers(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->fillField('#display','10-4');
        $I->click('=');

        $I->see('Result: 6');
    }
    public function subtractNegativeResult(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->fillField('#display','5-10');
        $I->click('=');

        $I->see('Result: -5');
    }

    // MULTIPLY
    public function multiplyNumbers(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->fillField('#display','6*7');
        $I->click('=');

        $I->see('Result: 42');
    }

    public function multiplyByZero(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->fillField('#display','10*0');
        $I->click('=');

        $I->see('Result: 0');
    }

    // DIVIDE
    public function divideNumbers(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->fillField('#display','20/4');
        $I->click('=');

        $I->see('Result: 5');
    }

    public function divideDecimals(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->fillField('#display','5/2');
        $I->click('=');

        $I->see('Result: 2.5');
    }

    //  ERROR
    public function divideByZero(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->fillField('#display','10/0');
        $I->click('=');

        $I->see('Division by zero');
    }

    //  CLEAR
    public function clearDisplay(AcceptanceTester $I)
    {
        $I->amOnPage('/');
        $I->click('7');
        $I->click('+');
        $I->click('5');

        $I->click('C');

        $I->dontSee('7+5','#display');
    }

}