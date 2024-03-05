using System;
using System.Collections.Generic;

// Base class representing an animal
public class Animal
{
    protected string name;
    protected string sound;

    // Constructor to initialize name and sound
    public Animal(string name, string sound)
    {
        this.name = name;
        this.sound = sound;
    }

    // Method to make the animal sound
    public virtual string MakeSound()
    {
        return $"{name} says {sound}";
    }
}

// Derived class representing a specific type of animal (e.g., Cow)
public class Cow : Animal
{
    // Constructor for Cow, invoking base class constructor
    public Cow(string name) : base(name, "moo")
    {
    }
}

// Derived class representing another type of animal (e.g., Chicken)
public class Chicken : Animal
{
    // Constructor for Chicken, invoking base class constructor
    public Chicken(string name) : base(name, "cluck")
    {
    }
}