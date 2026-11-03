# Week 3 : Making Decisions (Part 1)


**Chapter 3:** Making Decisions
**Topics:** Decision structures, the `if` statement, `if-else`, nested decisions, `if-else-if`, logical operators

## Introduction

Most useful programs cannot simply run the same statements in the same order every time. They must react to what the user types, to values they calculate, and to conditions that change while they run. A loan program must decide whether a customer qualifies. A payroll program must decide whether overtime applies. A grading program must decide which letter grade a score earns. This chapter introduces the tools C# gives us for making those decisions. In Week 3 we cover the basic building blocks: the `if` statement, its `else` partner, nested decisions, chains of conditions, and the logical operators that combine conditions.

## Learning Objectives

By the end of this lab you should be able to:

- Explain the difference between a sequence structure and a decision structure
- Build Boolean expressions with relational operators
- Write `if`, `if-else`, nested `if`, and `if-else-if` statements
- Combine conditions with `&&`, `||`, and `!`
- Build and test a Windows Forms application that makes decisions based on user input

---

## 1. Control Structures

A **control structure** is a logical design that controls the order in which statements execute. Until now, the programs you wrote used a **sequence structure**: statements run one after another, in exactly the order they are written, and every statement always runs.

A **decision structure** (also called a **selection structure**) changes this. It runs certain statements only when a specific condition exists. A familiar real-world example is "If it is cold outside, wear a coat." The action (wear a coat) happens only if the condition (cold outside) is true. If the condition is false, the action is skipped and life continues with the next step.

A decision structure that offers only one alternative path, as in the coat example, is called a **single-alternative decision structure**. In C#, we write it with the `if` statement.

## 2. The `if` Statement

The generic format of the `if` statement is:

```csharp
if (expression)
{
    statement;
    statement;
}
```

The `expression` is a **Boolean expression**, which means it evaluates to either `true` or `false`. When it is `true`, the statements inside the braces run. When it is `false`, the program skips the whole block and moves on.

Example:

```csharp
if (sales > 50000)
{
    bonus = 500;
}
```

If `sales` is greater than 50,000, the bonus is set to 500. Otherwise `bonus` keeps whatever value it had before.

### Relational Operators

Boolean expressions are usually built with **relational operators**. A relational operator determines whether a specific relationship exists between two values.

| Operator | Meaning                  | Example  | Question it answers                  |
|----------|--------------------------|----------|--------------------------------------|
| `>`      | Greater than             | `x > y`  | Is x greater than y?                 |
| `<`      | Less than                | `x < y`  | Is x less than y?                    |
| `>=`     | Greater than or equal to | `x >= y` | Is x greater than or equal to y?     |
| `<=`     | Less than or equal to    | `x <= y` | Is x less than or equal to y?        |
| `==`     | Equal to                 | `x == y` | Is x equal to y?                     |
| `!=`     | Not equal to             | `x != y` | Is x not equal to y?                 |

A very common beginner mistake is writing `=` when `==` is needed. A single `=` assigns a value, while `==` compares two values. Inside an `if`, you almost always want the comparison.

## 3. The `if-else` Statement

An `if` statement does something only when the condition is true. Often a program needs to do one thing when the condition is true and a different thing when it is false. The `if-else` statement handles this. It has two parts: an **if clause** and an **else clause**. Exactly one of the two blocks runs, never both and never neither.

```csharp
if (expression)
{
    statements;
}
else
{
    statements;
}
```

Example:

```csharp
double temp = 90;
if (temp > 40)
{
    MessageBox.Show("hot");
}
else
{
    MessageBox.Show("cold");
}
```

## 4. Nested Decision Structures

Sometimes one condition is not enough. A **nested decision structure** places one decision inside another, so the program tests a second condition only after the first one has been satisfied. "Nested" simply means "one inside another."

```csharp
if (expression)
{
    if (expression)
    {
        statements;
    }
    else
    {
        statements;
    }
}
else
{
    statements;
}
```

The loan example shows why this is useful. A customer qualifies only if the salary is at least 40,000 and the customer has been at the current job for at least 2 years. The program checks the salary first. Only if the salary is high enough does it bother to check the years on the job. Each failing path can then give a different, specific message:

