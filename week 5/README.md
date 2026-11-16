# Week 5 – C# Files and File Dialog Controls

## 5.6 Using Files for Data Storage

Files allow programs to store data permanently so that information is not lost when the program closes.

### File Accessing
- C# uses classes such as `StreamReader` and `StreamWriter` to work with files.
- `StreamWriter` is used to write data into a file.
- `StreamReader` is used to read data from a file.
- The `System.IO` namespace provides classes for file handling.

### Writing Data to a File
- `StreamWriter` is used to write text into a file.
- `File.CreateText()` creates a new text file and returns a `StreamWriter`.
- `Write()` writes data without moving to a new line.
- `WriteLine()` writes data and moves to the next line.
- `Close()` closes the file after writing.

### Reading Data from a File
- `StreamReader` is used to read text from a file.
- `File.OpenText()` opens an existing text file and returns a `StreamReader`.
- `ReadLine()` reads one line at a time.
- `Close()` closes the file after reading.



### Reading a File with a Loop
- A loop allows us to read all lines in a file.
- `ReadLine()` reads one line at a time.
- The loop continues until the end of the file.
- `null` means there is no more data to read.

**Example:**
```csharp
StreamReader reader = File.OpenText("data.txt");

string line;

while ((line = reader.ReadLine()) != null)
{
    MessageBox.Show(line);
}

reader.Close();
```

---

## 5.7 The OpenFileDialog and SaveFileDialog Controls

These controls allow users to select files when working with Windows Forms applications.

### OpenFileDialog
- Allows users to browse and select an existing file.
- Used when the program needs to open or read a file.
- `ShowDialog()` displays the file selection window.
- `FileName` gets the selected file's path.

**Example:**
```csharp
OpenFileDialog openFileDialog = new OpenFileDialog();

if (openFileDialog.ShowDialog() == DialogResult.OK)
{
    string filename = openFileDialog.FileName;
}
```

### SaveFileDialog
- Allows users to choose where to save a file.
- Used when the program needs to create or save a file.
- `ShowDialog()` displays the save window.
- `FileName` gets the selected file's path.

**Example:**
```csharp
SaveFileDialog saveFileDialog = new SaveFileDialog();

if (saveFileDialog.ShowDialog() == DialogResult.OK)
{
    string filename = saveFileDialog.FileName;
}
```

### The Filename and InitialDirectory Properties

**1. FileName**
- Gets or sets the name or full path of a selected file.
- Used with both `OpenFileDialog` and `SaveFileDialog`.

**Example:**
```csharp
openFileDialog1.FileName = "data.txt";
```

**2. InitialDirectory**
- Sets the folder that appears first when the dialog opens.
- Helps users start browsing from a specific location.

**Example:**
```csharp
openFileDialog1.InitialDirectory = @"C:\Users\Documents";
```

---

## Key Concepts

| Concept | Definition |
|---|---|
| File Handling | Storing, writing, and reading data using files. |
| StreamWriter | Class used to write text into files. |
| StreamReader | Class used to read text from files. |
| File.CreateText() | Creates a text file for writing. |
| File.OpenText() | Opens a text file for reading. |
| Write() | Writes data without moving to a new line. |
| WriteLine() | Writes data and moves to a new line. |
| ReadLine() | Reads one line from a file. |
| null | Indicates that there is no more data to read. |
| OpenFileDialog | Allows users to select an existing file. |
| SaveFileDialog | Allows users to choose where to save a file. |
| FileName | Gets or sets the selected file's path. |
| InitialDirectory | Sets the starting folder for a file dialog. |

## Important Reminders
- Always close files after reading or writing.
- Use `StreamWriter` for writing and `StreamReader` for reading.
- Use `while (line != null)` to read all lines in a file.
- `OpenFileDialog` is for selecting existing files.
- `SaveFileDialog` is for choosing where to save files.
- `FileName` represents the selected file path.
- `InitialDirectory` determines the starting folder.