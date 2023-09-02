using System.Reflection;

namespace Reflection;

public class Base
{
    public Base()
    {
        foreach (var fieldInfo in GetType().GetFields())
        {
            var attribute = fieldInfo
                .GetCustomAttributes<OptionalAttribute>(true)
                .SingleOrDefault();
            if (attribute == null)
                continue;
            fieldInfo.SetValue(this, attribute.DefaultValue);
        }
    }
}

public static class Base2
{
    public static void PrintOptional(object obj)
    {
        var fields = obj
            .GetType()
            .GetFields();
        foreach (var field in fields)
        {
            var attributes = field.GetCustomAttributes<OptionalAttribute>();
            foreach (var attribute in attributes)
            {
                if (attribute.DefaultValue > 0)
                {
                    field.SetValue(obj, attribute.DefaultValue);
                }
            }
        }
    }
}