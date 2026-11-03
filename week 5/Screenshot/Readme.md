# Week 5 Lab: Loops


**Chapter 4:** Loops, Files, and Random Numbers (Part 1)
**Topics:** The `while` loop, the `++` and `--` operators, the `for` loop, the `do-while` loop

## Introduction

So far, every statement in your programs has run at most once each time an event fires. Many real tasks, however, require repetition: adding interest month after month, printing a table of values, or asking the user again until the input is acceptable. Writing the same statements over and over would be slow, error-prone, and impossible when the number of repetitions is not known in advance. A **loop** solves this problem. It repeats a statement or a block of statements for as long as a condition holds. Week 5 covers the three loop statements of C#: `while`, `for`, and `do-while`, together with the increment and decrement operators that loops depend on.

## Learning Objectives

By the end of this lab you should be able to:

- Explain what a loop is, what an iteration is, and what a counter variable does
- Write `while`, `for`, and `do-while` loops
- Distinguish pretest loops from posttest loops
- Recognize and avoid infinite loops
- Use `++` and `--` in postfix and prefix mode and predict the result
- Choose the most appropriate loop for a given problem

---

## 1. The `while` Loop

The `while` loop repeats a statement or a set of statements **as long as a Boolean expression is `true`**. The logic is simple: while some condition is true, do some task.

A `while` loop has two parts:

1. A **Boolean expression** that is tested for `true` or `false`
2. A **statement or block of statements** that is repeated as long as the expression is `true`

```csharp
while (BooleanExpression)
{
    statements;
}
```

The first line is called the **while clause**. The statements between the curly braces are the **body** of the loop. When the loop executes, the Boolean expression is tested. If it is `true`, the body runs, and then the expression is tested again. When it becomes `false`, the loop ends and the program continues with the statement after the closing brace.

Each time the body executes, we say the loop is **iterating**, or performing an **iteration**. A **counter variable** is a variable used to track how many times a loop has run.

### The `while` loop is a pretest loop

A `while` loop is a **pretest loop**: it tests its condition **before** performing an iteration. This has two consequences.

First, the programmer must usually prepare the variables **before** the loop so that the condition is true the first time. In the example below, `count` is initialized to 0, which is less than 5, so the loop will iterate:

```csharp
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}
```

This loop iterates **5 times** (count is 0, 1, 2, 3, and 4).

Second, if the condition is false to begin with, the loop body never runs at all:

```csharp
int count = 5;
while (count < 5)
{
    MessageBox.Show("Hello");
    count = count + 1;
}
```

Here `count < 5` is false immediately, so "Hello" is never displayed.

### Infinite loops

An **infinite loop** repeats until the program is interrupted. The usual cause is that the programmer forgets to write code that eventually makes the condition `false`. In this example `count` is never changed, so `count < 5` stays true forever:

```csharp
int count = 0;
while (count < 5)
{
    MessageBox.Show("Hello");   // count is never increased!
}
```

Whenever you write a `while` loop, ask yourself: **what statement inside the body moves the loop toward ending?** In the correct version above, it is `count = count + 1;`.

### Lab 1: Ending Balance

**Concepts used:** `while` loop, counter variable, constant, accumulating a value

**What the program does:** The user enters a starting balance and a number of months. A savings account earns 0.5% interest per month. The loop adds one month of interest to the balance on each iteration, and after the last month the ending balance is displayed. The form's controls are `startingBalTextBox`, `monthsTextBox`, `endingBalanceLabel`, `calculateButton`, `clearButton`, and `exitButton`.

```csharp
// Constant for the monthly interest rate.
const decimal INTEREST_RATE = 0.005m;

decimal startingBalance, balance;
int months;
int count = 1;                       // counter variable

if (decimal.TryParse(startingBalTextBox.Text, out startingBalance) &&
    int.TryParse(monthsTextBox.Text, out months))
{
    balance = startingBalance;

    while (count <= months)
    {
        // Add this month's interest to the balance.
        balance = balance + (INTEREST_RATE * balance);
        count++;
    }

    endingBalanceLabel.Text = balance.ToString("c");
}
else
{
    MessageBox.Show("Please enter valid numbers.");
}
```

**Screenshot 1: the form before calculating**



![Ending Balance design](screenshots/ending-balance-design.png)



**What the screenshot shows:** The Ending Balance form in the Designer or at startup, with two empty text boxes (Starting Balance and Number of Months), an empty Ending Balance label, and the Calculate, Clear, and Exit buttons. The control names are visible in the Properties window.

**Screenshot 2: after calculating**



![Ending Balance result](screenshots/ending-balance-result.png)



**What the screenshot shows:** A starting balance of 1000 and 8 months were entered. The label shows **$1,040.71**. The loop iterated 8 times, multiplying the balance by 1.005 each time.

### Lab 2: Ending Balance with a ListBox (modified version)

**Concepts used:** `while` loop, `ListBox.Items.Add`, string concatenation, currency formatting

**What changed:** A `detailListBox` is added to the form. Inside the loop, every month's balance is added to the list, so the user can see how the balance grows.

