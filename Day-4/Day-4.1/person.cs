using System;

class Person
{
    // Fields
    private string name;
    private int age;

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
            else
                age = 0;
        }
    }

    // Default Constructor
    public Person()
    {
        name = "Unknown";
        age = 0;
    }

    // Parameterized Constructor
    public Person(string name, int age)
    {
        this.name = name;
        Age = age;
    }

    // ToString override
    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
