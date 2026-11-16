# Week 5 – Practical File Handling in C#

This README explains how to create files, write information into files, and read file contents using C# Windows Forms.

## 1. Creating a File (Button 1)

### Code
```csharp
private void button1_Click(object sender, EventArgs e)
{
    // Creating files
    StreamWriter Outputfile;
    Outputfile = File.CreateText("data.txt");
}
```

### Explanation

- `button1_Click`: Executes when the user clicks Button 1.
- `StreamWriter Outputfile;`: Declares a variable used to write data into a file.
- `File.CreateText("data.txt")`: Creates a text file named `data.txt`.
- `Outputfile =`: Stores the StreamWriter returned by `File.CreateText()`.

**Important:** If the file already exists, `File.CreateText()` overwrites its previous content.

---

## 2. Writing Data to a File (Button 2)

### Code
```csharp
private void button2_Click(object sender, EventArgs e)
{
    StreamWriter Outputfile;
    Outputfile = File.CreateText("data.txt");

    Outputfile.WriteLine("full name is: abdibaari mohamed ali");
    Outputfile.WriteLine("age is: 22");
    Outputfile.WriteLine("gender is: male");
    Outputfile.WriteLine("university is: jamhuriya");
    Outputfile.WriteLine("semester is: 5");
    Outputfile.WriteLine("class is: CA242");

    MessageBox.Show(Path.GetFullPath("data.txt"));

    Outputfile.Close();
}
```

### Explanation

**1. Declaring StreamWriter**
```csharp
StreamWriter Outputfile;
```
Declares a variable used to write information into a text file.

**2. Creating the File**
```csharp
Outputfile = File.CreateText("data.txt");
```
Creates a file called `data.txt`. If it already exists, its previous content is replaced.

**3. Writing Information**
```csharp
Outputfile.WriteLine("full name is: abdibaari mohamed ali");
```
- `WriteLine()` writes information into the file.
- Each statement writes information on a separate line.
- The same method is used to write the age, gender, university, semester, and class.

**4. Displaying the File Path**
```csharp
MessageBox.Show(Path.GetFullPath("data.txt"));
```
- `Path.GetFullPath()` gets the complete location of the file.
- `MessageBox.Show()` displays that location in a message box.

**5. Closing the File**
```csharp
Outputfile.Close();
```
Closes the file after writing and releases the resources.

---

## 3. Reading Data from a File (Button 3)

### Code
```csharp
private void button3_Click(object sender, EventArgs e)
{
    StreamReader reads;
    DialogResult result;

    result = openFileDialog1.ShowDialog();

    // Checking
    if (result == DialogResult.OK)
    {
        // Open file to read its elements
        reads = File.OpenText(openFileDialog1.FileName);

        string lines;

        while (reads.EndOfStream == false)
        {
            lines = reads.ReadLine();
            listBox1.Items.Add(lines);
        }

        reads.Close();
    }
    else if (result == DialogResult.Cancel)
    {
        MessageBox.Show("file not opened");
    }
}
```

### Explanation

**1. Declaring Variables**
```csharp
StreamReader reads;
DialogResult result;
```
- `StreamReader reads`: Declares a variable used to read information from a file.
- `DialogResult result`: Stores the user's response to the file dialog.

**2. Displaying OpenFileDialog**
```csharp
result = openFileDialog1.ShowDialog();
```
Displays a file selection window that allows the user to browse and select a file.

**3. Checking the Result**
```csharp
if (result == DialogResult.OK)
```
Checks whether the user clicked OK after selecting a file.

**4. Opening the Selected File**
```csharp
reads = File.OpenText(openFileDialog1.FileName);
```
- `File.OpenText()` opens the selected text file for reading.
- `FileName` gets the complete path of the selected file.
- The StreamReader object is stored in `reads`.

**5. Declaring a String Variable**
```csharp
string lines;
```
Declares a string variable that temporarily stores each line read from the file.

**6. Reading the File Using a While Loop**
```csharp
while (reads.EndOfStream == false)
```
- `EndOfStream` checks whether the reader has reached the end of the file.
- `false` means there is still data available to read.
- The loop continues until the entire file has been read.

**7. Reading Each Line**
```csharp
lines = reads.ReadLine();
```
Reads one line from the file and stores it in the `lines` variable.

