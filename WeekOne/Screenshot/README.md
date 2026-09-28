# Full Name Concatenation (C# Windows Forms)

A simple C# Windows Forms application that takes a **first name** and a **second name** from the user, joins them together (concatenation), and displays the **full name** on the screen when a button is clicked.

---



## Overview

This project demonstrates the basic programming flow of **Input → Process → Output** using string variables and string concatenation in C#.

- **Input:** The user types a first name and a second name into two text boxes.
- **Process:** The program combines both names with a space between them.
- **Output:** The combined full name is shown in a label/text control.

It is an ideal beginner project for understanding variables, data types, events, and UI controls in Windows Forms.

---

## Features

- Reads text entered by the user in two TextBoxes
- Stores the values in `String` variables
- Concatenates the names using the `+` operator
- Adds a space between the first and second names
- Displays the result in the `Fullname` control
- Runs inside a button click event handler

---

## Technologies Used

| Item | Description |
|------|-------------|
| Language | C# |
| Framework | .NET Windows Forms (WinForms) |
| IDE | Visual Studio |
| Concepts | Variables, strings, events, concatenation |

---

## User Interface

The form contains the following controls:

| Control | Name | Purpose |
|---------|------|---------|
| TextBox | `FirstnameTextBox` | User enters the first name |
| TextBox | `SecondNameTextBox` | User enters the second name |
| Button | `button1` | Triggers the concatenation when clicked |
| Label / TextBox | `Fullname` | Displays the final full name |

Suggested layout:

```
+--------------------------------------+
|  First Name:   [ FirstnameTextBox ]  |
|  Second Name:  [ SecondNameTextBox ] |
|                                      |
|            [   Button   ]            |
|                                      |
|  Full Name:    [ Fullname ]          |
+--------------------------------------+
```

---

## How It Works

1. The user types their first and second name.
2. The user clicks the button.
3. The `button1_Click` event handler runs.
4. Three string variables are created.
5. The text from the text boxes is copied into `Fname` and `Sname`.
6. `Fname`, a space `" "`, and `Sname` are joined into `fullname`.
7. `fullname` is assigned to `Fullname.Text`, so it appears on the screen.

**Flow diagram:**

```
 [Input]                 [Process]                     [Output]
 FirstnameTextBox  --->  Fname  \
                                 +--> Fname + " " + Sname --> fullname --> Fullname.Text
 SecondNameTextBox --->  Sname  /
```

---

## Full Source Code

```csharp
private void button1_Click(object sender, EventArgs e)
{
    //creating variables
    String Fname;
    String Sname;
    String fullname;

    // input
    Fname = FirstnameTextBox.Text;
    Sname = SecondNameTextBox.Text;

    //process of concatenation
    fullname = Fname + " " + Sname;

    //output
    Fullname.Text = fullname;
}
```

---

## Code Explanation (Step by Step)

### 1. The event handler

```csharp
private void button1_Click(object sender, EventArgs e)
{
    ...
}
```

- This method is an **event handler**. It runs automatically every time the user clicks `button1`.
- `private` means it can only be used inside this form class.
- `void` means the method does not return any value.
- `object sender` is the control that raised the event (here, the button).
- `EventArgs e` holds extra information about the event (not needed in this simple example).

### 2. Creating variables

```csharp
//creating variables
String Fname;
String Sname;
String fullname;
```

Three variables of type `String` are declared. A `String` stores text.

| Variable | Purpose |
|----------|---------|
| `Fname` | Holds the first name typed by the user |
| `Sname` | Holds the second name typed by the user |
| `fullname` | Holds the final combined name |

> Note: `String` (capital S) is the .NET class name. It is the same as the C# keyword `string` (lowercase). Both work, and `string` is the more common style.

### 3. Input

```csharp
// input
Fname = FirstnameTextBox.Text;
Sname = SecondNameTextBox.Text;
```

- `FirstnameTextBox.Text` reads whatever the user typed in the first text box.
- `SecondNameTextBox.Text` reads whatever the user typed in the second text box.
- The `=` operator is the **assignment operator**. It stores the value on the right into the variable on the left.