```csharp
if (salary >= 40000)
{
    if (yearsOnJob >= 2)
        decisionLabel.Text = "You qualify for the loan.";
    else
        decisionLabel.Text = "Minimum years at current job not met.";
}
else
{
    decisionLabel.Text = "Minimum salary requirement not met.";
}
```

## 5. The `if-else-if` Statement

Nesting many levels deep becomes hard to read. When the goal is to pick **one result out of several**, the `if-else-if` statement is cleaner. The conditions are tested from top to bottom. The first condition that is true runs its block, and all the remaining conditions are skipped. The final `else` acts as a catch-all when none of the conditions are true.

```csharp
if (expression)
{
    statements;
}
else if (expression)
{
    statements;
}
else if (expression)
{
    statements;
}
else
{
    statements;
}
```

A letter-grade program is the classic example:

```csharp
if (score >= 90)      grade = "A";
else if (score >= 80) grade = "B";
else if (score >= 70) grade = "C";
else if (score >= 60) grade = "D";
else                  grade = "F";
```

Order matters here. A score of 95 satisfies `score >= 80` too, but because `score >= 90` is tested first, the student correctly receives an A.

## 6. Logical Operators

Logical operators connect several Boolean expressions into one **compound expression**.

| Operator | Name | Description                                                       |
|----------|------|-------------------------------------------------------------------|
| `&&`     | AND  | Both subexpressions must be true for the whole expression to be true |
| `\|\|`   | OR   | One or both subexpressions must be true for the whole expression to be true |
| `!`      | NOT  | Reverses the truth value of the expression                        |

| Expression          | Meaning                                  |
|---------------------|------------------------------------------|
| `x > y && a < b`    | Is x greater than y AND is a less than b? |
| `x == y \|\| x == z` | Is x equal to y OR is x equal to z?      |
| `!(x > y)`          | Is the expression `x > y` NOT true?      |

### Truth Tables

**AND (`&&`)**

| Expression       | Result  |
|------------------|---------|
| `true && false`  | `false` |
| `false && true`  | `false` |
| `false && false` | `false` |
| `true && true`   | `true`  |

**OR (`||`)**

| Expression         | Result  |
|--------------------|---------|
| `true \|\| false`  | `true`  |
| `false \|\| true`  | `true`  |
| `false \|\| false` | `false` |
| `true \|\| true`   | `true`  |

**NOT (`!`)**

| Expression | Result  |
|------------|---------|
| `!true`    | `false` |
| `!false`   | `true`  |

### Examples

```csharp
// && : both conditions must be true
if (temperature < 20 && minutes > 12)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// || : at least one condition must be true
if (temperature < 20 || temperature > 100)
{
    MessageBox.Show("The temperature is in the danger zone.");
}

// ! : reverses the result
if (!(temperature > 100))
{
    MessageBox.Show("The temperature is below the maximum.");
}
```

A common use of `&&` is a **range check**: a value is in range only if it is at least the minimum AND at most the maximum. The Range Checker lab below uses exactly this idea.

---

## Lab Exercises

### Lab 1: Test Score Average

**Concepts used:** `if` statement, relational operator, exception handling

**What the program does:** The user types three test scores. The program parses them, calculates the average, and shows it in a label. If the average is above the high score of 95, a congratulation message appears. The `try-catch` block protects the program from crashing if a text box is empty or contains something that is not a number.

```csharp
const double HIGH_SCORE = 95.0;
double test1, test2, test3, average;

try
{
    test1 = double.Parse(test1TextBox.Text);
    test2 = double.Parse(test2TextBox.Text);
    test3 = double.Parse(test3TextBox.Text);

    average = (test1 + test2 + test3) / 3.0;
    averageLabel.Text = average.ToString("n1");

    if (average > HIGH_SCORE)
    {
        MessageBox.Show("Congratulations! Great job!");
    }
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

**Screenshot:**



![Test Score Average](screenshots/test-score-average.png)



**What the screenshot shows:** The form contains three input text boxes labeled Test Score #1, #2, and #3, an Average label, and the Calculate Average, Clear, and Exit buttons. The scores 80, 90, and 75 were entered and Calculate Average was clicked. The Average label displays **81.7**, which is (80 + 90 + 75) / 3 = 81.67 rounded to one decimal place by `"n1"`. Because 81.7 is not above 95, no congratulation message appears, which proves the `if` condition evaluated to false.

---

### Lab 2: Payroll with Overtime (Home Assignment)

**Concepts used:** `if-else`, constants, decimal arithmetic

**What the program does:** The user enters hours worked and an hourly pay rate. Up to 40 hours are paid at the normal rate. Every hour above 40 is overtime and is paid at 1.5 times the rate. The `if-else` decides which formula to use. The form's controls are `hoursWorkedTextBox`, `hourlyPayRateTextBox`, `grossPayLabel`, `calculateButton`, `clearButton`, and `exitButton`.

```csharp
const decimal BASE_HOURS = 40m, OT_MULTIPLIER = 1.5m;

