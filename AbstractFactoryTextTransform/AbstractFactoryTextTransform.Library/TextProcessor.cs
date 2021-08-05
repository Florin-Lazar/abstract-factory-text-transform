using AbstractFactoryTextTransform.Library.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactoryTextTransform.Library
{
    public class TextProcessor
    {
        public TextProcessor()
            : this (TextTransformationRuleFactories.RegisteredFactories)
        {
        }

        public TextProcessor(IEnumerable<ITextTransformationRuleFactory> factories)
        {
            Factories = factories ?? Enumerable.Empty<ITextTransformationRuleFactory>();
        }

        public IEnumerable<ITextTransformationRuleFactory> Factories { get; }

        public string Transform(string text)
        {
            string transformedText = text;

            foreach (ITextTransformationRuleFactory factory in Factories)
            {
                ITextTransformationRule rule = factory.Create();
                transformedText = rule.Transform(transformedText);
            }

            return transformedText;
        }
    }
}
