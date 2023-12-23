using ParameterModifier;

Example example = new Example();
Console.WriteLine(example.Append("I", " Am", " Adir", " From", " Mirpur"));

var t = 8;
example.Test1(ref t);
Console.WriteLine(t);

example.Test3(out t);
Console.WriteLine(t);