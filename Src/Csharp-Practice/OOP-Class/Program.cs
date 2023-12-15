using OOP_Class;

Person person = new Person();
//person.FirstName = "Test";
//person.LirstName = "";

string result = person.GetName(new string[] {","});
Console.WriteLine(result);

Person person1 = new Person("ADIR", "MD SARAFAT ALI ADIR");
//person1.FirstName = ""; // Can't set
person1.LastName = "Hello";

string fullName = person1.GetName(",");
Console.WriteLine(fullName);