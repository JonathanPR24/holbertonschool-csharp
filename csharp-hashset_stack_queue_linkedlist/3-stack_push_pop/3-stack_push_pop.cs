using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
    {
        Console.WriteLine($"Number of items: {aStack.Count}");
        Console.WriteLine($"Top item: {aStack.Count > 0 ? aStack.Peek() : "Stack is empty"}");
        Console.WriteLine($"Stack contains \"{search}\": {aStack.Contains(search)}");

        if (aStack.Contains(search))
        {
            Stack<string> tempStack = new Stack<string>();

            while (aStack.Count > 0 && aStack.Peek() != search) tempStack.Push(aStack.Pop());
            if (aStack.Count > 0) aStack.Pop(); // Remove the search item
            while (tempStack.Count > 0) aStack.Push(tempStack.Pop());
        }

        aStack.Push(newItem);

        return aStack;
    }
}