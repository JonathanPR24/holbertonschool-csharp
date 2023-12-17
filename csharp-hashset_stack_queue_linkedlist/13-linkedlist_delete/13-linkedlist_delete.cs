using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        if (index < 0 || index >= myLList.Count)
        {
            return;
        }

        LinkedListNode<int> nodeToDelete = myLList.First;
        for (int i = 0; i < index; i++)
        {
            nodeToDelete = nodeToDelete.Next;
        }

        myLList.Remove(nodeToDelete);
    }
}