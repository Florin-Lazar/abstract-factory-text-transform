using AbstractFactoryTextTransform.Library.Abstractions;

namespace AbstractFactoryTextTransform.Library.Rules.StringReplace
{
    public class StringReplaceTransformationOptions : TextTransformationOptions
    {
        public string SearchText { get; set; } = string.Empty;

        public string ReplaceWithText { get; set; } = string.Empty;
    }
}
