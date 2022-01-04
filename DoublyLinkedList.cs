using System;
using System.Collections.Generic;
using System.Text;

namespace sem3_lab4_v2
{
    internal class DoublyLinkedList<T> : LinkedList<T>, IDoublyLinkedList<T>
        where T : INodeValueStruct
    {
        public LinkedListNode<T> FindFirstByText(string _compareText)
        {
            var _currentNode = First;

            do
            {
                if (_currentNode != null)
                {
                    if (_currentNode.Value.ValueText == _compareText)
                    {
                        break;
                    }
                }

                _currentNode = _currentNode.Next;
            } while (_currentNode != null);

            return _currentNode;
        }
        
        public LinkedListNode<T> FindLastByText(string _compareText)
        {
            var _currentNode = Last;

            do
            {
                if (_currentNode != null)
                {
                    if (_currentNode.Value.ValueText == _compareText)
                    {
                        break;
                    }
                }

                _currentNode = _currentNode.Previous;
            } while (_currentNode != null);

            return _currentNode;
        }
        
        public LinkedListNode<T> FindFirstByColor(ConsoleColor _compareColor)
        {
            var _currentNode = First;

            do
            {
                if (_currentNode != null)
                {
                    if (_currentNode.Value.ValueColor == _compareColor)
                    {
                        break;
                    }
                }

                _currentNode = _currentNode.Next;
            } while (_currentNode != null);

            return _currentNode;
        }
        
        public LinkedListNode<T> FindLastByColor(ConsoleColor _compareColor)
        {
            var _currentNode = Last;

            do
            {
                if (_currentNode != null)
                {
                    if (_currentNode.Value.ValueColor == _compareColor)
                    {
                        break;
                    }
                }

                _currentNode = _currentNode.Previous;
            } while (_currentNode != null);

            return _currentNode;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("{");
            if (First != null)
            {
                sb.Append(First.Value.ToString());
                LinkedListNode<T> currentNode = First;
                while (currentNode.Next != null)
                {
                    currentNode = currentNode.Next;
                    sb.Append(", ");
                    sb.Append(currentNode.Value.ToString());
                }
            }
            sb.Append("}");

            return sb.ToString();
        }
    }
}