### 4. Process (concatenation)

```csharp
//process of concatenation
fullname = Fname + " " + Sname;
```

**Concatenation** means joining strings together. In C#, the `+` operator does this when used with strings.

Here three parts are joined:

1. `Fname` – the first name
2. `" "` – a single space (so the names do not stick together)
3. `Sname` – the second name

Without the `" "`, the result would look like `AhmedAli` instead of `Ahmed Ali`.

### 5. Output

```csharp
//output
Fullname.Text = fullname;
```

- The value stored in `fullname` is assigned to the `.Text` property of the `Fullname` control.
- This updates what the user sees on the form.

> Important: `fullname` (lowercase, the variable) and `Fullname` (capital F, the control) are **different things**. C# is **case-sensitive**.

---

## Example Run

| Step | Action | Value |
|------|--------|-------|
| 1 | User types first name | `Maryan` |
| 2 | User types second name | `Ahmed` |
| 3 | User clicks the button | Event runs |
| 4 | `Fname` | `"Maryan"` |
| 5 | `Sname` | `"Ahmed"` |
| 6 | `fullname = Fname + " " + Sname` | `"Maryan Ahmed"` |
| 7 | Output displayed | `Maryan Ahmed` |

---

## Key Concepts Learned

- **Variables and data types:** declaring `String` variables to store text.
- **Properties:** using `.Text` to read from and write to controls.
- **Assignment:** storing values with `=`.
- **String concatenation:** joining text with `+`.
- **Event-driven programming:** code that runs in response to user actions like a click.
- **Input–Process–Output model:** the basic structure of most programs.
- **Comments:** using `//` to document code sections.

---

## Common Mistakes and Tips

| Mistake | Explanation / Fix |
|---------|-------------------|
| Forgetting the space `" "` | Names will be joined without a gap. Always add `" "` between them. |
| Mixing up `fullname` and `Fullname` | C# is case-sensitive. One is a variable, the other is a control. |
| Wrong control names | The names in code must exactly match the control names in the Designer. |
| Missing semicolon `;` | Every statement in C# must end with a semicolon. |
| Empty text boxes | The result will be blank or just a space. Add validation (see below). |

**Tip:** You can shorten the code by skipping the temporary variables:

```csharp
Fullname.Text = FirstnameTextBox.Text + " " + SecondNameTextBox.Text;
```

Or use string interpolation:

```csharp
Fullname.Text = $"{FirstnameTextBox.Text} {SecondNameTextBox.Text}";
```

The longer version in this project is intentionally step by step, which is better for learning.

---

## Possible Improvements

1. **Input validation** – check that both text boxes are not empty:

   ```csharp
   if (string.IsNullOrWhiteSpace(FirstnameTextBox.Text) ||
       string.IsNullOrWhiteSpace(SecondNameTextBox.Text))
   {
       MessageBox.Show("Please enter both names.");
       return;
   }
   ```

2. **Trim extra spaces** using `.Trim()`:

   ```csharp
   Fname = FirstnameTextBox.Text.Trim();
   Sname = SecondNameTextBox.Text.Trim();
   ```

3. **Add a third (middle/last) name** field.
4. **Add a Clear button** to reset all fields.
5. **Capitalize names automatically** (for example, `ahmed` → `Ahmed`).
6. **Use better control names** such as `btnShowFullName` instead of `button1`.

---

## How to Run the Project

1. Open the project in **Visual Studio**.
2. Make sure the form has the controls named as listed in [User Interface](#user-interface).
3. Double-click the button in the Designer to generate `button1_Click`, then paste in the code.
4. Press **F5** (or click **Start**) to run the application.
5. Enter a first name and second name, then click the button.
6. The full name appears in the output control.

---

## Summary

This small project shows how a Windows Forms application takes user input, processes it using string concatenation, and displays the result. Mastering this pattern is the foundation for building larger and more interactive C# applications.