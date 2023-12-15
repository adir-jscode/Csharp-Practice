
//Using Placeholder

string name = "Adir";
string location = "Mirpur";

Console.WriteLine("Hello I am, {0}. I am from {1}", name, location);

string text = $"Hey, {name} ! Are you from {location}?";

Console.WriteLine(text);

string line = Console.ReadLine(); // read string

int ascii = Console.Read(); // return int

Console.WriteLine("Ascii Value = {0} ", ascii);
Console.WriteLine("Type Cast to Char " + (char)ascii);
Console.Read();

/*ConsoleKeyInfo key= Console.ReadKey();*/ // read imidiate after typing

int [] nums = new int[3];

string input = Console.ReadLine();

string [] partsOfLine = input.Split(',',' ');

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = int.Parse(partsOfLine[i]);
    Console.WriteLine(nums[i]);
}