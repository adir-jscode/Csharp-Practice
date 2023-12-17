using OOP_Advance;

Person Teacher = new Teacher("40A");
Person Student = new Student(50);
Student s1 = new Student(70);

RandomNumberGenerator.GenerateRandomNumber();

Console.WriteLine(Teacher.GetId());
Console.WriteLine(Student.GetId());


Internet7G internet7G = new Internet7G();
Internet5G internet5G = new Internet5G();

Laptop laptop = new Laptop(internet7G);
laptop.BrowseWebsite();

Laptop laptop2 = new Laptop(internet5G);
laptop2.BrowseWebsite();

