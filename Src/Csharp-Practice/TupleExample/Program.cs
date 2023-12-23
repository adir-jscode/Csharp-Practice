using TupleExample;


var products = new[]
{
    new Product { Id = 1,Name="Iphone",Price=101.2},
    new Product { Id = 2,Name="IPad",Price=200.2}

};

double max = double.MinValue;

(string name, double price) TopProduct = (null, 0); 

foreach (var item in products)
{
    if(item.Price>max)
    {
        max = item.Price;
        TopProduct.Item1 = item.Name;
        TopProduct.Item2 = item.Price;
    }
}

Console.WriteLine($"Price : {TopProduct.price} , Name : {TopProduct.name}");

(string,int) Concate(string a,string b)
{
    string r = a + b;
    return (r, r.Length);
}

(string result, int l) r = Concate("Hello", "World");

Console.WriteLine(r.result + " " +  r.l);

(int x,int y) sum =(5,10);

Console.WriteLine(sum.x);
Console.WriteLine(sum.y);