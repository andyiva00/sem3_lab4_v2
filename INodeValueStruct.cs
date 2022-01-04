using System;

namespace sem3_lab4_v2
{
    internal interface INodeValueStruct
    {
        ConsoleColor ValueColor { get; set; }
        string ValueText { get; set; }

        string ToString();
    }
}