using AbstractFactoryTextTransform.Library.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryTextTransform.Library.Rules.StringInsert
{
    public class StringInsertTransformationRuleFactory : ITextTransformationRuleFactory
    {
        public ITextTransformationRule Create(TextTransformationOptions options)
        {
            if (options is StringInsertTransformationOptions stringInsertOptions)
            {
                return new StringInsertTransformationRule(stringInsertOptions);
            }

            return null;
        }
    }
}
