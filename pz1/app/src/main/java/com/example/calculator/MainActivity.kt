package com.example.calculator

import android.content.Context
import android.os.Bundle
import android.widget.*
import androidx.appcompat.app.AppCompatActivity

class MainActivity : AppCompatActivity() {
    var logger: ILogger? = null
    private lateinit var calculator: Calculator
    private lateinit var tvResult: TextView

    fun setupCalculator() {
        calculator = Calculator(logger)
    }

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)

        tvResult = findViewById(R.id.tvResult)
        val firstNum = findViewById<EditText>(R.id.etFirstNumber)
        val secondNum = findViewById<EditText>(R.id.etSecondNumber)

        setupCalculator()

        val prefs = getSharedPreferences("calc_prefs", Context.MODE_PRIVATE)
        tvResult.text = prefs.getString("last_result", "0.0")

        val buttons = mapOf(
            R.id.btnAdd to { a: Double, b: Double -> calculator.add(a, b) },
            R.id.btnSub to { a: Double, b: Double -> calculator.subtract(a, b) },
            R.id.btnMul to { a: Double, b: Double -> calculator.multiply(a, b) },
            R.id.btnDiv to { a: Double, b: Double -> calculator.divide(a, b) }
        )

        buttons.forEach { (id, operation) ->
            findViewById<Button>(id).setOnClickListener {
                try {
                    val n1 = firstNum.text.toString().toDoubleOrNull()
                    val n2 = secondNum.text.toString().toDoubleOrNull()

                    if (n1 == null || n2 == null) {
                        tvResult.text = "Invalid input"
                        return@setOnClickListener
                    }

                    val res = operation(n1, n2)
                    tvResult.text = res.toString()

                    prefs.edit().putString("last_result", res.toString()).apply()

                } catch (e: Exception) {
                    tvResult.text = e.message ?: "Error"
                }
            }
        }
    }
}