# To Do List

This was the first GUI application I created using Windows Forms with C# and the .NET Framework. I had actually misinterpreted some of the project requirements and in so doing, inadvertantly introduced more functionality to the application. The accept / exit properties for the required Windows Form controls were misinterpreted as saving or clearing information from the persistent data of the user's list. 

The project requirements are listed below:

## Assignment 5 – Advanced Controls and File I/O

### 1.

Create a ‘To-Do List’ form application. It should allow users to enter a name and date for an activity (use a DateTimePicker control) and view their activities as a list (use a ListBox control). It should have 5 buttons to quit, add an activity, remove an activity, sort the list by name, and sort the list by date (use LINQ for sorting).

### 2. 

Make the application save the user’s activities to a file and load them back again the next time they open the application. It does NOT need to be a file of the user’s choice (you aren’t required to use save/open file dialogs).

### 3. 

The form should have appropriate Accept and Cancel buttons set, hotkeys for the 5 buttons (like Alt+A should activate the ‘Add Activity’ button). The controls should be cleared once an event is added (the TextBox emptied and the DateTimePicker set back to ‘today’). Finally, the form should have appropriate Tab Indices and Tab Stop’s set, so that if you press Tab it goes through the controls in order, skipping those that shouldn’t be tabbed to.

# Learning Outcomes:

This Windows, GUI, event driven application was not dissimilar to most I have already developed using JS and PHP. It was nice to finally put my C# background to work. I had actually been taking an iOS class at the same time, and this is really where Swift / C# started to click for me with event driven controls in the "drag and drop" realm. 

As stated previously, I misunderstood the control property of 'accept' / 'cancel' options and wound up implementing a save / delete feature though, rudimentary, still functioned as intended. 