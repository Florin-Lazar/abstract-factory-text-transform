using AbstractFactoryTextTransform.Library.Abstractions;

namespace AbstractFactoryTextTransform.Library.Rules.StringReplace
{
    public class StringReplaceTransformationRuleFactory : ITextTransformationRuleFactory
    {
        public ITextTransformationRule Create(TextTransformationOptions options)
        {
            if (options is StringReplaceTransformationOptions stringReplaceOptions)
            {
                return new StringReplaceTransformationRule(
                    stringReplaceOptions.SearchText,
                    stringReplaceOptions.ReplaceWithText);
            }

            return null;
        }
    }
}
