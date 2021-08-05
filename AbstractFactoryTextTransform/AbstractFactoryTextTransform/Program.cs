using AbstractFactoryTextTransform.Library;
using AbstractFactoryTextTransform.Library.Rules.StringReplace;
using System;

namespace AbstractFactoryTextTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            string initialText = "Hello World";
            TextProcessor processor = new TextProcessor();
            string transformedText = processor.Transform(
                initialText,
                new StringReplaceTransformationOptions { SearchText = "World", ReplaceWithText = "Dani" });
            Console.WriteLine($"Transformed text={transformedText}");
        }
    }
}
