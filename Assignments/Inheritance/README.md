# Assignment 3

## From Project Guidelines

### Assignment 3 – Inheritance, Polymorphism and Interfaces

Inheritance (Chapter 11, starting page 286)

Create the following classes:

Vessel, which is an abstract class and represents any water-going craft. 
Ship, which is a Vessel. Fun Fact: A Ship is any vessel that is large enough to carry smaller Boats.
Boat, which is a Vessel.
and Cat, which is just a cat.

All Vessels should have a float speed; and string name;
Ships should have an int fuel and an int maxFuel. 
Boats should have an int oars; 
Cats should have an int hunger and an int maxHunger;

All Vessels should have the ability to Move. 
If a Ship has fuel, it moves at the rate stored in the float speed;
A Boat moves by its speed multiplied by how many oars it has.

## 9.29.2020

Created directory structure, updated this README.md file, and created all required classes described
within the project guidelines.

## 10.1.2020

Having a lot of trouble figuring out how to implement the FuelPercentage property and get the correct value
When I implement the getter, it auto initializes the value to zero, since maxHunger is zero upon
object instantiation. After the values are set, FuelPercentage is never calculated. It's just set to 0.

Figured out what the problem was. I needed to cast the datatypes for hunger and maxHunger from int to float since
the return type for the Interface method is float. I've been writing in so many languages this semester that I completely
forgot about having to manually cast the datatypes for return.

Everything works as perscribed. Satisfies all assignment requirements.