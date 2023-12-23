int? x = 5;
x = null;

if(x.HasValue)
{
    Console.WriteLine(x.Value);
}

double? y = null;

Console.WriteLine(y.Value);
