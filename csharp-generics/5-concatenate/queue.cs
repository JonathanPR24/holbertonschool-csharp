using System;

///<summary>Class for queue operations</summary>
/// <typeparam name="T">type parameter</typeparam>
class Queue<T>
{
    ///<summary>Check if it's a queue type</summary>
    ///<returns>Returns a Queue type</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
    
    /// <summary>Class Node inside queue class</summary>
    public class Node
    {
        public T value;
        public Node next = null;

        public Node(T item)
        {
            value = item;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    ///<summary>Add new node at the end</summary>
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
            tail.next = newNode;
            tail = newNode;
        }
        count++;
    }

    ///<summary>Remove and return the first node</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            T dequeuedValue = head.value;
            head = head.next;
            count--;
            return dequeuedValue;
        }
    }

    ///<summary>Return the value of the first node without removing it</summary>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            return head.value;
        }
    }

    ///<summary>Print the queue, starting from the head</summary>
    public void Print()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.value);
                current = current.next;
            }
        }
    }

    ///<summary>Concatenate all values in the queue if it's of type string or char</summary>
    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }
        else if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
            return null;
        }
        else
        {
            Node current = head;
            string concatenatedValue = "";
            while (current != null)
            {
                concatenatedValue += current.value.ToString();
                current = current.next;
            }
            return concatenatedValue;
        }
    }
}
