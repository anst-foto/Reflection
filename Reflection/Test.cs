namespace Reflection;

public class Test : Base
{
    [Optional(50)]
    public int number;
    public int Get => number;
    public string Str { get; set; }
    public void Increment() => number++;

    public Test()
    {
        //number = 10;
    }
}

public class Test2
{
    [Optional(20)]
    public int number;
}