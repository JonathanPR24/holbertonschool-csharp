using System;
using System.Text;

///<summary>Represents a generic queue.</summary>
public class Queue<T>
{
    ///<summary>Represents a node in the queue.</summary>
    public class Node
    {
        ///<summary>Gets or sets the value of the node.</summary>
        public T Value { get; set; }
        
        ///<summary>Gets or sets the next node in the queue.</summary>
        public Node Next { get; set; }

        ///<summary>Initializes a new instance of the Node class with the specified value.</summary>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    ///<summary>Represents the head of the queue.</summary>
    public Node head;

    ///<summary>Represents the tail of the queue.</summary>
    public Node tail;

    ///<summary>Represents the number of nodes in the queue.</summary>
    public int count;

    ///<summary>Adds a new node to the end of the queue.</summary>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (head == null)
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

    ///<summary>Removes the first node in the queue and returns its value.</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.Value;
        head = head.Next;
        count--;

        return value;
    }

    ///<summary>Returns the value of the first node in the queue without removing the node.</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.Value;
    }

    ///<summary>Prints the queue, starting from the head.</summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.WriteLine(current.Value);
            current = current.Next;
        }
    }

    ///<summary>Concatenates all values in the queue if the queue is of type string or char.</summary>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        StringBuilder result = new StringBuilder();
        Node current = head;
        while (current != null)
        {
            result.Append(current.Value);
            current = current.Next;
        }
        return result.ToString();
    }

    ///<summary>Returns the number of nodes in the queue.</summary>
    public int Count()
    {
        return count;
    }
}
