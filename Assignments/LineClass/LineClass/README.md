# Assignment1

## Line Class

### From Assignment Outline:

The equation of a line in standard form is ax + by = c, where both a and b cannot be 0, and a, b, and c are real numbers. If b != 0 then -a/b is the slope of the line. If a = 0 then it is horizontal, and if b = 0 it is vertical. A vertical line has an undefined slope. Two lines are parallel if they are both vertical or they both have the same slope. Two lines are perpendicular if one is horizontal and the other is vertical, or if the product of their slopes is -1.

Design a class Line. A Line should have private member variables, or instance variables, at least for the values a, b and c, and public Properties to get and set them. A Line should have methods to do the following:

Return the value of X for a given Y value

Return the value of Y for a given X value

Return the slope of the line

Determine whether 2 lines are parallel

Determine whether 2 lines are perpendicular

Determine the point at which 2 lines intersect if they are not parallel


## Added Functionality

### Input Validation function

Decided to add this to the Line class methods for quick and easy
input validation use. Pretty self-explanatory. If the input is anything
other than a valid number, the program continually asks you for valid
input.

### Output Value Formatting

Used
```cs
Math.Round(variable, precision);
```
to ouput values for the line calculations limited to two decimal places.
