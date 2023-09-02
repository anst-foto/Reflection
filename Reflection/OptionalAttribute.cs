namespace Reflection;

public sealed class OptionalAttribute : Attribute
{
    public int DefaultValue { get; set; }
    
    public OptionalAttribute(int defaultValue)
    {
        DefaultValue = defaultValue;
    }
}