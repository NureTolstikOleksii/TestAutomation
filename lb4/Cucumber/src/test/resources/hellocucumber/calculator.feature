Feature: Calculator operations

Scenario Outline: Calculator operations with different numbers
Given I have numbers <a> and <b>
When I perform "<operation>"
Then result should be <result>

Examples:
| a | b | operation | result |
| 10 | 5 | add | 15 |
| 10 | 5 | subtract | 5 |
| 10 | 5 | multiply | 50 |
| 10 | 5 | divide | 2 |
| 20 | 4 | divide | 5 |
| 7 | 3 | add | 10 |

Scenario: Division by zero
Given I have numbers 10 and 0
When I perform "divide"
Then error message should be "Cannot divide by zero"