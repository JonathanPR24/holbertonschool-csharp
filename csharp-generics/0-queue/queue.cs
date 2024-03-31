using System;

/// <summary>
/// Represents a generic queue.
/// </summary>
public class Queue<T>
{
    /// <summary>
    /// Checks the type of the queue.
    /// </summary>
    /// <returns>The type of the queue.</returns>
    public string CheckType()
    {
        return typeof(T).ToString();
    }
}
