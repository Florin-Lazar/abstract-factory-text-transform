using AbstractFactoryTextTransform.Library.Abstractions;

namespace AbstractFactoryTextTransform.Library.Rules.StringReplace
{
    public class StringReplaceTransformationRule : ITextTransformationRule
    {
        public StringReplaceTransformationRule(
            string searchText,
            string replaceWithText)
        {
            SearchText = searchText;
            ReplaceWithText = replaceWithText;
        }

        public string SearchText { get; }

        public string ReplaceWithText { get; }

        public string Transform(string text)
        {
            return text.Replace(SearchText, ReplaceWithText);
        }
    }
}
