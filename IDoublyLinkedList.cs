using System.Collections.Generic;
using System;

namespace sem3_lab4_v2
{
    internal interface IDoublyLinkedList<T>
        where T : INodeValueStruct
    {
        LinkedListNode<T> FindFirstByText(string _compareText);
        LinkedListNode<T> FindLastByText(string _compareText);
        LinkedListNode<T> FindFirstByColor(ConsoleColor _compareColor);
        LinkedListNode<T> FindLastByColor(ConsoleColor _compareColor);

        string ToString();
    }
}