if (hours > BASE_HOURS)
    gross = (BASE_HOURS * rate) + ((hours - BASE_HOURS) * rate * OT_MULTIPLIER);
else
    gross = hours * rate;

grossPayLabel.Text = gross.ToString("c");
```

**Screenshot 1: with overtime**



![Payroll with overtime](screenshots/payroll-overtime.png)



**What it shows:** 45 hours at $20 per hour. The first 40 hours earn 40 × 20 = $800. The extra 5 hours earn 5 × 20 × 1.5 = $150. Gross pay is **$950.00**. This confirms the `if` branch (the overtime formula) ran.

**Screenshot 2: without overtime**



![Payroll without overtime](screenshots/payroll-no-overtime.png)



**What it shows:** 35 hours at $20 per hour. Since 35 is not greater than 40, the `else` branch runs and the result is simply 35 × 20 = **$700.00**. Comparing the two screenshots shows both paths of the `if-else`.

---

### Lab 3: Loan Qualifier

**Concepts used:** nested `if-else`

**What the program does:** The user enters an annual salary and the number of years at the current job. The program checks salary first, then years. It displays one of three possible decisions in the Loan Decision label.

**Screenshot 1: qualifies**



![Loan qualifies](screenshots/loan-qualifies.png)



**What it shows:** Salary 45,000 and 3 years. Both conditions pass, so the inner `if` runs and the label shows **"You qualify for the loan."**

**Screenshot 2: salary not met**



![Salary not met](screenshots/loan-salary-not-met.png)



**What it shows:** Salary 30,000 and 3 years. The outer condition fails, so the program goes straight to the outer `else` and shows **"Minimum salary requirement not met."** The years are never checked.

**Screenshot 3: years not met**



![Years not met](screenshots/loan-years-not-met.png)



**What it shows:** Salary 45,000 and 1 year. The outer condition passes, but the inner condition fails, giving **"Minimum years at current job not met."** The three screenshots together cover every path through the nested structure.

---

### Lab 4: Range Checker

**Concepts used:** `&&` logical operator, `if-else`, `TryParse`

**What the program does:** The user enters an integer. The program reports whether it lies between 1 and 10 inclusive.

```csharp
if (number >= 1 && number <= 10)
{
    decisionLabel.Text = "The number is in the range.";
}
else
{
    decisionLabel.Text = "The number is NOT in the range.";
}
```

**Screenshot 1: inside the range**



![In range](screenshots/range-in.png)



**What it shows:** The value 7 satisfies both `>= 1` and `<= 10`, so the compound expression is true and the label says **"The number is in the range."**

**Screenshot 2: outside the range**



![Out of range](screenshots/range-out.png)



**What it shows:** The value 15 fails `<= 10`. Since `&&` requires both parts to be true, the whole expression is false and the label says **"The number is NOT in the range."**

---

## Summary

- A decision structure runs statements only when a condition is true.
- `if` handles one alternative, `if-else` handles two, nested `if` handles dependent conditions, and `if-else-if` selects one result from many.
- Relational operators compare values; logical operators combine comparisons.
- Good testing means running the program once for every path through the decision, which is why each lab above includes more than one screenshot.

## Deliverables

- [ ] Test Score Average
- [ ] Payroll with Overtime (Home Assignment)
- [ ] Loan Qualifier
- [ ] Range Checker
- [ ] A screenshot of every program path, as shown above