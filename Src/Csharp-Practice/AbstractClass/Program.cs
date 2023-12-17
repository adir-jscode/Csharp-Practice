using AbstractClass;

Animal dog = new Dog();
dog.SetName("Tobby");
string name = dog.GetName();
Console.WriteLine(name);
dog.Eat();