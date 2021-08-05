using AbstractFactoryTextTransform.Library.Abstractions;

namespace AbstractFactoryTextTransform.Library.Rules.StringInsert
{
    public class StringInsertTransformationRule : ITextTransformationRule
    {
        public StringInsertTransformationRule(StringInsertTransformationOptions options)
        {
            Options = options ?? new StringInsertTransformationOptions();
        }

        public StringInsertTransformationOptions Options { get; }

        public string Transform(string text)
        {
            if (!string.IsNullOrEmpty(text) && 
                Options.Index >= 0 && 
                Options.Index < text.Length)
            {
                return text.Insert(Options.Index, Options.Text);
            }

            return text;
        }
    }
}