```csharp
detailListBox.Items.Clear();
balance = startingBalance;
count = 1;

while (count <= months)
{
    // Add this month's interest to the balance.
    balance = balance + (INTEREST_RATE * balance);

    // Display this month's ending balance.
    detailListBox.Items.Add("The ending balance for month " + count +
                            " is " + balance.ToString("c"));
    count++;
}

endingBalanceLabel.Text = balance.ToString("c");
```

**Screenshot:**



![Ending Balance with ListBox](screenshots/ending-balance-listbox.png)



**What the screenshot shows:** With a starting balance of 1000 and 8 months, the list contains eight lines:

| Month | Ending balance |
|-------|----------------|
| 1 | $1,005.00 |
| 2 | $1,010.03 |
| 3 | $1,015.08 |
| 4 | $1,020.15 |
| 5 | $1,025.25 |
| 6 | $1,030.38 |
| 7 | $1,035.53 |
| 8 | $1,040.71 |

The final value matches the Ending Balance label, which proves the label shows the result of the last iteration.

---

## 2. The `++` and `--` Operators

To **increment** a variable means to increase its value, and to **decrement** a variable means to decrease its value. Because loops constantly change counters, C# provides two shortcuts: `++` adds 1 and `--` subtracts 1.

Adding 1 to a variable can be written in three equivalent ways:

```csharp
count++;
count += 1;
count = count + 1;
```

Subtracting 1 can also be written three ways:

```csharp
count--;
count -= 1;
count = count - 1;
```

### Postfix mode versus prefix mode

The operators can be placed **after** the variable (**postfix mode**, `count++`) or **before** it (**prefix mode**, `++count`). When the operator is a statement on its own, both modes do the same thing. The difference appears when the expression is used inside a larger statement, such as an assignment:

- **Postfix:** use the old value first, then change the variable.
- **Prefix:** change the variable first, then use the new value.

```csharp
int count = 5;
int x = 0;

x = count++;     // postfix: x gets 5, then count becomes 6
```

```csharp
int count = 5;
int x = 0;

x = ++count;     // prefix: count becomes 6, then x gets 6
```

| Statement  | Value of `x` | Value of `count` afterwards |
|------------|--------------|-----------------------------|
| `x = count++;` | 5 | 6 |
| `x = ++count;` | 6 | 6 |

In both cases `count` ends at 6. Only the value copied into `x` differs.

### Lab 3: Postfix and Prefix Demonstration

**Concepts used:** `++`, postfix and prefix mode, `MessageBox`

**Important detail:** `MessageBox.Show("text", "caption")` treats the second string as the **title bar caption**. To show a label and a number together in the message area, join them with `+`:

```csharp
int count = 5;
int x = 0;

MessageBox.Show("The x before is " + x);
MessageBox.Show("The count before is " + count);

x = count++;

MessageBox.Show("The x after postfix is " + x);
MessageBox.Show("The count after postfix is " + count);
```

Then repeat with `count = 5; x = 0; x = ++count;`.

**Screenshot 1: postfix**



![Postfix result](screenshots/postfix-result.png)



**What the screenshot shows:** After `x = count++;` the message boxes read **x = 5** and **count = 6**. The old value of `count` was copied before the increment.

**Screenshot 2: prefix**



![Prefix result](screenshots/prefix-result.png)



**What the screenshot shows:** After `x = ++count;` the message boxes read **x = 6** and **count = 6**. The increment happened first.

### Checkpoint questions

**Question 5.9:** What messages will this code display?

```csharp
int number = 5;
number++;
MessageBox.Show(number.ToString());
number--;
MessageBox.Show(number.ToString());
```

**Answer:** The first message is **6** (5 plus 1) and the second is **5** (6 minus 1).

**Question 5.10:** How many times will this loop iterate?

```csharp
int count = 0;
while (count < 4)
{
    MessageBox.Show(count.ToString());
    count++;
}
```

**Answer:** **4 times.** It displays 0, 1, 2, and 3. When `count` reaches 4, the condition is false.

---

## 3. The `for` Loop

The `for` loop is designed for situations where a **counter variable** controls how many times the loop repeats. Instead of scattering the counter's setup, test, and update in different places as a `while` loop does, the `for` loop puts all three in one line. You must specify:

- **Initialization:** a one-time expression that sets the starting value of the counter
- **Test:** a Boolean expression. If it is `true`, the loop iterates.
- **Update:** an expression that increases or decreases the counter after each iteration

```csharp
for (InitializationExpression; TestExpression; UpdateExpression)
{
    statements;
}
```

Like `while`, the `for` loop is a **pretest loop**.

The order of events is: (1) initialization runs once, (2) the test is evaluated, (3) if true, the body runs, (4) the update runs, (5) go back to step 2. When the test is false, the loop ends.

