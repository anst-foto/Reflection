using System.Reflection;
using Reflection;

var test = new Test();
Console.WriteLine($"test.number = {test.number}");

var test2 = new Test2();
Console.WriteLine($"test2.number = {test2.number}");

Base2.PrintOptional(test2);
Console.WriteLine($"test2.number = {test2.number}");

Base2.PrintOptional(test);
Console.WriteLine($"test.number = {test.number}");


/*var testType = test.GetType();
var fields = testType.GetField("number", BindingFlags.NonPublic | BindingFlags.Instance);
fields.SetValue(test, 5);
Console.WriteLine($"number = {test.Get}");*/

