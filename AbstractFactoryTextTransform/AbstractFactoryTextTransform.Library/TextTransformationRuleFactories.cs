using AbstractFactoryTextTransform.Library.Abstractions;
using AbstractFactoryTextTransform.Library.Rules.StringInsert;
using AbstractFactoryTextTransform.Library.Rules.StringReplace;
using System.Collections.Generic;

namespace AbstractFactoryTextTransform.Library
{
    public class TextTransformationRuleFactories
    {
        public static List<ITextTransformationRuleFactory> RegisteredFactories { get; private set; } = new List<ITextTransformationRuleFactory>();

        public static void RegisterFactories()
        {
            // Poor's man DI
            RegisteredFactories.Add(new StringReplaceTransformationRuleFactory());
            RegisteredFactories.Add(new StringInsertTransformationRuleFactory());
        }
    }
}
