using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        Console.WriteLine($"Top item: {(aStack.Count > 0 ? aStack.Peek() : "Stack is empty")}");
        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

        while (aStack.Count > 0 && aStack.Pop() != search) { }

        aStack.Push(newItem);
        return aStack;
    }
}
