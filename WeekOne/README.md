# Chapter 1 – Introduction to Visual C#

**Based on:** *Starting Out with Visual C#, 6th Edition* (Tony Gaddis), Chapter 1 (covers book sections 1.1–1.8 and 2.1–2.10)

This README explains every concept in the chapter in detail, with examples, tables, and tips. Use it as a study guide and quick reference.

---

## Table of Contents

**Part A – Foundations**
1. [Objects](#1-objects)
2. [Controls](#2-controls)
3. [Classes](#3-classes)
4. [The .NET Framework](#4-the-net-framework)
5. [The Program Development Process (overview)](#5-the-program-development-process-overview)

**Part B – Visual Studio**
6. [Visual Studio IDE](#6-visual-studio-ide)
7. [Menu Bar and Standard Toolbar](#7-menu-bar-and-standard-toolbar)
8. [The Toolbox](#8-the-toolbox)
9. [Tooltips](#9-tooltips)
10. [Docked and Floating Windows](#10-docked-and-floating-windows)
11. [Projects and Solutions](#11-projects-and-solutions)
12. [Naming a Project and Reopening the Designer](#12-naming-a-project-and-reopening-the-designer)

**Part C – Forms and Controls**
13. [Forms and the Bounding Box](#13-forms-and-the-bounding-box)
14. [The Properties Window](#14-the-properties-window)
15. [Adding, Moving, Resizing, and Deleting Controls](#15-adding-moving-resizing-and-deleting-controls)
16. [Rules for Naming Controls](#16-rules-for-naming-controls)

**Part D – Writing C# Code**
17. [Structure of C# Code](#17-structure-of-c-code)
18. [Source Code Files](#18-source-code-files)
19. [Event-Driven Programming](#19-event-driven-programming)
20. [Message Boxes](#20-message-boxes)
21. [Hello World Application](#21-hello-world-application)
22. [Label Controls](#22-label-controls)
23. [Displaying Output in a Label](#23-displaying-output-in-a-label)
24. [IntelliSense](#24-intellisense)
25. [PictureBox Controls](#25-picturebox-controls)
26. [Sequential Execution](#26-sequential-execution)
27. [Comments, Blank Lines, and Indentation](#27-comments-blank-lines-and-indentation)
28. [Closing a Form or Application](#28-closing-a-form-or-application)
29. [Syntax Errors](#29-syntax-errors)

**Extras**
30. [Corrections to Watch For in the Slides](#30-corrections-to-watch-for-in-the-slides)
31. [Quick Reference Tables](#31-quick-reference-tables)
32. [Review Questions](#32-review-questions)

---

# Part A – Foundations

## 1. Objects

**Definition:** An object is a program component that contains **data** and performs **operations**. Programs use objects to carry out specific tasks.

Most modern languages (C#, Java, Python, and others) use **object-oriented programming (OOP)**, where a program is built out of objects that work together.

Every object has two things:

| Part | Meaning | Real-life analogy (a car) |
|------|---------|---------------------------|
| **Properties** (also called *fields*) | The data stored in the object | Color, speed, model |
| **Methods** | The operations the object can perform | Start, accelerate, brake |

**Example from the slides – a Wage Calculator form.** The window is a **form object** that contains:

- 2 **Label** objects: "Number of hours worked" and "Hourly pay rate"
- 2 **TextBox** objects: where the user types values
- 2 **Button** objects: "Calculate gross pay" and "Exit"

Each of these is its own object with its own properties (text, size, position, color) and methods.

**Why it matters:** Objects let you build large programs from small, reusable, understandable pieces.

---

## 2. Controls

**Definition:** Objects that are **visible** in a program's graphical user interface (GUI) are called **controls**.

Commonly used controls:

- **Label** – displays text
- **Button** – performs an action when clicked
- **TextBox** – lets the user type input

Controls enhance the functionality of your programs by letting users interact with them.

**Invisible objects:** Not every object in a GUI can be seen. Examples include:

- **Timer** – triggers actions at set time intervals
- **OpenFileDialog** – lets the user browse for a file (the dialog appears only when needed)

> **Remember:** All controls are objects, but not all objects are controls.

---

## 3. Classes

**Definition:** A **class** is code that describes a particular type of object. It is the blueprint; an object is what you build from it.

| Concept | Analogy |
|---------|---------|
| Class | Blueprint of a house |
| Object | An actual house built from that blueprint |

You can create many objects (many buttons, many labels) from a single class (`Button`, `Label`). Each object has its own property values, even though they share the same design.

---

## 4. The .NET Framework

**Definition:** .NET is a large collection of **classes and other code** you can use to create programs for the Windows operating system.

Key points:

- C# is one of the languages supported by .NET (others include Visual Basic and F#).
- Controls such as Button, Label, and TextBox are defined by **specialized classes provided by .NET**.
- You can also **write your own classes** to perform special tasks.

**Why it matters:** You do not have to build a button from scratch. .NET already provides it, so you can focus on your program's logic.

---

## 5. The Program Development Process (overview)

The chapter's topic list includes section 1.2, the program development process. The slides do not cover it in detail, so here is a brief overview of the standard steps:

1. **Understand the problem** – what should the program do?
2. **Design the GUI** – decide which controls are needed and how they are arranged.
3. **Plan the logic** – decide what happens when the user interacts with each control.
4. **Write the code** – implement the plan in C#.
5. **Test and debug** – run the program, find and fix errors.

---

# Part B – Visual Studio

## 6. Visual Studio IDE

**Definition:** Visual Studio is a professional **Integrated Development Environment (IDE)**. An IDE combines the tools a developer needs (code editor, visual designer, compiler, debugger) in a single application.

The three main windows you will use:

| Window | Purpose |
|--------|---------|
| **Designer window** | Where you visually design the form by placing controls |
| **Solution Explorer window** | Lists the project and all of its files (nested expandable list) |
| **Properties window** | Shows and edits the properties of the selected object (for example size, start position, tag, text) |

---

## 7. Menu Bar and Standard Toolbar

### Menu bar
Provides menus such as **File, Edit, View, Project, Build, Debug, Team, Format, Tools, Test, Analyze, Window, Help**.

### Standard toolbar
Contains buttons for **frequently used commands**:

| Button | Function |
|--------|----------|
| Left arrow / Right arrow | Navigate backward / forward |
| New Project icon | Create a new project |
| Open folder icon | Open a file |
| Floppy disk | Save |
| Two floppy disks | Save All |
| Undo / Redo arrows | Undo or redo the last action |
| Solution Configuration (Debug) | Choose the build configuration |
| Solution Platform (Any CPU) | Choose the target platform |
| **Start** (play arrow) | Start debugging (run the program) |
| Folder with magnifying glass | Find |

---

## 8. The Toolbox

**Definition:** The Toolbox is a window for **selecting controls** to use in an application.

- Typically appears on the **left side** of Visual Studio.
- Often is in **Auto Hide** mode (shows only as a vertical tab on the edge).
- Divided into sections such as **All Windows Forms** and **Common Controls**.

Common Controls include: Pointer, Button, CheckBox, CheckedListBox, ComboBox, DateTimePicker, Label, LinkLabel, ListBox, ListView, MaskedTextBox, MonthCalendar.

**Auto Hide:** Lets a window display only as a tab on the edge of the environment. Click the **pushpin icon** on the window's title bar to turn Auto Hide on or off. This frees screen space for the Designer.

---

## 9. Tooltips

**Definition:** A tooltip is a small box that pops up when you **hover the mouse pointer** over an item on the toolbar or toolbox.

**Example:** Hovering over the Save All icon shows *"Save All (Ctrl+Shift+S)"*. Tooltips help you learn what each button does and its keyboard shortcut.

---

## 10. Docked and Floating Windows

| State | Description |
|-------|-------------|
| **Docked** | The window is attached to one of the edges of the Visual Studio environment |
| **Floating** | The window is detached; you can click and drag it anywhere on the screen |

Rules and tips:

- A window **cannot float if it is in Auto Hide mode**.
- **Right-click** the window's title bar and select **Float** or **Dock** to switch between the two.

---

## 11. Projects and Solutions

| Term | Meaning |
|------|---------|
| **Project** | Each Visual Studio application you create is a project. It contains several files, typically `Form1.cs`, `Program.cs`, and others. |
| **Solution** | A container that can hold **one or more** Visual Studio projects. |
| **Files of a project** | The actual code and resources that make the application run. |

**Hierarchy:**

```
Solution (entire container, can have many projects)
 └── Project (one application)
      ├── Form1.cs      (code for the form)
      ├── Program.cs    (start-up code)
      └── ...other files and resources
```

The slides note that each project you create is saved in its own solution.

---

## 12. Naming a Project and Reopening the Designer

### Specifying the project name
You choose the name when creating the project (in the *Configure your new project* window). It has three fields:

- **Project name** – for example, `MyFirstProject`
- **Location** – where the solution folder will be created
- **Solution name** – by default, the same as the project name

### Displaying the Designer
Sometimes when you open an existing project, the form does not appear automatically in the Designer. To show it:

1. **Right-click** `Form1.cs` in the Solution Explorer.
2. Click **View Designer** in the pop-up menu.

(The same menu also has **View Code**, which opens the source code.)

---

# Part C – Forms and Controls

## 13. Forms and the Bounding Box

- When you start a new **Windows Forms App**, an empty form named **Form1** is created automatically.
- Initially the form is **300 pixels wide by 300 pixels high**.
- In the Designer, the form is enclosed by thin dotted lines called the **bounding box**.
- The bounding box has small **sizing handles** (at the corners and midpoints). Drag them to resize the form.

---

## 14. The Properties Window

**Key idea:** The appearance and other characteristics of a GUI object are determined by its **properties**. Properties are settings that control how the object **looks** and **behaves**.

- The Properties window lists all properties of the selected object.
- Each property has two columns: **Left** = property name, **Right** = property value.

| Property | Example Value |
|----------|---------------|
| ShowIcon | True |
| Size | 300, 300 |
| Text | Form1 |

### Changing a property's value

1. Select the object (for example, click the form once).
2. If the Properties window is not visible, go to **View → Properties Window**.
3. Find the property name in the list and change its value.

**Example:** The **Text** property controls the text in the form's title bar. Change it from `Form1` to `My First Program`.

### Alphabetical vs. Categorized
- **Categorized** (default) groups properties by category and is usually easier for finding things.
- **Alphabetical** lists them A–Z.

---

## 15. Adding, Moving, Resizing, and Deleting Controls

### Adding a control
In the Toolbox, select the control (for example, Button), then either:

- **Double-click** the control, or
- **Click and drag** the control onto the form.

### On the form, you can:
- **Resize** the control using its bounding box and sizing handles
- **Move** the control by dragging it
- **Change its properties** in the Properties window

### Deleting a control
Select the control and press the **Delete** key on the keyboard.

---

## 16. Rules for Naming Controls

Controls are identified by their **names in code**. Control names are also called **identifiers**.

**Rules:**

1. The first character must be a **letter** (upper or lower case) or an **underscore** `_`.
2. All other characters can be **letters, digits, or underscores**.
3. The name **cannot contain spaces**.

| Name | Valid? | Reason |
|------|--------|--------|
| `showDayButton` | Yes | Follows the rules |
| `DisplayTotal` | Yes | Follows the rules |
| `_ScoreLabel` | Yes | Starts with underscore |
| `2ndLabel` | No | Starts with a digit |
| `show day` | No | Contains a space |
| `total-price` | No | Hyphen is not allowed |

### camelCase convention
Since spaces are not allowed, most C# programmers use **camelCase**:

- Begin with **lowercase** letters.
- The first letter of each following word is **uppercase**.

Examples: `showDayButton`, `firstNameTextBox`, `answerLabel`

> **Good practice:** End the name with the control type (`Button`, `Label`, `TextBox`, `PictureBox`) so the name explains itself.

---

# Part D – Writing C# Code

## 17. Structure of C# Code

C# code is organized in three main ways:

| Element | Definition |
|---------|------------|
| **Namespace** | A container that holds classes |
| **Class** | A container that holds methods |
| **Method** | A group of one or more programming statements that perform some operation |

They nest like this:

```
Namespace
 └── Class
      └── Method
           └── Statements
```

### Sample of `Form1.cs`

```csharp
namespace hello_world                     // 1. Project's namespace
{
    public partial class Form1 : Form     // 2. Class declaration
    {
        public Form1()                    // 3. A method (the constructor)
        {
            InitializeComponent();
        }
    }
}
```

**Line-by-line:**

- `namespace hello_world` – the user-defined namespace named after the project.
- `public partial class Form1 : Form` – declares class `Form1`, which is based on the `Form` class (the colon means "inherits from").
- `public Form1()` – a special method called the **constructor**; it runs when the form is created.
- `InitializeComponent();` – sets up all the controls you placed in the Designer.
- `{ }` – braces mark the beginning and end of each block.
- `;` – a semicolon ends each statement.

---

## 18. Source Code Files

A file that contains program code is called a **source code file**. Each new project automatically creates two:

| File | Purpose |
|------|---------|
| **Program.cs** | Contains the application's **start-up code**, executed when the application runs |
| **Form1.cs** | Contains the code associated with the **Form1** form |

**To open Form1's code:** right-click `Form1.cs` in Solution Explorer → **View Code**.

---

## 19. Event-Driven Programming

GUI applications are **event-driven**: they respond to events that happen while the program is running. The program waits for the user to do something, then reacts.

| Term | Definition |
|------|------------|
| **Event** | A user's action such as a mouse click, key press, or mouse movement |
| **Event handler** | A method that executes when a specific event takes place |

**Creating an event handler:** In the Designer, **double-click** a control (for example, a Button). Visual Studio links it to its **default event handler** and generates code like:

```csharp
private void myButton_Click(object sender, EventArgs e)
{

}
```

**Anatomy of the handler:**

| Part | Meaning |
|------|---------|
| `private` | Only accessible inside this class |
| `void` | Returns no value |
| `myButton_Click` | Name = control name + underscore + event name |
| `object sender` | The control that raised the event |
| `EventArgs e` | Extra information about the event |

You write your own statements **between the braces**.

---

## 20. Message Boxes

A **message box** (also called a **dialog box**) displays a message in a small window. .NET provides the method `MessageBox.Show`.

```csharp
private void myButton_Click(object sender, EventArgs e)
{
    MessageBox.Show("Thanks for clicking the button!");
}
```

When the user clicks the button, a window pops up with the text.

**Notes:**

- The message is a **string** enclosed in **double quotes**.
- The statement must end with a **semicolon**.

---

## 21. Hello World Application

The classic first program. It has a **Form** and a **Button**, and displays "Hello World" when the button is clicked.

**Steps:**
1. Create the GUI (Form + Button) – section 2.2.
2. Understand the code structure – section 2.3.
3. Write the code for the button – section 2.4.

**Completed code of `Form1.cs`:**

```csharp
namespace hello_world
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
```

**What happens when it runs:**
1. The form appears.
2. The program waits.
3. The user clicks `messageButton`.
4. `messageButton_Click` runs.
5. `MessageBox.Show("Hello World")` displays the message.

---

## 22. Label Controls

A **Label** displays text on a form. It can show **unchanging text** (captions) or **program output** (results).

| Property | Purpose |
|----------|---------|
| **Text** | Gets (reads) or sets (changes) the text shown in the label |
| **Name** | Gets or sets the label's name (identifier used in code) |
| **Font** | Sets the font, font style, and font size |
| **BorderStyle** | Displays a border around the label's text |
| **AutoSize** | Controls how the label resizes to fit its text |
| **TextAlign** | Sets where the text is positioned inside the label |

### TextAlign values (3 × 3 grid)

| TopLeft | TopCenter | TopRight |
|---------|-----------|----------|
| **MiddleLeft** | **MiddleCenter** | **MiddleRight** |
| **BottomLeft** | **BottomCenter** | **BottomRight** |

Select a value by clicking the **down-arrow** button beside the TextAlign property.

---

## 23. Displaying Output in a Label

To show program output in a label, assign a value to its `Text` property inside an event handler:

```csharp
private void showButton_Click(object sender, EventArgs e)
{
    answerLabel.Text = "Hello World";
}
```

**Important points:**

1. The `=` sign is the **assignment operator**.
2. The item **receiving** the value must be on the **left** of `=`.
3. The `Text` property accepts a **string only**.
4. To **clear** a label, assign an empty string:

```csharp
answerLabel.Text = "";
```

> **Read it as:** "Set answerLabel's Text to Hello World." Data flows **right to left**.

---

## 24. IntelliSense

**Definition:** IntelliSense is a smart **code completion** feature. As you type, it suggests keywords, variables, methods, classes, and properties you might want to use.

**Benefits:**

- Saves typing and reduces spelling mistakes.
- Provides language references at your fingertips.
- Lets you find information and insert language elements directly into your code.

**Example:** Typing `tra` inside a handler shows a drop-down list of matching items (for example, `translationLabel`). Press **Tab** or **Enter** to accept the highlighted suggestion.

> **Tip:** When you type a control name followed by a dot (for example, `answerLabel.`), IntelliSense lists all of its properties and methods.

---

## 25. PictureBox Controls

A **PictureBox** displays a graphic image on a form.

| Property | Purpose |
|----------|---------|
| **Image** | Specifies the image to display |
| **SizeMode** | Specifies how the image is displayed (for example, stretched, centered, zoomed) |
| **Visible** | Determines whether the control is visible **at run time** (`true` or `false`) |

### Creating clickable images
**Double-click** the PictureBox in the Designer to create a `Click` event handler, then add your code to it:

```csharp
private void cardPictureBox_Click(object sender, EventArgs e)
{
    MessageBox.Show("You clicked the picture!");
}
```

This lets images behave like buttons.

---

## 26. Sequential Execution

Statements in a method run **in the order they appear**, from top to bottom. The order matters.

### Correct order

```csharp
private void showBackButton_Click(object sender, EventArgs e)
{
    cardBackPictureBox.Visible = true;    // show the back
    cardFacePictureBox.Visible = false;   // hide the face
}
```

Result: the card flips to its back.

### Incorrect logic

```csharp
private void showBackButton_Click(object sender, EventArgs e)
{
    cardBackPictureBox.Visible = false;   // hides the back
    cardFacePictureBox.Visible = false;   // hides the face
}
```

Result: **both pictures are hidden**. The code compiles and runs, but the result is wrong.

> **Logic error:** a mistake in how the statements are arranged or written that makes the program produce incorrect results, even though there is no syntax error.

---

## 27. Comments, Blank Lines, and Indentation

### Comments
Comments are brief notes placed in source code to **explain how parts of the program work**. The compiler **ignores** them.

**Line comment** – one line, starts with `//`:

```csharp
// Make image of the card back visible.
cardBackPictureBox.Visible = true;
```

**Block comment** – multiple lines, between `/*` and `*/`:

```csharp
/*
   This is line one
   This is line two
*/
```

### Blank lines and indentation
Programmers use blank lines and indentation to make code **human-readable**. The compiler does not need them, but people do.

**Hard to read:**

```csharp
namespace Wage_Calculator
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}
private void exitButton_Click(object sender, EventArgs e)
{
// Close the form.
this.Close();
}
}
}
```

**Easy to read:**

```csharp
namespace Wage_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
```

Both are **identical to the computer**, but the second is far easier for people to understand.

---

## 28. Closing a Form or Application

### Close the current form

```csharp
this.Close();
```

`this` refers to the current form (the object whose code is running).

### A common practice: an Exit button

```csharp
private void exitButton_Click(object sender, EventArgs e)
{
    this.Close();
}
```

### Close the entire application

```csharp
Application.Exit();
```

| Statement | Effect |
|-----------|--------|
| `this.Close();` | Closes the current form (Form1) |
| `Application.Exit();` | Closes the whole application |

### Comparison with other languages (from the slide notes)

| Language / Framework | Close the form | Exit the application |
|----------------------|----------------|----------------------|
| **C#** (Windows Forms) | `this.Close();` | `Application.Exit();` |
| **Java** (Swing) | `this.dispose();` | `System.exit(0);` |
| **JavaScript** (browser) | `window.close();` (only works for windows opened by JavaScript) or hide with `style.display = "none"` | – |
| **React** (JSX) | `onClick={() => setShowForm(false)}` | – |

---

## 29. Syntax Errors

**Definition:** A syntax error is a mistake that breaks the rules of the language (for example a misspelled keyword or a missing semicolon).

**How Visual Studio helps:**

- It examines each statement **as you type** and reports errors.
- A syntax error is **underlined with a red jagged line**.
- If you try to run with an error present, Visual Studio shows a window: *"There were build errors. Would you like to continue and run the last successful build?"* with **Yes** and **No** buttons. Choose **No** and fix the error.

**Example:** In `MessageBox.Sho("Hello World");`, the incomplete method name `Sho` is underlined because `Show` was misspelled.

### Types of errors

| Type | When found | Example |
|------|------------|---------|
| **Syntax error** | Before running (compile time) | Missing `;`, misspelled `Show` |
| **Logic error** | After running (wrong result) | Hiding both PictureBoxes |

### Common syntax mistakes

- Missing semicolon `;`
- Missing closing brace `}` or quote `"`
- Wrong capitalization (C# is **case-sensitive**: `Text` is not `text`)
- Misspelled control or method names

---

# Extras

## 30. Corrections to Watch For in the Slides

A few lines in the slides contain typing mistakes. Use the corrected versions in your own code:

| Slide text | Correct C# |
|------------|-----------|
| `Application.Exit;` | `Application.Exit();` (needs parentheses) |
| `cardBackPictureBox.Visible = False;` | `... = false;` (C# uses lowercase `true` / `false`) |
| `lnitializeComponent();` | `InitializeComponent();` (capital **I**, not lowercase L) |
| `Form1.c s`, `Program.c s` | `Form1.cs`, `Program.cs` (the extension is `.cs`) |

---

## 31. Quick Reference Tables

### Common controls and what they do

| Control | Purpose | Key properties |
|---------|---------|----------------|
| **Form** | The window itself | Text, Size, StartPosition |
| **Button** | Runs code when clicked | Text, Name |
| **Label** | Displays text | Text, Font, TextAlign, AutoSize, BorderStyle |
| **TextBox** | Gets input from the user | Text, Name |
| **PictureBox** | Displays an image | Image, SizeMode, Visible |

### Important code statements

| Purpose | Code |
|---------|------|
| Show a message | `MessageBox.Show("text");` |
| Set label text | `answerLabel.Text = "text";` |
| Clear label text | `answerLabel.Text = "";` |
| Hide a picture | `myPictureBox.Visible = false;` |
| Show a picture | `myPictureBox.Visible = true;` |
| Line comment | `// comment` |
| Block comment | `/* comment */` |
| Close the form | `this.Close();` |
| Exit the application | `Application.Exit();` |

### Visual Studio windows at a glance

| Window | Where | Main use |
|--------|-------|----------|
| Designer | Center / left | Design the form |
| Toolbox | Left (auto hide) | Pick controls |
| Solution Explorer | Top right | Browse project files |
| Properties | Bottom right | Edit object properties |

### Key terms glossary

| Term | Meaning |
|------|---------|
| Object | Component with data and operations |
| Property | Data stored in an object |
| Method | Operation an object can perform |
| Control | Visible object in a GUI |
| Class | Code that describes a type of object |
| .NET Framework | Collection of classes for building Windows programs |
| IDE | Integrated Development Environment |
| Project | One application |
| Solution | Container for one or more projects |
| Namespace | Container for classes |
| Event | User action (click, key press) |
| Event handler | Method that runs when an event occurs |
| Identifier | Name of a control or variable |
| Assignment operator | The `=` sign |
| Syntax error | Violation of language rules |
| Logic error | Code runs but gives wrong results |

---

## 32. Review Questions

1. What is an object? Name its two main parts.
2. What is the difference between a class and an object?
3. Give two examples of visible controls and two examples of invisible objects.
4. What is the .NET Framework?
5. Name the three main windows in the Visual Studio environment.
6. What is the difference between a project and a solution?
7. What is the purpose of the Toolbox? What does Auto Hide do?
8. How do you change the title displayed on a form's title bar?
9. List the three rules for naming controls. Which of these are valid: `_total`, `2ndButton`, `show Label`, `exitButton`?
10. What is camelCase?
11. What is the relationship between namespaces, classes, and methods?
12. What is an event? What is an event handler?
13. Write the statement that displays "Welcome" in a message box.
14. Write the statement that sets `resultLabel` to display "Done", then the statement that clears it.
15. What does the `Visible` property of a PictureBox do?
16. Why does statement order matter? Give an example of a logic error.
17. What is the difference between a line comment and a block comment?
18. How do you close a form in code? How do you exit the entire application?
19. How does Visual Studio show a syntax error?

---

**End of Chapter 1 study guide.** Good luck with your studies!