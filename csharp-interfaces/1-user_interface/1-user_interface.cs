﻿using System;

/// <summary>
/// Interface defining an interactable object.
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact with this object.
    /// </summary>
    void Interact();
}

/// <summary>
/// Interface defining a breakable object.
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// The durability of the breakable object.
    /// </summary>
    int durability { get; set; }

    /// <summary>
    /// Break this object.
    /// </summary>
    void Break();
}

/// <summary>
/// Interface defining a collectable object.
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// Denotes whether the object has been collected.
    /// </summary>
    bool isCollected { get; set; }

    /// <summary>
    /// Collect this object.
    /// </summary>
    void Collect();
}

/// <summary>
/// A base class.
/// </summary>
abstract class Base
{
    public string name { get; set; }

    /// <summary>
    /// Convert the object to a string.
    /// </summary>
    public override string ToString()
    {
        return $"{name} is a {this.GetType()}";
    }
}

class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability { get; set; }
    public bool isCollected { get; set; }

    public void Interact()
    {
        Console.WriteLine($"{name} is being interacted with.");
    }

    public void Break()
    {
        Console.WriteLine($"{name} is being broken.");
    }

    public void Collect()
    {
        Console.WriteLine($"{name} is being collected.");
    }
}
