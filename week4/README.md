# Week 4 : Making Decisions (Part 2)


**Chapter 3:** Making Decisions
**Topics:** `bool` variables and flags, comparing strings, `TryParse`, input validation, RadioButton and CheckBox, the `switch` statement, ListBox

## Introduction

Week 3 introduced the core decision statements. Week 4 builds on them with the practical tools needed for real Windows Forms applications: storing the result of a decision in a variable, comparing text, protecting a program from bad input, reading choices from radio buttons and check boxes, selecting among many values with `switch`, and working with lists of items. Together, these features let a program accept user input safely and respond to it correctly.

## Learning Objectives

By the end of this lab you should be able to:

- Use `bool` variables as flags
- Compare strings correctly
- Use `TryParse` to prevent conversion exceptions
- Validate input so that it is both a number and a sensible number
- Use RadioButton and CheckBox controls and the `CheckedChanged` event
- Write a `switch` statement with `case` and `default` sections
- Add, remove, and read items in a ListBox

---

## 1. `bool` Variables and Flags

A `bool` variable can hold only two values: `true` or `false`. A **flag** is a `bool` variable that signals whether some condition exists in the program.

- `false` means the condition does not exist yet.
- `true` means the condition exists.

Flags are useful because a decision made in one place can be remembered and used later in another place, without repeating the original test.

```csharp
double points;
bool isGrandMaster;

points = double.Parse(txtPoints.Text);

if (points > 5000)
{
    isGrandMaster = true;
}
else
{
    isGrandMaster = false;
}

lblResult.Text = isGrandMaster.ToString();
```

**Screenshot 1:**



![Grand Master true](screenshots/grandmaster-true.png)



**What it shows:** 6000 points were entered. Since 6000 is greater than 5000, the flag is set to true and the result label shows **True**.

**Screenshot 2:**



![Grand Master false](screenshots/grandmaster-false.png)



**What it shows:** 3200 points were entered. The condition fails, the flag is set to false, and the label shows **False**. Together the two screenshots show both values the flag can hold.

---

## 2. Comparing Strings

Strings can be compared using relational operators and methods. The `==` and `!=` operators compare two strings, or a string variable and a string literal. The `String.Compare` method (and `CompareTo`) returns `0` when the two strings are equal.

```csharp
if (name1 == name2)
{
}

if (name1 != "bob")
{
}

if (String.Compare(name1, name2) == 0)
{
}

if (name1.CompareTo(name2) == 0)
{
}
```

Remember that string comparison is case sensitive by default, so `"Bob"` and `"bob"` are not equal.

---

## 3. Preventing Data Conversion Exceptions with `TryParse`

When a user types text into a text box, the program must convert it to a number. If the user types something that is not a number, `int.Parse` and `double.Parse` throw an exception and the program can crash. Exceptions should be prevented when possible.

The `TryParse` methods solve this. They attempt the conversion and return `true` on success or `false` on failure, without throwing an exception.

- `int.TryParse`
- `double.TryParse`
- `decimal.TryParse`

```csharp
dataType.TryParse(string input, out targetVariable)
```

The `out` keyword is required. It tells C# that `targetVariable` is an **output variable**: the method places the converted value into it.

```csharp
int hours;
if (int.TryParse(hoursTextBox.Text, out hours))
{
    // The conversion succeeded and hours holds the number
}
else
{
    MessageBox.Show("Please enter a number.");
}
```

---

## 4. Input Validation

**Input validation** is the process of inspecting data entered into a program to make sure it is valid before it is used.

There are two separate questions to ask about user input:

1. Is it the right **type**? (Is it a number at all?) `TryParse` answers this.
2. Is it a **reasonable value**? (Is the number within a sensible range?) A decision structure answers this.

`TryParse` does not check data integrity. If the user types `999`, `TryParse` happily reports success, because 999 is a valid number. But no one can work 999 hours in a week, so the data is not logical. A payroll program should therefore also check the range:

```csharp
int hours;
if (int.TryParse(hoursTextBox.Text, out hours))
{
    if (hours > 0 && hours <= 168)
    {
        statusLabel.Text = "Valid: " + hours + " hours accepted.";
    }
    else
    {
        statusLabel.Text = "Hours must be between 1 and 168.";
    }
}
else
{
    statusLabel.Text = "Not a number (TryParse failed).";
}
```

