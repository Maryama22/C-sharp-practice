# Week 6 Lab: Files, Random Numbers, and the Load Event


**Chapter 4:** Loops, Files, and Random Numbers (Part 2)
**Topics:** Using files for data storage, `StreamWriter` and `StreamReader`, OpenFileDialog and SaveFileDialog, random numbers, the form Load event

## Introduction

Variables live in memory, so everything they hold disappears when the program closes. A program that must remember a list of courses, a set of names, or a user's results needs **permanent storage**. The simplest form of permanent storage is a **file** on disk. In Week 6 you learn to write data to a text file, read it back (using the loops from Week 5), let the user pick a file with the standard Windows dialog boxes, generate random numbers, and run code automatically when a form starts.

## Learning Objectives

By the end of this lab you should be able to:

- Describe the three steps of file processing: open, process, close
- Write text to a file with `StreamWriter`, and read it with `StreamReader`
- Choose between `CreateText` and `AppendText`
- Read a whole file with a loop using `EndOfStream`
- Use `OpenFileDialog` and `SaveFileDialog` and detect which button the user clicked
- Generate random integers within a range using the `Random` class
- Use the form's `Load` event for startup code

**Note:** File classes live in the `System.IO` namespace, so add this line at the top of your form's code file:

```csharp
using System.IO;
```

---

## 1. Using Files for Data Storage

When a program needs to save data for later use, it writes the data to a file. Every file operation follows the same **three steps**:

1. **Open the file:** create a connection between the file and the program
2. **Process the file:** write data to the file or read data from it
3. **Close the file:** disconnect the file from the program

There are two general types of files:

- A **text file** contains data encoded as text using a scheme such as Unicode. You can open it in Notepad.
- A **binary file** contains data that has not been converted to text. You cannot view it with a text editor.

This chapter works only with **text files**.

A **file object** is an object associated with a specific file that gives the program a way to work with it. .NET provides two classes for this:

- **`StreamWriter`**: writes data to a text file
- **`StreamReader`**: reads data from a text file

### Writing data to a file

To write, start by declaring a `StreamWriter`, open the file with one of the `File` methods (`File.CreateText` or `File.AppendText`), write items with `Write` or `WriteLine`, and finally close the connection.

```csharp
StreamWriter outputFile;
outputFile = File.CreateText("courses.txt");
outputFile.WriteLine("Introduction to Computer Science");
outputFile.WriteLine("English Composition");
outputFile.WriteLine("Calculus I");
outputFile.Close();
```

- **`WriteLine`** writes an item and then adds a **newline character**, so the next item starts on a new line.
- **`Write`** writes an item **without** a newline character, so items run together.

Writing "One", "Two", and "Three" shows the difference:

| Method | Content of the file |
|--------|---------------------|
| `WriteLine` three times | `One` / `Two` / `Three` on three separate lines |
| `Write` three times | `OneTwoThree` on a single line |

It is important to call `Close()`. Data may be held in a buffer, and closing the file makes sure everything is actually written to disk and releases the file for other programs.

### `CreateText` versus `AppendText`

`File.CreateText`:

- Creates a text file with the name you pass in
- **If the file already exists, its contents are erased**
- Creates a `StreamWriter` object in memory, associated with the file, and returns a reference to it

When you do **not** want to erase an existing file, use `File.AppendText`. It adds new data to the end of the file, and creates the file if it does not exist.

```csharp
StreamWriter outputFile;
outputFile = File.AppendText("Names.txt");
outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");
outputFile.Close();
```

### Specifying the location of a file

If you pass only a file name, the file is created in the program's current folder (for a Visual Studio project, usually the `bin\Debug` folder). To use a different location, include the full path. Prefix the string with `@` so the backslashes are not treated as escape characters:

```csharp
StreamWriter outputFile = File.AppendText(@"C:\Data\Names.txt");
```

Without the `@`, every backslash must be doubled:

```csharp
outputFile = File.CreateText("D:\\C#\\Projects\\listcourse1.txt");
```

### Lab 1: Write a Course List

**What the program does:** A button writes three course names to `courses.txt`.

