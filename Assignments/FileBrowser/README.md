# Async/Await and Recursion

I employed a recursive function to browse the user machine's directories and all subdirectories. This is a windows form application that populates the files / directories as they are read and processed, asynchronously. The project requirements are listed below:

### Assignment 6 - File Systems and Async Programming:

#### 1.

Create a program that allows a user to browse to a folder. The program should then list all the folders and files that are in that folder and how many there are. The form should have a checkbox that lets the user decide if it should only count folders/files in the top directory, or if it should include subdirectories. Use the existing .NET classes FolderBrowserDialog and Directory to help you (we’ve used similar in class; use the intellisense and online documentation to help you figure out how to use them, and/or Chapter 17 in the book).

#### 2.

If you choose a folder with many items underneath, such as C:\, and if you are looking in subdirectories, this operation can take a long time and cause the form to become unresponsive. Modify the form to use asynchronous programming (multithreading) to prevent the program from ‘blocking’ (when it says ‘this program is not responding’ because its busy working). You will need the keywords async, await, and the Task class. Refer to Chapter 21 to help you.