The same idea applies to test scores: `if (testScore >= 0 && testScore <= 100)`.

**Screenshot 1: valid input**



![Valid](screenshots/validation-valid.png)



**What it shows:** The value 40 passed both checks. It is a number and it lies between 1 and 168, so the program accepts it.

**Screenshot 2: a number that is not reasonable**



![999](screenshots/validation-999.png)



**What it shows:** The value 999 is a valid number, so `TryParse` succeeded, but it is greater than 168, so the range check rejected it. This screenshot demonstrates the difference between checking type and checking integrity.

**Screenshot 3: not a number**



![abc](screenshots/validation-text.png)



**What it shows:** The text `abc` made `TryParse` return false. The program displayed an error message and did not crash, which is exactly why `TryParse` is preferred over `Parse` for user input.

---

## 5. Radio Buttons and Check Boxes

These two controls let the user make choices without typing.

**RadioButton** lets the user select **one** choice from several. When one radio button is clicked, the program automatically deselects the others in the same group. This is called **mutually exclusive selection**: only one can be selected at a time.

**CheckBox** lets the user select **multiple** options. Each check box is independent, so any combination can be selected.

Both controls share two common properties:

- `Text`: the text displayed next to the control
- `Checked`: a Boolean property that is `true` when the control is selected

Because `Checked` is already a Boolean value, you do not need the `==` operator in a condition:

```csharp
if (choiceRadioButton.Checked)
{
}
else
{
}

if (option1CheckBox.Checked)
{
}
```

Writing `choiceRadioButton.Checked == true` is equivalent but unnecessary.

### The `CheckedChanged` Event

Whenever the `Checked` property of a radio button or check box changes, a `CheckedChanged` event is raised. You can write an event handler to respond to it. Double-click the control in the Designer to generate an empty handler:

```csharp
private void yellowRadioButton_CheckedChanged(object sender, EventArgs e)
{
}
```

**Screenshot:**



![RadioButton and CheckBox](screenshots/radio-checkbox.png)



**What it shows:** The form has a group of sport radio buttons and a group of pizza topping check boxes. Basketball is selected in the radio group, and Pepperoni and Cheese are ticked in the check box group. The selection label at the bottom reads "Favorite sport: Basketball" and "Toppings: Pepperoni Cheese". Note that only one sport can be selected (mutually exclusive), while two toppings are selected together. The label updated instantly because it is refreshed from the `CheckedChanged` event.

---

## 6. The `switch` Statement

The `switch` statement lets the value of a variable or expression determine which path the program takes. It is a **multiple-alternative decision structure**, and it can be used as a cleaner alternative to an `if-else-if` statement that tests the same variable against several different values.

```csharp
switch (testExpression)
{
    case value_1:
        statement;
        break;
    case value_2:
        statement;
        break;
    default:
        statement;
        break;
}
```

How it works:

- `testExpression` is a variable or expression whose value is an `int`, `string`, or `bool`.
- Each `case` is an individual subsection with one or more statements, ending with a `break` statement.
- The `default` section is optional. It runs when `testExpression` does not match any case, which makes it a good place to handle invalid values.

Example:

```csharp
switch (day)
{
    case 1: dayNameLabel.Text = "Monday"; break;
    case 2: dayNameLabel.Text = "Tuesday"; break;
    case 3: dayNameLabel.Text = "Wednesday"; break;
    case 4: dayNameLabel.Text = "Thursday"; break;
    case 5: dayNameLabel.Text = "Friday"; break;
    case 6: dayNameLabel.Text = "Saturday"; break;
    case 7: dayNameLabel.Text = "Sunday"; break;
    default: dayNameLabel.Text = "Invalid day number (use 1-7)."; break;
}
```

**Screenshot 1: matching case**



![switch 3](screenshots/switch-day3.png)



**What it shows:** The input 3 matched `case 3`, so the label shows **Wednesday**.

**Screenshot 2: default case**



![switch default](screenshots/switch-default.png)



