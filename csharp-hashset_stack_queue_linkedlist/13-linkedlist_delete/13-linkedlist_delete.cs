using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            return; // Invalid index
        }

        LinkedListNode<int> current = myLList.First;

        if (index == 0)
        {
            myLList.RemoveFirst();
            return;
        }

        for (int i = 0; i < index - 1; i++)
        {
            current = current.Next;
        }

        myLList.RemoveAfter(current);
    }
}