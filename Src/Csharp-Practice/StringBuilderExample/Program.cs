using System.Text;

string s1 = "Hello";
Console.WriteLine(s1);
string s2 = " World";

s1 = s1 + s2;
Console.WriteLine(s1);


StringBuilder stringBuilder = new StringBuilder("Jalaludding");
stringBuilder.Replace("u"," u");

string s3 = stringBuilder.ToString();
Console.WriteLine(s3);
//Can change in StringBuilder, We can't change in String
for(int i=0;i<stringBuilder.Length;i++)
{
    stringBuilder[i] = 'A';
    Console.Write(stringBuilder[i]);
}
