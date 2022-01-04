using System;

namespace sem3_lab4_v2
{
    internal struct NodeValueStruct : INodeValueStruct
    {
        public string ValueText { get; set; }
        public ConsoleColor ValueColor { get; set; }
        public NodeValueStruct(string valueText, ConsoleColor valueColor = ConsoleColor.White)
        {
            ValueText = valueText;
            ValueColor = valueColor;
        }

        public override string ToString() => $"({ValueText}, {ValueColor.ToString()})";
    }
}
