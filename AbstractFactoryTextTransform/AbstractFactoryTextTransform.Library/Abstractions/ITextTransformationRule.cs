namespace AbstractFactoryTextTransform.Library.Abstractions
{
    public interface ITextTransformationRule
    {
        string Transform(string text);
    }
}
