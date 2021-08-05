using AbstractFactoryTextTransform.Library;
using System;

namespace AbstractFactoryTextTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialText = "Hello World";
            TextProcessor processor = new TextProcessor();
            string transformedText = processor.Transform(initialText);
            Console.WriteLine($"Transformed text={transformedText}");
        }
    }
}