```csharp
private void writeButton_Click(object sender, EventArgs e)
{
    StreamWriter outputFile;
    outputFile = File.CreateText("courses.txt");
    outputFile.WriteLine("Introduction to Computer Science");
    outputFile.WriteLine("English Composition");
    outputFile.WriteLine("Calculus I");
    outputFile.Close();

    MessageBox.Show("The file was written.");
}
```

**Screenshot 1: confirmation message**



![File written](screenshots/write-confirmation.png)



**What the screenshot shows:** The form after the button was clicked, with the message "The file was written."

**Screenshot 2: the file in Notepad**



![courses.txt in Notepad](screenshots/courses-notepad.png)



**What the screenshot shows:** `courses.txt` opened in Notepad from the `bin\Debug` folder. It contains three lines: Introduction to Computer Science, English Composition, and Calculus I. This proves `WriteLine` placed each item on its own line.

### Lab 2: Append Names

**What the program does:** A button appends three names to `Names.txt` without erasing earlier content.

```csharp
StreamWriter outputFile = File.AppendText("Names.txt");
outputFile.WriteLine("Lynn");
outputFile.WriteLine("Jamal");
outputFile.WriteLine("Alex");
outputFile.Close();
```

**Screenshot:**



![Names.txt after two runs](screenshots/names-appended.png)



**What the screenshot shows:** `Names.txt` in Notepad after clicking the button **twice**. It contains six lines: Lynn, Jamal, Alex, Lynn, Jamal, Alex. The second click added to the file instead of replacing it. If `CreateText` had been used, only three names would remain.

---

## 2. Reading Data from a File

Reading mirrors writing. Declare a `StreamReader`, open the file with `File.OpenText`, read the data, and close the file.

```csharp
StreamReader inputFile;
inputFile = File.OpenText("students.txt");
```

There are several ways to read:

| Method | What it does |
|--------|--------------|
| `StreamReader.ReadLine()` | Reads one line and returns it as a `string` |
| `StreamReader.Read()` | Reads the next single character and returns it as an `int` (cast it with `(char)`) |
| `StreamReader.ReadToEnd()` | Reads everything from the current position to the end of the file as one `string` |
| `File.ReadAllText(path)` | Opens the file, reads all of it, and closes it in a single call |

Examples:

```csharp
// One line
StreamReader read = File.OpenText("lstcourse.txt");
string content = read.ReadLine();
read.Close();

// One character
read = File.OpenText("lstcourse.txt");
char ch = (char)read.Read();
listBox1.Items.Add(ch);
read.Close();

// The whole file at once
read = File.OpenText("lstcourse.txt");
string all = read.ReadToEnd();
listBox1.Items.Add(all);
read.Close();

// The shortest way
string text = File.ReadAllText("lstcourse.txt");
listBox1.Items.Add(text);
```

### Reading a file with a loop

A file usually has many lines, and you often do not know how many. A `StreamReader` has a Boolean property named **`EndOfStream`** that is `true` once the end of the file has been reached. Combine it with a `while` loop from Week 5 to read every line:

```csharp
while (inputFile.EndOfStream == false)
{
    // read one line
}
```

or the equivalent shorter form:

```csharp
while (!inputFile.EndOfStream)
{
    // read one line
}
```

Reading from a file can fail: the file may not exist, or the path may be wrong. Always wrap file code in `try-catch`:

```csharp
StreamReader reader;
try
{
    reader = File.OpenText("courses.txt");

    while (reader.EndOfStream == false)
    {
        string line;
        line = reader.ReadLine();
        listBox1.Items.Add(line);
    }

    reader.Close();
}
catch (Exception ex)
{
    MessageBox.Show(ex.Message);
}
```

### Lab 3: Read a File into a ListBox

**What the program does:** A button reads `courses.txt` line by line and shows each line in `listBox1`.

**Screenshot 1: successful read**



![Read file result](screenshots/read-file-listbox.png)



**What the screenshot shows:** The ListBox contains the three course names from Lab 1, one per item. The loop stopped automatically when `EndOfStream` became true.

**Screenshot 2: error handling**



![File not found message](screenshots/read-file-error.png)



**What the screenshot shows:** The file name was changed to one that does not exist. Instead of crashing, the `catch` block displayed the exception message (could not find file). This shows why `try-catch` should surround file code.

---

## 3. The OpenFileDialog and SaveFileDialog Controls

