Feature: Calculator operations

Scenario Outline: Calculator operations
Given I have numbers <a> and <b>
When I calculate "<op>"
Then result should be <result>

Examples:
| a | b | op | result |
| 10 | 5 | + | 15 |
| 10 | 5 | - | 5 |
| 10 | 5 | * | 50 |
| 10 | 5 | / | 2 |
| 20 | 4 | / | 5 |
| 7 | 3 | + | 10 |

Scenario: Division by zero
Given I have numbers 10 and 0
When I calculate "/"
Then error message should be "Cannot divide by zero"

Scenario: Unknown operation
Given I have numbers 10 and 5
When I calculate "%"
Then error message should be "Unknown operation"