**8. Displaying Data in ListBox**
```csharp
listBox1.Items.Add(lines);
```
Adds each line from the file to the ListBox control. Each line appears as a separate item.

**9. Closing the File**
```csharp
reads.Close();
```
Closes the file after reading and releases the resources.

**10. Handling Cancel**
```csharp
else if (result == DialogResult.Cancel)
{
    MessageBox.Show("file not opened");
}
```
Checks whether the user clicked Cancel and displays a message.

---

## 4. Alternative File Reading Methods

The following methods were also included in the code as comments.

### ReadLine()
```csharp
string lines = reads.ReadLine();
```
Reads one line from the file.

### ReadToEnd()
```csharp
string lines = reads.ReadToEnd();
```
Reads all remaining content from the file as one string.

### File.ReadAllText()
```csharp
lines = File.ReadAllText("data.txt");
```
Reads the entire content of a file directly without manually creating a StreamReader.

### Main Differences

| Method | Purpose |
|---|---|
| `ReadLine()` | Reads one line at a time. |
| `ReadToEnd()` | Reads all remaining content. |
| `ReadAllText()` | Reads the entire file directly. |

---

## 5. Important Classes, Methods, and Properties

| Concept | Purpose |
|---|---|
| `StreamWriter` | Writes information into files. |
| `StreamReader` | Reads information from files. |
| `File.CreateText()` | Creates a text file or overwrites an existing one. |
| `File.OpenText()` | Opens a text file for reading. |
| `WriteLine()` | Writes data and moves to a new line. |
| `ReadLine()` | Reads one line from a file. |
| `ReadToEnd()` | Reads all remaining file content. |
| `ReadAllText()` | Reads the entire file directly. |
| `EndOfStream` | Checks whether the end of the file has been reached. |
| `OpenFileDialog` | Allows users to select an existing file. |
| `ShowDialog()` | Displays the file selection window. |
| `FileName` | Gets the selected file's full path. |
| `DialogResult.OK` | Indicates that the user confirmed the operation. |
| `DialogResult.Cancel` | Indicates that the user cancelled the operation. |
| `Items.Add()` | Adds an item to a ListBox. |
| `Path.GetFullPath()` | Gets the complete file path. |
| `Close()` | Closes the file. |

---

## 6. Key Concepts to Remember

- **File Handling:** Creating, writing, and reading files.
- **StreamWriter:** Used for writing data into files.
- **StreamReader:** Used for reading data from files.
- **File Creation:** Creating a new file to store information.
- **File Overwriting:** Replacing the existing content of a file.
- **File Reading:** Retrieving stored information from a file.
- **While Loop:** Repeats reading until the end of the file.
- **OpenFileDialog:** Allows users to browse and select files.
- **ListBox:** Displays multiple items in a list.
- **File Path:** The location where a file is stored.

---

## 7. Important Exam Notes

1. `StreamWriter` is used for writing, while `StreamReader` is used for reading.
2. `File.CreateText()` creates a file and overwrites it if it already exists.
3. `File.OpenText()` opens an existing text file for reading.
4. `WriteLine()` writes data and moves to the next line.
5. `ReadLine()` reads one line at a time.
6. `EndOfStream` checks whether the end of the file has been reached.
7. `OpenFileDialog` allows users to select existing files.
8. `FileName` returns the selected file's full path.
9. `DialogResult.OK` means the user confirmed the operation.
10. Always close files after finishing reading or writing.

## 8. Complete Program Execution Flow

The program performs three main operations:

| Button | Operation | Explanation |
|---|---|---|
| Button 1 | Create File | Creates `data.txt`. |
| Button 2 | Write Data | Creates the file and writes student information into it. |
| Button 3 | Read Data | Allows the user to select a file, reads its contents, and displays them in a ListBox. |

### Overall Process

**Button 1:** Create File

`StreamWriter → File.CreateText()`

**Button 2:** Write Data

`StreamWriter → File.CreateText() → WriteLine() → Close()`

**Button 3:** Read Data

`OpenFileDialog → FileName → File.OpenText() → EndOfStream → ReadLine() → ListBox → Close()`

**Important Reminder:** Button 2 uses `File.CreateText()` again, meaning it overwrites existing content instead of appending new information.