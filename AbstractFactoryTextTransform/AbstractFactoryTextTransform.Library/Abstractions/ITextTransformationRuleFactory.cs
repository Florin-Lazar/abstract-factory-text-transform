namespace AbstractFactoryTextTransform.Library.Abstractions
{
    public interface ITextTransformationRuleFactory
    {
        ITextTransformationRule Create(TextTransformationOptions options);
    }
}
