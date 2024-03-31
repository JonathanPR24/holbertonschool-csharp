using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
public class Queue<T>
{
    private Node head;
    private Node tail;
    private int count;

    /// <summary>
    /// Initializes a new instance of the <see cref="Queue{T}"/> class.
    /// </summary>
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    /// <summary>
    /// Adds a new node with the specified value to the end of the queue.
    /// </summary>
    /// <param name="value">The value to be added to the queue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            tail = newNode;
        }
        count++;
    }

    /// <summary>
    /// Returns the number of nodes in the queue.
    /// </summary>
    /// <returns>The number of nodes in the queue.</returns>
    public int Count()
    {
        return count;
    }
}