**What it shows:** The input 9 matches no case, so the `default` section ran and the label shows **"Invalid day number (use 1-7)."**

---

## 7. Introduction to List Boxes

A **ListBox** control displays a list of items and lets the user select one of them.

| Property        | Description                                                                          |
|-----------------|--------------------------------------------------------------------------------------|
| `Text`          | The text of the currently selected item                                              |
| `Items`         | The collection of items in the ListBox                                               |
| `Items.Count`   | The number of items in the ListBox                                                   |
| `SelectedItem`  | The currently selected item                                                          |
| `SelectedIndex` | The zero-based index of the selected item (`-1` if nothing is selected)              |

```csharp
selectedFruit = fruitListBox.SelectedItem.ToString();
int count = fruitListBox.Items.Count;
```

### Adding Items

The `Items.Add` method adds an item to the end of the list.

```csharp
daysListBox.Items.Add("Monday");
daysListBox.Items.Add("Tuesday");
daysListBox.Items.Add("Wednesday");
```

### Reading the Selected Item Safely

Items are indexed starting at 0, so the first item has index 0 and the nth item has index n - 1. If no item is selected, `SelectedIndex` is `-1`, and reading `SelectedItem` would cause an exception. Always check first:

```csharp
if (fruitListBox.SelectedIndex != -1)
{
    selectedFruit = fruitListBox.SelectedItem.ToString();
}
else
{
    MessageBox.Show("Please select an item.");
}
```

### `Text` versus `SelectedItem`

| Feature       | Text                                  | SelectedItem                          |
|---------------|---------------------------------------|---------------------------------------|
| Type          | `string`                              | `object`                              |
| Use case      | Quick access to the selected text     | Full access to the selected item      |
| Flexibility   | Less flexible                         | More flexible                         |
| Null-safe?    | May return `""` if nothing selected   | May be `null` if nothing selected     |
| Best for      | Simple, text-only lists               | Complex or data-bound lists           |

`SelectedItem` can hold a real object, such as a Student or Book, while `Text` only gives the name shown in the ListBox.

### Removing Items

```csharp
daysListBox.Items.Remove("Tuesday");   // removes a specific item
daysListBox.Items.RemoveAt(2);         // removes the item at index 2
daysListBox.Items.Clear();             // removes every item
```

`RemoveAt` requires a valid index. If the index is less than 0, or greater than or equal to the number of items, it throws an exception. A safe way to remove whatever the user selected is:

```csharp
if (listBox1.SelectedIndex != -1)
{
    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
}
else
{
    MessageBox.Show("Please select an item to remove.");
}
```

**Screenshot 1: after adding items**



![ListBox added](screenshots/listbox-added.png)



**What it shows:** Five days were added with `Items.Add`. The info area reports 5 items, a `SelectedIndex` of -1, and "(no item selected)", showing the safe state where nothing is selected yet.

**Screenshot 2: after removing an item**



![ListBox removed](screenshots/listbox-removed.png)



**What it shows:** `Items.Remove("Tuesday")` removed that day. Tuesday is gone from the list, the item count dropped to 4, and the remaining items moved up to fill the gap.

**Screenshot 3: with an item selected**



![ListBox selected](screenshots/listbox-selected.png)



**What it shows:** Wednesday is highlighted. `SelectedIndex` is 2 because indexing starts at 0 (Monday = 0, Tuesday = 1, Wednesday = 2), and `SelectedItem` reads "Wednesday".

---

## Summary

- A `bool` flag stores the result of a decision so it can be used later.
- `TryParse` prevents crashes from bad input, but only validation checks that a value makes sense.
- RadioButtons allow one choice, CheckBoxes allow many, and `CheckedChanged` lets the program react immediately.
- `switch` is a clean way to choose among many exact values, with `default` handling everything else.
- ListBox items start at index 0, `SelectedIndex` is `-1` when nothing is selected, and that value should always be checked before using `SelectedItem` or `RemoveAt`.

## Deliverables

- [ ] `bool` flag program (Grand Master)
- [ ] Input validation with `TryParse`
- [ ] RadioButton and CheckBox program
- [ ] `switch` program
- [ ] ListBox program (Add, Remove, Clear)
- [ ] Screenshots of each program path, as described above