# C# File Handling

File handling is an important part of C# programming. It allows a program to read, create, change, and delete files on a computer.

## This assignment covers two main topics:

1. Other File Reading Methods
2. Deleting Files and Items Inside Files

The examples in this assignment will be created using a Windows Forms Application in Visual Studio 2022.

---

## 1. Other File Reading Methods in C#

C# has different methods for reading text files. Some common methods are `Read()`, `ReadLine()`, `ReadToEnd()`, and `ReadAllText()`.

Two other methods are `ReadAllLines()` and `ReadLines()`.

### 1.1 ReadAllLines()

`ReadAllLines()` reads all the lines in a text file and stores them in an array of strings.

Each line is stored as a separate item in the array.

This method is useful when we need to read and work with all the lines in a file.

### 1.2 ReadLines()

`ReadLines()` reads the lines of a text file as a sequence.

Unlike `ReadAllLines()`, it does not load all the lines into memory at once.

This method is useful when working with large text files because the program can process the lines one by one.

### Difference Between ReadAllLines() and ReadLines()

`ReadAllLines()` reads all lines and stores them in an array.

`ReadLines()` provides the lines as a sequence, so they can be processed one by one.

Both methods help us read and work with text files.

---

## 2. Deleting Files and Items Inside Files

### 2.1 Deleting Files

Deleting a file means removing the whole file from the computer.

In C#, we use the `File.Delete()` method to delete a file.

Before deleting a file, we can use `File.Exists()` to check if the file exists.

This helps us check whether the file is available before trying to delete it.

When we delete a file, the whole file is removed, not just its contents.

### 2.2 Deleting Items Inside Files

Deleting items inside a file means removing specific information while keeping the file.

For example, a text file may contain a list of student names. If we want to remove one student's name, we can read the file, find that name, remove it, and save the remaining names.

C# does not have a general `File.DeleteItem()` method to remove a specific line from a text file.

Instead, we can use `File.ReadAllLines()` to read the lines and `File.WriteAllLines()` to save the updated information.

This method is useful for managing student names, employee records, and other text files.

### Difference Between Deleting Files and Deleting Items

Deleting a file removes the entire file from the computer.

Deleting an item removes only selected information from the file while keeping the file and its other contents.

---

## Conclusion

C# provides different methods for reading and managing text files.

`ReadAllLines()` and `ReadLines()` help us read lines from a text file.

`File.Delete()` is used to delete an entire file.

To delete a specific item inside a file, we can read the file, remove the item, and save the updated information.
