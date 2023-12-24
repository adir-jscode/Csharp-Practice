

using AdoExamplme;

string ConnectionString = "Server=ADIR\\SQLEXPRESS;Database=Csharpb-15;User Id=sarafat;Password=1111; Trust Server Certificate=True";

Adoutility adoutility = new Adoutility(ConnectionString);

Console.WriteLine("Insert Student Info : ");
string[] parts = Console.ReadLine().Split(',');

string insetSql = "insert into students (id,name,address,cgpa) values(@id,@name,@address,@cgpa)";
string updatesql = "update students set name='Ali' where name='adir'";
string deletesql = "delete from students where id=2";



Dictionary<string,object> parameters = new Dictionary<string,object>();
parameters.Add("id", parts[0]);
parameters.Add("name", parts[1]);
parameters.Add("address", parts[2]);
parameters.Add("cgpa", parts[3]);

adoutility.ExecuteQuery(insetSql,parameters);



Console.WriteLine("Give Student Id to Info : ");
int id = int.Parse(Console.ReadLine());


string selectsql = "select * from students where id=@id";

Dictionary<string,object> parameter2 = new Dictionary<string,object>();
parameter2.Add("id", id);

var result = adoutility.GetData(selectsql,parameter2);

foreach(var row in result)
{
    foreach(var col in row)
    {
        Console.Write(col.Value);
        Console.Write(',');
    }
    Console.WriteLine();
}

Console.WriteLine("Done!");
