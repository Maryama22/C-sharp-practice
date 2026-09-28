# Chapter 2 – Processing Data (Visual C#)

**Based on:** *Starting Out with Visual C#, 6th Edition* (Tony Gaddis), Chapter 2 (covers book sections 3.1–3.12)

This guide explains every concept in the chapter in detail, with code examples, tables, and **screenshots taken from the slides** (in the `images/` folder). Keep the `images/` folder next to this file so the pictures display.

---

## Table of Contents

1. [Reading Input with TextBox Controls](#1-reading-input-with-textbox-controls)
2. [Variables](#2-variables)
3. [Data Types](#3-data-types)
4. [Variable Names](#4-variable-names)
5. [String Variables and Concatenation](#5-string-variables-and-concatenation)
6. [Declaring Variables Before Use](#6-declaring-variables-before-use)
7. [Local Variables and Scope](#7-local-variables-and-scope)
8. [Duplicate Names and Assignment Compatibility](#8-duplicate-names-and-assignment-compatibility)
9. [Initializing Variables](#9-initializing-variables)
10. [Declaring Multiple Variables](#10-declaring-multiple-variables)
11. [Numeric Data Types](#11-numeric-data-types)
12. [Numeric Literals](#12-numeric-literals)
13. [Assignment Compatibility for Numeric Types](#13-assignment-compatibility-for-numeric-types)
14. [Type Casting](#14-type-casting)
15. [The var Keyword](#15-the-var-keyword)
16. [Performing Calculations](#16-performing-calculations)
17. [Integer Division](#17-integer-division)
18. [Inputting Numeric Values (Parse)](#18-inputting-numeric-values-parse)
19. [Displaying Numeric Values (ToString)](#19-displaying-numeric-values-tostring)
20. [Formatting Numbers](#20-formatting-numbers)
21. [Exception Handling](#21-exception-handling)
22. [Named Constants](#22-named-constants)
23. [Fields](#23-fields)
24. [The Math Class](#24-the-math-class)
25. [More GUI Details](#25-more-gui-details)
26. [Debugging Logic Errors](#26-debugging-logic-errors)
27. [Corrections to Watch For in the Slides](#27-corrections-to-watch-for-in-the-slides)
28. [Quick Reference](#28-quick-reference)
29. [Review Questions](#29-review-questions)

---

## 1. Reading Input with TextBox Controls

A **TextBox** is a rectangular area that accepts keyboard input from the user.

- Found in the **Common Controls** group of the Toolbox.
- **Double-click** it in the Toolbox to add it to the form.
- Default name is `textBoxn` (`textBox1`, `textBox2`, ...). Rename it to something meaningful such as `firstNameTextBox`.

![TextBox control and Toolbox](images/slide-04.jpg)

### The Text property

The `Text` property stores whatever the user typed. It holds **strings only**.

```csharp
textBox1.Text = "Hello";          // put text in the box
```

Three ways to clear a TextBox:

```csharp
textBox1.Text = "";               // empty string
textBox1.Text = string.Empty;     // same thing, more readable
textBox1.Clear();                 // built-in method
```

---

## 2. Variables

A **variable** is a storage location in memory. The variable name represents that memory location.

You must **declare** a variable before you use it.

**Syntax:**

```csharp
DataType VariableName;
```

**Example:**

```csharp
string name;    // declares a variable called name that can hold text
```

Think of a variable as a **labeled box**: the label is the name, the box type is the data type, and what is inside is the value.

---

## 3. Data Types

The **data type** specifies the kind of data a variable can hold. C# has many **primitive data types**: basic, built-in types already defined by the language (you do not create them).

The slide organizes C# types like this:

![Primitive and non-primitive data types](images/slide-08.jpg)

| Category | Types |
|----------|-------|
| **Integral types** | `byte`, `sbyte`, `short`, `ushort`, `int`, `uint`, `long`, `ulong` |
| **Floating-point types** | `float`, `double`, `decimal` |
| **Other basic types** | `char`, `bool`, `string` |
| **Non-primitive: Collections** | `Array`, `List<T>`, `Dictionary<TKey, TValue>` |
| **Non-primitive: User-defined** | `Class`, `Struct`, `Enum`, `Interface` |
| **Non-primitive: Special** | `object`, `dynamic`, `var`, `Delegate` |

The types you will use most in this chapter: **`string`**, **`int`**, **`double`**, **`decimal`**.

---

## 4. Variable Names

Always choose a **meaningful** name (for example `hoursWorked`, not `x`).

**Rules:**

1. The first character must be a **letter** (upper or lower) or an **underscore** `_`.
2. The name **cannot contain spaces**.
3. **Keywords / reserved words** (such as `int`, `class`, `string`) cannot be used as names.

| Name | Valid? |
|------|--------|
| `totalPay` | Yes |
| `_count` | Yes |
| `2ndScore` | No (starts with a digit) |
| `first name` | No (space) |
| `class` | No (reserved word) |

---

## 5. String Variables and Concatenation

### String variables

A **string** is a combination of characters. It can hold names, phone numbers, ID numbers, and so on. Values are written **inside double quotes** on the right of `=`.

```csharp
string productDescription;
productDescription = "Jamhuuriya University";

productLabel.Text = productDescription;      // show in a Label
MessageBox.Show(productDescription);         // show in a message box
```

### Concatenation

**Concatenation** is appending one string to the end of another using the **`+` operator**.

![String concatenation slide](images/slide-11.jpg)

```csharp
//Declaring variable
string message;

//Concatenation of two strings
message = "Jamhuuriya" + "University";     // JamhuuriyaUniversity (no space!)

//Display using MessageBox
MessageBox.Show(message);
```

Add `" "` to put a space between the words:

```csharp
message = "Jamhuuriya" + " " + "University";   // Jamhuuriya University
```

**Concatenating a string with another data type** also works:

```csharp
string value;
value = 2025 + " Jamhuuriya Class";      // "2025 Jamhuuriya Class"
"Total is " + 25.75;                     // "Total is 25.75"
```

### String Variable Demo application

The form has two TextBoxes (`firstNameTextBox`, `lastNameTextBox`), a Label (`fullNameLabel`), and two buttons (`showNameButton`, `exitButton`).

![String Variable Demo application](images/slide-12.jpg)

---

## 6. Declaring Variables Before Use

The demo's button handler declares a variable, fills it, and displays it:

![Declaring variables before using them](images/slide-13.jpg)

```csharp
private void showNameButton_Click(object sender, EventArgs e)
{
    // Declare a string variable to hold the full name.
    string fullname;

    // Combine the names with a space between them.
    // Assign the result to the fullname variable.
    fullname = firstNameTextBox.Text + " " + lastNameTextBox.Text;

    // Display the fullname variable in the fullNameLabel control.
    fullNameLabel.Text = fullname;
}

private void exitButton_Click(object sender, EventArgs e)
{
    // Close the form.
    this.Close();
}
```

The three arrows in the slide mark: **(1) declare**, **(2) assign**, **(3) display**. This is the standard *Input → Process → Output* pattern.

---

## 7. Local Variables and Scope

| Term | Meaning |
|------|---------|
| **Local variable** | A variable declared inside a method; it belongs to that method |
| **Scope** | The part of the program where a variable can be accessed |
| **Lifetime** | How long the variable exists in memory |

- Only statements **inside the same method** can use a local variable.
- A local variable is **created** when the method starts and **destroyed** when the method ends.

![Local variable scope error](images/slide-14.jpg)

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

`myName` was declared in `firstButton_Click`, so `secondButton_Click` cannot see it. To share a variable between methods, use a **field** (see [Section 23](#23-fields)).

---

## 8. Duplicate Names and Assignment Compatibility

### Duplicate variable names
- You **cannot** declare two variables with the **same name in the same scope**.
- You **can** use the same name in **different methods**, because each has its own scope.

### Assignment compatibility
A value can be assigned to a variable only if it is **compatible** with the variable's data type. Only strings are compatible with `string`:

```csharp
string name = "Ali";     // OK
string age = 25;         // ERROR: number is not a string
```

### Home assignment: Birth Date String form

Build a form that takes the day of the week, month name, numeric day, and year, then joins them into one date sentence.

![Birth Date String form](images/slide-16.jpg)

| Control | Name |
|---------|------|
| Prompt labels | `dayOfWeekPromptLabel`, `monthPromptLabel`, `dayOfMonthPromptLabel`, `yearPromptLabel` |
| TextBoxes | `dayOfWeekTextBox`, `monthTextBox`, `dayOfMonthTextBox`, `yearTextBox` |
| Output label | `dateOutputLabel` |
| Buttons | `showDateButton`, `clearButton`, `exitButton` |

**Hint:** join the pieces with concatenation, for example `"I was born on " + day + ", " + month + " " + dayNum + ", " + year`.

---

## 9. Initializing Variables

In C#, a variable **must be assigned a value before it is used**. The compiler refuses to build code that reads an unassigned variable.

![Unassigned variable error](images/slide-17.jpg)

```csharp
string Faculty;
MessageBox.Show(Faculty);     // ERROR: Use of unassigned local variable 'Faculty'
```

**Fix:** assign a value first.

```csharp
string Faculty = "Computer Science";    // declare and initialize together
MessageBox.Show(Faculty);
```

---

## 10. Declaring Multiple Variables

Variables of the **same type** can be declared in one statement:

```csharp
string lastName, firstName, middleName;
```

Long declarations can be split across lines and initialized:

```csharp
string lastName = "Khalaf",
       firstName = "Mohamed",
       middleName = "Abdullahi";
```

---

## 11. Numeric Data Types

To do math with a value, store it in a **numeric** type.

| Type | Holds | Notes |
|------|-------|-------|
| **`int`** | Whole numbers | Range: −2,147,483,648 to 2,147,483,647 |
| **`double`** | Real numbers (with fractions) | General-purpose decimals; less precise |
| **`decimal`** | Real numbers with **greater precision** | Best for money and financial applications |

---

## 12. Numeric Literals

A **numeric literal** is a number written directly in code.

```csharp
int hoursWorked = 40;
double temperature = 87.6;
decimal payRate = 28.75m;
```

Rules:

- Literals are **not** put in quotes.
- A whole number such as `40` is an **`int`**.
- A number with a decimal point such as `87.6` is a **`double`**.
- Add **`M` or `m`** to make a **`decimal`** literal (`28.75m`).

| Literal | Type |
|---------|------|
| `99` | int |
| `3.14` | double |
| `1.0` | double |
| `28.75m` | decimal |

---

## 13. Assignment Compatibility for Numeric Types

| Variable type | Can receive | Cannot receive |
|---------------|-------------|----------------|
| `int` | `int` | `double`, `decimal` |
| `double` | `double`, `int` | `decimal` |
| `decimal` | `decimal`, `int` | `double` |

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

**Memory trick:** a value can move to a "wider" type automatically (int → double, int → decimal), but never between `double` and `decimal` without a cast.

---

## 14. Type Casting

**Casting** explicitly converts a value from one type to another. Use the **cast operator**: the target type in parentheses.

```csharp
int wholeNumber;
decimal moneyNumber = 4500m;
wholeNumber = (int)moneyNumber;        // 4500

double realNumber;
decimal moneyNumber2 = 625.70m;
realNumber = (double)moneyNumber2;     // 625.7
```

> **Warning:** casting to `int` **drops** the fractional part (no rounding). `(int)9.99` gives `9`.
>
> You **cannot** use a cast to convert a **string** to a number. Use `Parse` (Section 18).

---

## 15. The var Keyword

`var` lets the compiler **figure out the type** from the value you assign. This is called **type inference**.

```csharp
var interestRate = 12.0;        // double
var stockCode = "D465U";        // string
var accountBalance = 1000.0m;   // decimal
```

Rules:

- You **must** give an initial value.
- The type is decided at compile time from that value and then never changes.
- `var` can be used **only for local variables** (inside methods).

---

## 16. Performing Calculations

### Math operators

| Operator | Name | Description | Example | Result |
|----------|------|-------------|---------|--------|
| `+` | Addition | Adds two numbers | `7 + 3` | 10 |
| `-` | Subtraction | Subtracts one number from another | `7 - 3` | 4 |
| `*` | Multiplication | Multiplies | `7 * 3` | 21 |
| `/` | Division | Gives the quotient | `7 / 2.0` | 3.5 |
| `%` | Modulus | Gives the remainder | `7 % 3` | 1 |

### Math expressions

```csharp
int x = 5, y = 4;
MessageBox.Show((x + y).ToString());     // 9

result = (a + b) / 4;                    // parentheses control the order
```

Follow the **order of operations**: parentheses first, then `*` `/` `%`, then `+` `-`.

### Mixed data types

| Operation | Result type |
|-----------|-------------|
| `int` with `double` | `double` |
| `int` with `decimal` | `decimal` |
| `double` with `decimal` | **Not allowed** |

---

## 17. Integer Division

Dividing an `int` by an `int` gives an `int`: the fraction is thrown away.

```csharp
int x = 7, y = 3;
MessageBox.Show((x / y).ToString());      // 2  (not 2.33)
```

**Ways to avoid it:**

```csharp
// 1. Cast one operand
MessageBox.Show(((double)x / y).ToString());     // 2.3333333333333335

// 2. Declare the variables as double
double a = 7, b = 3;
MessageBox.Show((a / b).ToString());             // 2.3333333333333335
```

---

## 18. Inputting Numeric Values (Parse)

A TextBox always gives you a **string**, even if the user types `25.65`. You cannot cast a string to a number. Use the **Parse** methods:

| Method | Converts to |
|--------|-------------|
| `int.Parse()` | `int` |
| `double.Parse()` | `double` |
| `decimal.Parse()` | `decimal` |

```csharp
int hoursWorked = int.Parse(hoursWorkedTextBox.Text);
double temperature = double.Parse(temperatureTextBox.Text);
decimal payRate = decimal.Parse(payRateTextBox.Text);
```

If the text is not a valid number (for example `"asdf"`), Parse throws an **exception**. See [Section 21](#21-exception-handling).

### Parsing with a culture (example slide)

Number formats differ by country (for example, `1,234.56` vs `1.234,56`). You can tell .NET which culture to use:

![Parsing with culture](images/slide-29.jpg)

```csharp
using System.Globalization;

double number = double.Parse(textBox1.Text, CultureInfo.GetCultureInfo("de-DE"));
MessageBox.Show(number.ToString("N", CultureInfo.GetCultureInfo("de-DE")));

number.ToString("N", CultureInfo.GetCultureInfo("en-US"));   // US
number.ToString("N", CultureInfo.GetCultureInfo("en-GB"));   // UK
number.ToString("N", CultureInfo.GetCultureInfo("fr-FR"));   // France
number.ToString("N", CultureInfo.GetCultureInfo("de-DE"));   // Germany
number.ToString("N", CultureInfo.GetCultureInfo("so-SO"));   // Somalia
```

---

## 19. Displaying Numeric Values (ToString)

The `Text` property accepts **strings only**, so numbers must be converted first with **`ToString()`**.

```csharp
decimal grossPay = 1550.0m;
grossPayLabel.Text = grossPay.ToString();

int myNumber = 123;
MessageBox.Show(myNumber.ToString());
```

**General format:** `variableName.ToString()`

**Alternative (implicit conversion with `+`):**

```csharp
int idNumber = 1044;
string output = "Your ID number is " + idNumber;
```

### Home assignment: Fuel Economy form

![Fuel Economy form](images/slide-31.jpg)

| Control | Name |
|---------|------|
| TextBoxes | `milesTextBox`, `gallonsTextBox` |
| Output label | `mpgLabel` |
| Buttons | `calculateButton`, `exitButton` |

Formula: `mpg = miles / gallons`

---

## 20. Formatting Numbers

`ToString` can take a **format string** to control how the number looks.

| Format | Name | Number | Code | Result |
|--------|------|--------|------|--------|
| `"N"` / `"n"` | Number (with separators) | 12.3 | `ToString("n3")` | `12.300` |
| `"F"` / `"f"` | Fixed-point | 123456.0 | `ToString("f2")` | `123456.00` |
| `"E"` / `"e"` | Exponential (scientific) | 123456.0 | `ToString("e3")` | `1.235e+005` |
| `"C"` / `"c"` | Currency | −1234567.8 | `ToString("C")` | `($1,234,567.80)` |
| `"P"` / `"p"` | Percent | 0.234 | `ToString("P")` | `23.40%` |

The number after the letter is the **count of digits after the decimal point**.

> The exact output depends on the computer's regional settings (currency symbol, separators, negative-number style).

### Home assignment: Sale Price Calculator

![Sale Price Calculator form](images/slide-33.jpg)

| Control | Name |
|---------|------|
| TextBoxes | `originalPriceTextBox`, `discountPercentageTextBox` |
| Output label | `salePriceLabel` |
| Buttons | `calculateButton`, `exitButton` |

Idea: `salePrice = originalPrice - (originalPrice * discountPercent / 100)`, then show it with `ToString("C")`.

---

## 21. Exception Handling

An **exception** is an unexpected **runtime error**. Examples:

- Dividing by zero
- Opening a file that does not exist
- **Invalid user input** (for example, letters where a number is expected)

If an exception is **not handled**, the program **crashes**. **Exception handling** means writing code that catches the error and decides what to do instead. That code is an **exception handler**.

### try-catch

```csharp
try
{
    // statements that might cause an exception
}
catch
{
    // statements that respond to the exception
}
```

- **try block:** risky statements go here.
- **catch block:** runs only if an exception occurs in the try block; the program then **jumps** to it.

### Throwing an exception (Miles Per Gallon example)

![try-catch example, jump to catch](images/slide-36.jpg)

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

If `double.Parse(milesTextBox.Text)` fails, the remaining try statements are **skipped** and the catch block runs.

### Throwing vs. catching

| Term | Meaning | ATM example | Car example |
|------|---------|-------------|-------------|
| **Throwing** | The error is raised (problem occurs) | Wrong PIN entered: "Invalid PIN" error is raised | Fuel runs out |
| **Catching** | The error is handled | ATM shows "Invalid PIN, please try again" instead of shutting down | Dashboard warning light instead of a sudden stall |

### Displaying the exception's default message

Every exception is an **object** with a **`Message`** property that describes the error.

```csharp
try
{
    // risky statements
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

### Practice: Test Average application

Enter three test scores; show the average. If the input is invalid, show the exception message.

![Test Average application](images/slide-39.jpg)

### Solution code

![Test Average solution](images/slide-40.jpg)

```csharp
private void btnCalculate_Click(object sender, EventArgs e)
{
    try
    {
        // Declaring variables to store input user data
        double test1, test2, test3, average;

        // Get the three test scores
        test1 = double.Parse(txtTest1.Text);
        test2 = double.Parse(txtTest2.Text);
        test3 = double.Parse(txtTest3.Text);

        // Calculate the average test score
        average = (test1 + test2 + test3) / 3;

        // Display the average, rounded to 1 decimal point
        lblAverage.Text = average.ToString("n1");
    }
    catch (Exception ex)
    {
        // Display the default error message
        MessageBox.Show(ex.Message);
    }
}

private void btnClear_Click(object sender, EventArgs e)
{
    // Clear the input and output controls
    txtTest1.Text = "";
    txtTest2.Text = "";
    txtTest3.Text = "";
    lblAverage.Text = "";
}

private void btnExit_Click(object sender, EventArgs e)
{
    // Close the form
    this.Close();
}
```

With input `asdf`, the message box shows: *"Input string was not in a correct format."*

---

## 22. Named Constants

A **named constant** is a name that represents a value that **cannot change** while the program runs. Declare it with the **`const`** keyword.

```csharp
const double INTEREST_RATE = 0.129;
```

- Uppercase names are a **tradition**, not a requirement.
- Trying to assign a new value later causes a compile error.

**Why use constants?** They give numbers a meaningful name (`INTEREST_RATE` is clearer than `0.129`), and if the value must change, you change it in **one place**.

---

## 23. Fields

A **field** is a variable declared at the **class level**: inside the class but **outside any method**.

- A field's **scope is the entire class**, so every method can use it.
- It is created in memory when the form is created.

**Local variable vs field:**

| | Local variable | Field |
|---|----------------|-------|
| Declared | Inside a method | Inside the class, outside methods |
| Scope | That method only | Whole class |
| Lifetime | Until the method ends | Until the form is closed |

### FieldDemo application

![FieldDemo code](images/slide-43.jpg)

```csharp
namespace FieldDemo
{
    public partial class Form1 : Form
    {
        // Declare a private field to hold a name.
        private string name = "Charles";

        public Form1()
        {
            InitializeComponent();
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }

        private void dariusButton_Click(object sender, EventArgs e)
        {
            name = "Darius";
        }

        private void carmenButton_Click(object sender, EventArgs e)
        {
            name = "Carmen";
        }
    }
}
```

Clicking the Darius button changes the field; clicking Show Name afterward displays "Darius", because the value **persists** between clicks.

---

## 24. The Math Class

The .NET **Math** class provides methods for complex calculations.

| Method / Constant | Description | Example | Result |
|-------------------|-------------|---------|--------|
| `Math.Sqrt(x)` | Square root of x | `Math.Sqrt(16)` | 4 |
| `Math.Pow(x, y)` | x raised to the power y | `Math.Pow(2, 3)` | 8 |
| `Math.Max(x, y)` | Greater of the two values | `Math.Max(5, 9)` | 9 |
| `Math.Min(x, y)` | Lesser of the two values | `Math.Min(5, 9)` | 5 |
| `Math.Round(x)` | Nearest integer | `Math.Round(4.6)` | 5 |
| `Math.PI` | Ratio of circumference to diameter | | 3.14159... |
| `Math.E` | Natural logarithm base | | 2.71828... |

**Example: area of a circle**

```csharp
double radius = double.Parse(radiusTextBox.Text);
double area = Math.PI * Math.Pow(radius, 2);
areaLabel.Text = area.ToString("n2");
```

---

## 25. More GUI Details

### Focus and tab order

- **Focus:** the control that currently receives keyboard input.
- When a button has focus, pressing **Enter** runs its Click handler.
- **Tab order:** the order in which controls receive focus when the user presses **Tab**.
- The **`TabIndex`** property holds the position, starting at **0** (first control = 0, nth control = n − 1).

**Setting the tab order:** **View menu → Tab Order**, then click the controls in the order you want.

- Labels **cannot receive focus**, so their TabIndex values do not matter.

**Changing focus in code:**

```csharp
private void clearButton_Click(object sender, EventArgs e)
{
    nameTextBox.Text = "";
    nameTextBox.Focus();      // cursor goes back to the name box
}
```

### Keyboard access keys

An **access key** (mnemonic) is pressed with **Alt** to activate a control quickly. Put an **ampersand `&`** before a letter in the button's `Text` property.

![Access key on the Exit button](images/slide-48.jpg)

- `E&xit` makes **Alt + X** (or Alt + x) activate the button. The letter X appears underlined.
- Access keys are **not case-sensitive**.

### Setting colors

- Forms and most controls have **`BackColor`**.
- Controls that display text also have **`ForeColor`**.
- The color drop-down has three tabs: **Custom** (palette), **Web**, **System**.

![Color property tabs](images/slide-49.jpg)

```csharp
messageLabel.BackColor = Color.Black;
messageLabel.ForeColor = Color.Yellow;
```

### Background images for forms

- **`BackgroundImage`** works like a PictureBox's `Image`.
- **`BackgroundImageLayout`** works like `SizeMode`.

| Layout | Effect |
|--------|--------|
| **None** | Image at the upper-left corner |
| **Tile** | Image repeated to fill the form |
| **Center** | Image centered |
| **Stretch** | Image stretched to fill the form (may distort) |
| **Zoom** | Image enlarged to fit while keeping proportions |

![Background image layouts](images/slide-51.jpg)

### GroupBox vs. Panel

Both are **containers** that hold other controls.

| Feature | GroupBox | Panel |
|---------|----------|-------|
| Title (`Text` property) | Yes | No |
| Border | Thin border, fixed | Set with `BorderStyle` |
| Typical use | Group related options with a caption | Group controls visually or by layout |

![GroupBox versus Panel](images/slide-52.jpg)

---

## 26. Debugging Logic Errors

A **logic error** does **not** stop the program from running, but the results are **wrong**. Common causes:

- Mathematical mistakes (wrong formula)
- Assigning a value to the wrong variable
- Assigning the wrong value to a variable

Finding logic errors takes detective work. Visual Studio's debugger helps.

### Breakpoints

A **breakpoint** is a line you mark in the code. When the running program reaches it, execution **pauses** and enters **break mode**.

**To set a breakpoint:** click in the gray margin to the left of the line (a **red dot** appears).

![Setting a breakpoint](images/slide-55.jpg)

### Break mode

While paused, **hover the mouse** over a variable or property to see its current value.

![Break mode: hover to inspect a value](images/slide-56.jpg)

### Locals and Watch windows

| Window | Shows |
|--------|-------|
| **Locals** | All variables in the current method, with **name, value, and type** |
| **Watch** | Only the variables **you add**; you can open several Watch windows |

**To open:** menu **Debug → Windows →** choose the window.

![Locals window](images/slide-59.jpg)

### Single-stepping

**Single-stepping** runs statements **one at a time** after a breakpoint. After each step you can check variables and pinpoint the faulty line.

Ways to step:

- Press **F11**
- Click **Step Into** on the toolbar
- **Debug menu → Step Into**

![Debug toolbar](images/slide-61.jpg)

| Command | Purpose |
|---------|---------|
| Start / Continue | Run or resume the program |
| Break All | Pause the running program |
| Stop Debugging | End the debug session |
| **Step Into** (F11) | Execute one statement, entering any method it calls |
| **Step Over** (F10) | Execute one statement without entering called methods |
| **Step Out** (Shift+F11) | Finish the current method and return to the caller |

**Debugging workflow:**

1. Set a breakpoint near where the problem might start.
2. Run the program and trigger the code.
3. When it pauses, inspect variable values.
4. Step through line by line.
5. Find where a value first becomes wrong, then fix the code.
6. Remove the breakpoint and test again.

---

## 27. Corrections to Watch For in the Slides

| Slide text | Correct version |
|-----------|-----------------|
| "productDescription" in the error message on the Initializing slide, while the code uses `Faculty` | The message names whichever variable is unassigned (here: `Faculty`) |
| `messsage`, `varible` (spelling in code comments) | `message`, `variable` |
| `Average = (test1+test2+test3)/3` uses capital `A` in the solution | Works only if the variable is also declared as `Average`; keep the case **consistent** (C# is case-sensitive) |
| `int score = −25.5;` | Still an error: a `double` cannot go into an `int`; the minus sign is typed as a special dash on the slide |
| "Percentage" for `%` | The `%` symbol is the **modulus** operator |
| Slide 32 label "Fixed-point scientific format" for `F` | `F` is **fixed-point**; only `E` is scientific |

---

## 28. Quick Reference

### Data types

| Type | Example |
|------|---------|
| `string` | `"Hello"` |
| `int` | `40` |
| `double` | `87.6` |
| `decimal` | `28.75m` |

### Conversions

| Goal | Code |
|------|------|
| string → int | `int.Parse(text)` |
| string → double | `double.Parse(text)` |
| string → decimal | `decimal.Parse(text)` |
| number → string | `value.ToString()` |
| decimal → int | `(int)value` |
| decimal → double | `(double)value` |

### Common statements

| Purpose | Code |
|---------|------|
| Declare | `int count;` |
| Declare and initialize | `int count = 0;` |
| Constant | `const double TAX = 0.05;` |
| Type inference | `var name = "Ali";` |
| Clear TextBox | `textBox1.Clear();` |
| Try-catch | `try { ... } catch (Exception ex) { MessageBox.Show(ex.Message); }` |
| Square root | `Math.Sqrt(25)` |
| Set focus | `nameTextBox.Focus();` |
| Set colors | `label1.ForeColor = Color.Red;` |

### Glossary

| Term | Meaning |
|------|---------|
| Variable | Named storage location in memory |
| Data type | Kind of data a variable can hold |
| Literal | A value written directly in code |
| Concatenation | Joining strings with `+` |
| Scope | Where a variable can be accessed |
| Field | Class-level variable |
| Constant | Named value that cannot change |
| Cast | Explicit type conversion |
| Parse | Convert a string to a number |
| Exception | Runtime error |
| Breakpoint | Line where the debugger pauses |
| Tab order | Order controls get focus |
| Access key | Alt + letter shortcut |

---

## 29. Review Questions

1. What does the `Text` property of a TextBox hold, and what type is it?
2. Give three ways to clear a TextBox.
3. What is a variable? Write the general syntax for declaring one.
4. What are the rules for variable names?
5. What is concatenation? What does `"Total is " + 25.75` produce?
6. What is a local variable? What is its scope and lifetime?
7. Why does the compiler reject `string s; MessageBox.Show(s);`?
8. Which type is best for money? Why?
9. Which assignments fail: `int a = 5.5;`, `double b = 7;`, `decimal c = 6.5;`, `decimal d = 10;`?
10. What is the value of `7 / 3` with ints? Show two ways to get `2.333...`.
11. Why can't you cast a string to a number? What do you use instead?
12. What does `var` do? What are its restrictions?
13. What does `ToString("C")` do? How about `ToString("P")`?
14. What is an exception? What is the difference between throwing and catching?
15. Write a try-catch that parses an integer from a TextBox and shows `ex.Message` on error.
16. What is a named constant and how do you declare one?
17. What is a field, and how does it differ from a local variable?
18. List five methods or constants from the Math class.
19. What is tab order? How do you set it? How do you create the access key Alt + X on an Exit button?
20. What is a logic error? Explain breakpoints and single-stepping.

---

**End of Chapter 2 study guide.**