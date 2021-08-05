using AbstractFactoryTextTransform.Library.Abstractions;
using AbstractFactoryTextTransform.Library.Rules.StringReplace;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactoryTextTransform.Library
{
    public class TextProcessor
    {
        static TextProcessor()
        {
            TextTransformationRuleFactories.RegisterFactories();
        }

        public TextProcessor()
            : this (TextTransformationRuleFactories.RegisteredFactories)
        {
        }

        public TextProcessor(IEnumerable<ITextTransformationRuleFactory> factories)
        {
            Factories = factories ?? Enumerable.Empty<ITextTransformationRuleFactory>();
        }

        public IEnumerable<ITextTransformationRuleFactory> Factories { get; }

        public string Transform(string text, params TextTransformationOptions[] options)
        {
            string transformedText = text;

            foreach (TextTransformationOptions option in options)
            {
                ITextTransformationRule matchingRule = Factories
                    .Select(f => f.Create(option))
                    .Where(p => !ReferenceEquals(p, null))
                    .FirstOrDefault();

                transformedText = matchingRule?.Transform(transformedText) ?? transformedText;
            }

            return transformedText;
        }
    }
}