```csharp
int count;
for (count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

The counter can also be **declared inside** the initialization expression. Then it exists only inside the loop:

```csharp
// Declare the count variable in the initialization expression.
for (int count = 0; count < 5; count++)
{
    MessageBox.Show("Hello");
}
```

Both versions start `count` at 0, test `count < 5`, and add 1 after each pass, so "Hello" is displayed 5 times.

### Other forms of the update expression

The counter is usually increased by 1, but this is not a requirement.

```csharp
// Increment by 10.
for (int count = 0; count <= 100; count += 10)
{
    MessageBox.Show(count.ToString());
}
```

This displays 0, 10, 20, ... 100, which is 11 iterations.

```csharp
// Counting backward.
for (int count = 10; count >= 0; count--)
{
    MessageBox.Show(count.ToString());
}
```

This displays 10, 9, 8, ... 0, which is also 11 iterations. Notice that when counting backward, the test uses `>=` and the update uses `--`.

### Lab 4: The Squares Application

**Concepts used:** `for` loop, `ListBox.Items.Add`, arithmetic

**What the program does:** When the user clicks Go, the program fills a ListBox with the squares of the numbers 1 through 10.

```csharp
private void goButton_Click(object sender, EventArgs e)
{
    outputListBox.Items.Clear();

    for (int number = 1; number <= 10; number++)
    {
        int square = number * number;
        outputListBox.Items.Add("The square of " + number + " is " + square);
    }
}
```

**Screenshot 1: before clicking Go**



![Squares empty](screenshots/squares-empty.png)



**What the screenshot shows:** The form with an empty `outputListBox` and the `goButton`.

**Screenshot 2: after clicking Go**



![Squares result](screenshots/squares-result.png)



**What the screenshot shows:** The list contains ten lines, from "The square of 1 is 1" to "The square of 10 is 100", with the squares 1, 4, 9, 16, 25, 36, 49, 64, 81, and 100. The `for` loop produced ten iterations without any manual counter bookkeeping.

---

## 4. The `do-while` Loop

The `do-while` loop is a **posttest loop**: it performs an iteration **before** testing its Boolean expression. Because the body runs first, a `do-while` loop **always executes at least once**, even if the condition is false from the start.

```csharp
do
{
    statements;
} while (BooleanExpression);
```

Notice the **semicolon** after the closing parenthesis. It is required.

### Comparing `do-while` and `while`

Will the message box appear in each example?

```csharp
int number = 1;
do
{
    MessageBox.Show(number.ToString());
} while (number < 0);
```

**Yes.** The body runs once and displays 1. Only then is `number < 0` tested, and it is false, so the loop ends.

```csharp
int number = 1;
while (number < 0)
{
    MessageBox.Show(number.ToString());
}
```

**No.** The condition is tested first. It is false, so the body never runs.

### Choosing a loop

| Loop | Type | Best used when |
|------|------|----------------|
| `while` | Pretest | The number of repetitions is not known and the body might need to run zero times |
| `for` | Pretest | The number of repetitions is known or controlled by a counter |
| `do-while` | Posttest | The body must run at least once, for example asking for input and repeating if it is invalid |

### Checkpoint questions

**Question 5.15:** What is a posttest loop?
**Answer:** A loop that performs an iteration **before** testing its Boolean expression, so it always iterates at least once. The `do-while` loop is a posttest loop.

**Question 5.16:** What is the difference between the `while` loop and the `do-while` loop?
**Answer:** `while` tests first (pretest) and may never iterate. `do-while` tests last (posttest) and always iterates at least once.

**Question 5.17:** How many times will this loop iterate?

```csharp
int count = 0;
do
{
    MessageBox.Show(count.ToString());
    count++;
} while (count < 0);
```

**Answer:** **Once.** It displays 0, then `count` becomes 1, and `1 < 0` is false.

### Lab 5: Pretest versus Posttest Demonstration

**What the program does:** One button runs the `do-while` example above, and another button runs the `while` example. Both start with `number = 1` and the condition `number < 0`.

**Screenshot 1: `do-while` result**



![do-while result](screenshots/do-while-result.png)



**What the screenshot shows:** A message box displaying **1**. The loop body ran once even though the condition was false.

**Screenshot 2: `while` result**



![while result](screenshots/while-result.png)



**What the screenshot shows:** The form after clicking the `while` button, with **no message box**. The body was skipped because the condition was false at the start. Placing the two screenshots side by side makes the pretest and posttest difference clear.

---

## Summary

- A loop repeats statements while a condition is true, and each repetition is an iteration.
- `while` and `for` are pretest loops, and `do-while` is a posttest loop.
- A loop must change something that eventually makes its condition false, or it becomes an infinite loop.
- `++` and `--` add or subtract 1. In postfix mode the old value is used first, and in prefix mode the new value is used.
- Use `for` when a counter controls the loop, `while` when the loop may not run at all, and `do-while` when it must run at least once.

## Deliverables

- [ ] Ending Balance (`while`)
- [ ] Ending Balance with ListBox
- [ ] Postfix and prefix demonstration
- [ ] Squares application (`for`)
- [ ] `do-while` versus `while` demonstration
- [ ] Answers to checkpoint questions 5.9, 5.10, 5.15, 5.16, and 5.17
- [ ] Screenshots of each program running