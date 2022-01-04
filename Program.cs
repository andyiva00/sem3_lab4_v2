using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3_lab4_v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList<NodeValueStruct> listOfColoredText = new DoublyLinkedList<NodeValueStruct>();
            listOfColoredText.AddLast(new NodeValueStruct("Text1", ConsoleColor.White));
            listOfColoredText.AddLast(new NodeValueStruct("Text2", ConsoleColor.Yellow));
            listOfColoredText.AddLast(new NodeValueStruct("Text3", ConsoleColor.Red));
            listOfColoredText.AddLast(new NodeValueStruct("Text4", ConsoleColor.Blue));
            listOfColoredText.AddLast(new NodeValueStruct("Text4", ConsoleColor.Red));
            listOfColoredText.AddLast(new NodeValueStruct("Text5"));

            // Проверка результатов
            Console.WriteLine(listOfColoredText.ToString());

            LinkedListNode<NodeValueStruct> foundedNode;

            // Поиск в двусвязном списке первого по тексту и замена цвета в найденном
            foundedNode = listOfColoredText.FindFirstByText("Text4");
            if (foundedNode != null)
            {
                Console.WriteLine(foundedNode.Value.ToString());
                foundedNode.Value = new NodeValueStruct(foundedNode.Value.ValueText, ConsoleColor.Black);
            }

            // Поиск в двусвязном списке последнего по тексту и замена цвета в найденном
            foundedNode = listOfColoredText.FindLastByText("Text4");
            if (foundedNode != null)
            {
                Console.WriteLine(foundedNode.Value.ToString());
                foundedNode.Value = new NodeValueStruct(foundedNode.Value.ValueText, ConsoleColor.Black);
            }

            // Проверка результатов
            Console.WriteLine(listOfColoredText.ToString());

            // Поиск в двусвязном списке первого по цвету и замена текста в найденном
            foundedNode = listOfColoredText.FindFirstByColor(ConsoleColor.White);
            if (foundedNode != null)
            {
                Console.WriteLine(foundedNode.Value.ToString());
                foundedNode.Value = new NodeValueStruct("NewText", foundedNode.Value.ValueColor);
            }

            // Поиск в двусвязном списке последнего по цвету и замена текста в найденном
            foundedNode = listOfColoredText.FindLastByColor(ConsoleColor.White);
            if (foundedNode != null)
            {
                Console.WriteLine(foundedNode.Value.ToString());
                foundedNode.Value = new NodeValueStruct("NewText", foundedNode.Value.ValueColor);
            }

            // Проверка результатов
            Console.WriteLine(listOfColoredText.ToString());

            Console.ReadKey(true);
        }
    }
}