Hard-coding a file name is inflexible. The **OpenFileDialog** and **SaveFileDialog** controls let your application show the standard Windows dialog boxes for opening and saving files, so the user chooses the file.

- Unlike Label, Button, and TextBox, these are **invisible controls**. They do not appear on the form itself. When you add one, it appears in the **component tray** at the bottom of the Designer.
- OpenFileDialog displays the standard Windows **Open** dialog box.
- SaveFileDialog displays the standard Windows **Save As** dialog box.

### Showing the dialog and detecting the choice

Call the control's `ShowDialog` method:

```csharp
openFileDialog1.ShowDialog();
```

`ShowDialog` returns a **`DialogResult`** value that tells you which button the user clicked:

- `DialogResult.OK` if the user clicked **Open** (or **Save**)
- `DialogResult.Cancel` if the user clicked **Cancel**

```csharp
DialogResult result = openFileDialog1.ShowDialog();
if (result == DialogResult.OK)
{
    // the user picked a file
}
else if (result == DialogResult.Cancel)
{
    // the user cancelled
}
```

### The FileName and InitialDirectory properties

When the user selects a file, its full path and name are stored in the control's **`FileName`** property. Pass it to `File.OpenText`:

```csharp
if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
    inputFile = File.OpenText(openFileDialog1.FileName);
}
```

The **`InitialDirectory`** property sets the folder the dialog shows first:

```csharp
openFileDialog1.InitialDirectory = @"C:\Data";
```

### Lab 4: Open a File with OpenFileDialog

```csharp
private void openButton_Click(object sender, EventArgs e)
{
    DialogResult result = openFileDialog1.ShowDialog();

    if (result == DialogResult.OK)
    {
        try
        {
            StreamReader reader = File.OpenText(openFileDialog1.FileName);
            listBox1.Items.Clear();

            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                listBox1.Items.Add(line);
            }

            reader.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    else if (result == DialogResult.Cancel)
    {
        MessageBox.Show("The operation was cancelled.");
    }
}
```

**Screenshot 1: the Open dialog**



![Open dialog](screenshots/open-dialog.png)



**What the screenshot shows:** The standard Windows Open dialog displayed by `ShowDialog`, with the folder list, the File name box, and the Open and Cancel buttons.

**Screenshot 2: file loaded**



![File loaded in ListBox](screenshots/open-dialog-result.png)



**What the screenshot shows:** After selecting `courses.txt` and clicking Open, its lines appear in the ListBox.

**Screenshot 3: Cancel clicked**



![Cancelled message](screenshots/open-dialog-cancel.png)



**What the screenshot shows:** After clicking Cancel in the dialog, the program shows "The operation was cancelled." This is the `DialogResult.Cancel` branch.

### Displaying a Save As dialog

The `SaveFileDialog` works the same way. When the user clicks **Save**, use `FileName` with `File.CreateText`:

```csharp
if (saveFileDialog1.ShowDialog() == DialogResult.OK)
{
    outputFile = File.CreateText(saveFileDialog1.FileName);
}
```

### Lab 5: Save the ListBox Contents

**What the program does:** A button saves every item of the ListBox into a file the user chooses. A `for` loop from Week 5 visits each item.

```csharp
private void saveButton_Click(object sender, EventArgs e)
{
    DialogResult result = saveFileDialog1.ShowDialog();

    if (result == DialogResult.OK)
    {
        StreamWriter writer = File.CreateText(saveFileDialog1.FileName);

        for (int i = 0; i < listBox1.Items.Count; i++)
        {
            writer.WriteLine(listBox1.Items[i].ToString());
        }

        writer.Close();
        MessageBox.Show("The file was saved.");
    }
    else if (result == DialogResult.Cancel)
    {
        MessageBox.Show("The operation was cancelled.");
    }
}
```

**Screenshot 1: the Save As dialog**



![Save As dialog](screenshots/save-dialog.png)



**What the screenshot shows:** The standard Windows Save As dialog with the File name box, the Save as type box, and the Save and Cancel buttons.

**Screenshot 2: the saved file**



![Saved file in Notepad](screenshots/save-dialog-result.png)



**What the screenshot shows:** The saved file opened in Notepad, containing the same lines that were in the ListBox.

---

## 4. Random Numbers

Games, simulations, and quizzes need unpredictable values. .NET provides the **`Random`** class. Create one `Random` object, then call its methods.

