using AbstractFactoryTextTransform.Library.Abstractions;

namespace AbstractFactoryTextTransform.Library.Rules.StringInsert
{
    public class StringInsertTransformationOptions : TextTransformationOptions
    {
        public int Index { get; set; } = 0;

        public string Text { get; set; } = string.Empty;
    }
}
