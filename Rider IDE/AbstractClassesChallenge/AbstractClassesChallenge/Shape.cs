﻿namespace AbstractClassesChallenge;

public abstract class Shape
{
    public string Name { get; set; }

    public virtual void GetInfo()
    {
        Console.WriteLine($"This is a {Name}");
    }
    public abstract double Volume();
}