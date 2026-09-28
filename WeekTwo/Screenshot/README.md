# C# Code Screenshots – Explained

A short study guide that explains five code screenshots from **Chapter 2 – Processing Data** (Visual C#). Each image has a name, a plain explanation, and key points to remember.

| # | Image name | Topic |
|---|------------|-------|
| 1 | `Variable Declaration` | What a variable is and how to declare one |
| 2 | `TextBox Text Property` | Reading, setting, and clearing a TextBox |
| 3 | `Numeric Assignment Compatibility` | Which numeric types can be assigned to which |
| 4 | `Local Variable Scope Error` | Why a variable can't be used in another method |
| 5 | `Try-Catch Exception Handling` | Handling bad user input without crashing |

---

## Image 1 – Variable Declaration

![Variable Declaration](images/01_variable_declaration.jpg)

### What it shows
The definition of a **variable** and the basic syntax for declaring one.

```csharp
DataType VariableName;          // syntax
string name;                    // example
```

### Explanation
- A **variable** is a storage location in memory. Its name is how your code refers to that location.
- You must **declare** a variable before using it. Declaring means telling C# two things: the **type** of data (`string`) and the **name** (`name`).
- `string name;` creates a variable called `name` that can hold text.
- The `//` part is a **comment**: the compiler ignores it, and it is there for humans.

### Analogy
A variable is a **labeled box**. The label is the name, the kind of box is the data type, and what is inside is the value.

### Key points
- Format: **type first, then name, then semicolon**.
- Common types: `string` (text), `int` (whole numbers), `double` (decimals), `decimal` (money).
- Choose meaningful names such as `firstName`, not `x`.

---

## Image 2 – TextBox Text Property

![TextBox Text Property](images/02_textbox_text_property.jpg)

### What it shows
How to put text into a TextBox and three ways to clear it.

```csharp
textBox1.Text = "Hello";            // put text in the box

textBox1.Text = "";                 // empty string
textBox1.Text = string.Empty;       // same thing, more readable
textBox1.Clear();                   // built-in method
```

### Explanation
- The **`Text` property** holds whatever the user typed, and it holds **strings only**.
- Assigning with `=` **replaces** the current content: the value on the right goes into the property on the left.
- To clear the box, all three lines below do the same job:

| Code | How it works |
|------|--------------|
| `Text = ""` | Assigns an empty string |
| `Text = string.Empty` | Assigns the built-in empty string (clearer to read) |
| `Clear()` | A method that removes the text |

### Key points
- Even if the user types `25`, `Text` gives you the **string** `"25"`, not a number. To calculate with it, convert with `int.Parse()` or `double.Parse()`.
- Rename controls (for example `nameTextBox`) instead of keeping `textBox1`.

---

## Image 3 – Numeric Assignment Compatibility

![Numeric Assignment Compatibility](images/03_numeric_assignment_compatibility.jpg)

### What it shows
Which values you may store in `int`, `double`, and `decimal` variables. Lines marked `ERROR` will not compile.

```csharp
// int
int hoursWorked = 40;        // works
int unitsSold = 650m;        // ERROR
int score = -25.5;           // ERROR

// double
double distance = 28.75;     // works
double speed = 75;           // works (int -> double)
double sales = 6500.0m;      // ERROR (decimal -> double)

// decimal
decimal balance = 9280.73m;  // works
decimal price = 50;          // works (int -> decimal)
decimal sales = 6500.0;      // ERROR (double -> decimal)
```

### Explanation
The type of the **literal** (the number you write) must fit the variable:

| Literal | Type it is |
|---------|-----------|
| `40` | `int` |
| `28.75` | `double` |
| `6500.0m` | `decimal` (the `m` means decimal) |

| Variable | Accepts | Rejects |
|----------|---------|---------|
| `int` | `int` | `double`, `decimal` |
| `double` | `double`, `int` | `decimal` |
| `decimal` | `decimal`, `int` | `double` |

**Why the errors happen:**
- `650m` is a decimal and `-25.5` is a double, so neither fits an `int` (it would lose the fractional part).
- `double` and `decimal` are stored in different ways, so C# will not mix them automatically.

### Key points
- An `int` can go into a `double` or `decimal` safely.
- **Never mix `double` and `decimal`** without an explicit cast such as `(double)price`.
- Use `decimal` for money and add the `m` suffix (`19.99m`).

---

## Image 4 – Local Variable Scope Error

![Local Variable Scope Error](images/04_local_variable_scope_error.jpg)

### What it shows
Two button handlers. The variable is declared in the first and used in the second, which fails.

```csharp
private void firstButton_Click(object sender, EventArgs e)
{
    string myName;
    myName = nameTextBox.Text;
}

private void secondButton_Click(object sender, EventArgs e)
{
    outputLabel.Text = myName;      // ERROR: myName does not exist here
}
```

### Explanation
- `myName` is a **local variable**: it belongs only to `firstButton_Click`.
- **Scope** is the part of the program where a variable can be used. A local variable's scope is the method where it was declared.
- **Lifetime:** it is created when the method starts and **destroyed when the method ends**, so `secondButton_Click` has no `myName` to read.

### How to fix it
Declare it as a **field** (at class level, outside any method) so every method can use it:

```csharp
public partial class Form1 : Form
{
    private string myName;      // field: shared by the whole class

    private void firstButton_Click(object sender, EventArgs e)
    {
        myName = nameTextBox.Text;
    }

    private void secondButton_Click(object sender, EventArgs e)
    {
        outputLabel.Text = myName;      // works now
    }
}
```

### Key points
| | Local variable | Field |
|---|----------------|-------|
| Declared | Inside a method | Inside the class, outside methods |
| Scope | That method only | The whole class |
| Lifetime | Until the method ends | While the form exists |

---

## Image 5 – Try-Catch Exception Handling

![Try-Catch Exception Handling](images/05_try_catch_exception_handling.jpg)

### What it shows
A Miles Per Gallon calculator that handles invalid input safely.

```csharp
private void calculateButton_Click(object sender, EventArgs e)
{
    try
    {
        double miles;      // To hold miles driven
        double gallons;    // To hold gallons used
        double mpg;        // To hold MPG

        miles = double.Parse(milesTextBox.Text);      // may throw
        gallons = double.Parse(gallonsTextBox.Text);
        mpg = miles / gallons;
        mpgLabel.Text = mpg.ToString();
    }
    catch
    {
        MessageBox.Show("Invalid data was entered.");
    }
}
```

### Explanation, step by step
1. **Declare** three `double` variables for miles, gallons, and the result.
2. **`double.Parse(...)`** converts the text from the TextBox into a number. This is the risky line: if the user types letters or leaves it blank, it **throws an exception** (a runtime error).
3. `mpg = miles / gallons;` performs the calculation.
4. `mpg.ToString()` turns the number back into text so the label can display it (`Text` accepts strings only).
5. If any statement in `try` fails, the program **jumps straight to `catch`**, skips the remaining try statements, and shows the message.

### Flow
```
User clicks button
      │
      ▼
   try block ──(all OK)──► result shown in mpgLabel
      │
   (error, e.g. "abc")
      ▼
  catch block ──► "Invalid data was entered."
```

### Key points
- Without try-catch, bad input **crashes** the program.
- Put only the **risky** statements in `try`.
- To see the real error text, use `catch (Exception ex) { MessageBox.Show(ex.Message); }`.
- Dividing a `double` by zero gives *Infinity*, not an exception; only integer division by zero throws.

---

## Quick Summary

| Image | Remember |
|-------|----------|
| 1. Variable Declaration | `DataType Name;`, declare before use |
| 2. TextBox Text | `Text` holds strings; clear with `""`, `string.Empty`, or `Clear()` |
| 3. Numeric Compatibility | `int` fits in `double`/`decimal`; never mix `double` and `decimal` |
| 4. Scope | Local variables live only inside their method; use a field to share |
| 5. Try-Catch | Wrap risky code (`Parse`) to handle errors without crashing 