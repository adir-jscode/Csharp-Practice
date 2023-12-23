// See https://aka.ms/new-console-template for more information
using StructureExample;

Person person = new Person("Adir",24);
person.Age = 30;
int age = person.RoundAge(person.Age);

Console.WriteLine(age);
//for struct -> It creates a new instance
Person person1 = person;
person1.Age = 45;

Console.WriteLine(person.Age);
Console.WriteLine(person1.Age);





