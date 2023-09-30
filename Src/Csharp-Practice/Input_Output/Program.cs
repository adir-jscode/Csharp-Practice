
//Using Placeholder

string name = "Adir";
string location = "Mirpur";

Console.WriteLine("Hello I am, {0}. I am from {1}",name,location);

string text = $"Hey, {name} ! Are you from {location}?";

Console.WriteLine(text);

string line = Console.ReadLine(); // read string

int  ascii = Console.Read(); // return int

Console.WriteLine("Ascii Value = {0} " , ascii);
Console.WriteLine("Type Cast to Char " + (char)ascii);

ConsoleKeyInfo key= Console.ReadKey(); // read imidiate after typing