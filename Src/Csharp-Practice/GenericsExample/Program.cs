using GenericsExample;

BubbleSort<int> bubbleSort = new BubbleSort<int>();

var result = bubbleSort.SortArray(new[] { 1, 10, 4 });

foreach (var item in result)
{
    Console.WriteLine(item);
}

List<string> list = new List<string>();
list.Add("A");
list.Add("B");
list.Add("C");
list.Add("D");

foreach (var item in list)
{
    Console.WriteLine($"{item}");
}

Point<string,int,Random> point = new Point<string,int,Random>();
point.Convert<Random>(new Random());

DefaultKeyword<DateTime> date = new DefaultKeyword<DateTime>();
var time = date.CreateInstance();
Console.WriteLine(time.ToString());
