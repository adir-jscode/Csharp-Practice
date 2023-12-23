using EnumExample;

void Register(string name, string password,AccountTypes accountTypes)
{
    Console.WriteLine((int)accountTypes);
    Console.WriteLine(accountTypes.ToString());
}

Register("Adir", "1234", AccountTypes.VIP);