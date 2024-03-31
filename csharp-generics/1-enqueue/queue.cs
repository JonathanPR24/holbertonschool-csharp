///<summary>Class for queue operations</summary>
/// <typeparam name="T">Type parameter</typeparam>
class Queue<T>
{
    ///<summary>Check if it's a queue type</summary>
    ///<returns>Returns the type of the queue</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
    
    /// <summary>Represents a node in the queue</summary>
    public class Node
    {
        private T value;
        public Node next = null;

        /// <summary>Initializes a new instance of the Node class with the specified value</summary>
        public Node(T value)
        {
            this.value = value;
        }
    }

    public Node head;
    public Node tail;
    public int count;

    ///<summary>Adds a new node to the end of the queue</summary>
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

    ///<summary>Returns the number of nodes in the queue</summary>
    public int Count()
    {
        return count;
    }
}
