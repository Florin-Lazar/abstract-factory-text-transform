using AbstractFactoryTextTransform.Library.Abstractions;
using System.Collections.Generic;

namespace AbstractFactoryTextTransform.Library
{
    public class TextTransformationRuleFactories
    {
        public static List<ITextTransformationRuleFactory> RegisteredFactories { get; private set; }

        public static void RegisterFactory(ITextTransformationRuleFactory factory)
        {
            RegisteredFactories.Add(factory);
        }
    }
}
