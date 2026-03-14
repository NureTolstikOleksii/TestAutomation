package com.example.calculator

class Calculator(private val logger: ILogger? = null) {
    fun add(a: Double, b: Double): Double = execute("Add", a, b) { a + b }
    fun subtract(a: Double, b: Double): Double = execute("Sub", a, b) { a - b }
    fun multiply(a: Double, b: Double): Double = execute("Mul", a, b) { a * b }
    fun divide(a: Double, b: Double): Double {
        if (b == 0.0) throw IllegalArgumentException("Division by zero is not allowed")
        return execute("Div", a, b) { a / b }
    }

    private fun execute(op: String, a: Double, b: Double, block: () -> Double): Double {
        val res = block()
        logger?.log("$op: $a and $b gives $res")
        return res
    }
}