```csharp
Random rand = new Random();
```

Two commonly used methods:

| Method | Result |
|--------|--------|
| `Next()` | A random integer from 0 up to 2,147,483,647 |
| `NextDouble()` | A random floating-point number from 0.0 up to (but not including) 1.0 |

```csharp
int number1 = rand.Next();
double number2 = rand.NextDouble();
```

### Limiting the range

`Next` can take an argument, **`Next(max + 1)`**. The upper limit you pass is **exclusive**, so it is never produced. To get a number from 0 to 99, pass 100:

```csharp
int number = rand.Next(100);    // 0 to 99
```

To get a number from 1 to 6 (a die), generate 0 to 5 and add 1:

```csharp
int die = rand.Next(6) + 1;     // 1 to 6
```

Create the `Random` object **once**, for example as a field of the form, instead of inside a button handler. Creating several `Random` objects within a very short time can produce the same sequence of numbers.

### Lab 6: Random Number Generator

**What the program does:** A button displays a random number from 0 to 99 and a random double, and a second button simulates a die roll.

```csharp
Random rand = new Random();      // a field of the form

private void generateButton_Click(object sender, EventArgs e)
{
    int number = rand.Next(100);
    double fraction = rand.NextDouble();

    numberLabel.Text = number.ToString();
    fractionLabel.Text = fraction.ToString("n4");
}
```

**Screenshot 1 and 2: two different clicks**



![Random result 1](screenshots/random-1.png)




![Random result 2](screenshots/random-2.png)



**What the screenshots show:** Two clicks of the same button produced **different** values. The integer is always between 0 and 99, and the double is always between 0 and 1. Your own numbers will differ from the example, which is exactly the point of random generation.

---

## 5. The Load Event

When an application runs, its form is loaded into memory and an event named **`Load`** takes place. Any code you place in the Load event handler runs **when the form is launched**, before the user starts interacting with it.

To create a Load event handler, **double-click the form** in the Designer. An empty handler looks like this:

```csharp
private void Form1_Load(object sender, EventArgs e)
{

}
```

A simple example:

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    MessageBox.Show("Prepare to see the form!");
}
```

Typical uses of the Load event are filling a ListBox with starting items, setting initial values, and reading saved data from a file so the user sees it immediately.

### Lab 7: Load a Saved List at Startup

**What the program does:** When the form starts, it reads `courses.txt` into the ListBox automatically. If the file does not exist yet, it shows a friendly message instead of crashing.

```csharp
private void Form1_Load(object sender, EventArgs e)
{
    try
    {
        StreamReader reader = File.OpenText("courses.txt");

        while (!reader.EndOfStream)
        {
            courseListBox.Items.Add(reader.ReadLine());
        }

        reader.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}
```

**Screenshot 1: the startup message**



![Load event message](screenshots/load-message.png)



**What the screenshot shows:** With the simple example above, the message "Prepare to see the form!" appears **before** the form becomes visible, which proves the Load event runs at launch.

**Screenshot 2: the list filled at startup**



![Load event result](screenshots/load-listbox.png)



**What the screenshot shows:** The form as soon as it opens, with the course names already in the ListBox and no button clicked. The Load event read the file automatically.

---

## Summary

- File processing always has three steps: open, process, close.
- `StreamWriter` writes and `StreamReader` reads. Remember `using System.IO;`.
- `CreateText` erases an existing file, while `AppendText` adds to the end of it.
- `WriteLine` ends each item with a newline, and `Write` does not.
- A `while (!reader.EndOfStream)` loop reads a file of unknown length, and `try-catch` handles missing files.
- `OpenFileDialog` and `SaveFileDialog` return a `DialogResult`, and the chosen file is in `FileName`.
- `Random.Next(100)` gives 0 to 99, and `NextDouble()` gives 0.0 up to 1.0.
- Code in the form's `Load` event runs when the form starts.

## Deliverables

- [ ] Write a course list (`CreateText`)
- [ ] Append names (`AppendText`)
- [ ] Read a file into a ListBox with a loop
- [ ] Open a file with OpenFileDialog
- [ ] Save a list with SaveFileDialog
- [ ] Random number generator
- [ ] Load event program
- [ ] Screenshots of each program running, including Notepad views of the files