#region Generic Collection

// List
using System.Collections;

List<string> names = new List<string>();
names.Add("Adir");
names.Add("Sarafat");
names.Add("Ali");
foreach (string name in names)
{
    Console.WriteLine(name);
}

//Dictonary
Dictionary<string,int> keyValuePairs = new Dictionary<string,int>();
keyValuePairs.Add("jalaluddin", 42);
keyValuePairs.Add("hasan", 32);

Console.WriteLine(keyValuePairs["jalaluddin"]);
keyValuePairs["hasan"] = 50;

//Hashset

HashSet<string> keys = new HashSet<string>();
keys.Add("tareq");
keys.Add("hasan");
keys.Add("tareq");

//Linked List

LinkedList<string> list = new LinkedList<string>();
list.AddFirst("Adir");

LinkedListNode<string> node =  list.Find("Adir");

//Queue

Queue<string> persons = new Queue<string>();
persons.Enqueue("Adir");
persons.Enqueue("Ali");

string person = persons.Dequeue();
string check = persons.Peek();

//Priority Queue

PriorityQueue<string,int> priorityQueue = new PriorityQueue<string,int>();
priorityQueue.Enqueue("Adir", 1);
priorityQueue.Enqueue("Ali", 10);

string dequeue = priorityQueue.Dequeue();
Console.WriteLine(dequeue);

//SortedDictonary & SortedList - Study

//Sorted Set

SortedSet<string> sorted = new SortedSet<string>();
sorted.Add("mango");
sorted.Add("Apple");
sorted.Add("Oats");

foreach (var item in sorted)
{
    Console.WriteLine(item);
}

//Stack

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);

int count = stack.Count;

for (int i = 0; i < count; i++)
{
    Console.WriteLine(stack.Pop());    
}
#endregion


#region Non Generic

ArrayList items = new ArrayList();
items.Add("Adir");
items.Add(6);
items.Add(true);

//Bit Array , SortedList,SortedDictonary

//Hashtable

Hashtable hashtable = new Hashtable();
hashtable.Add(5, "hello");
hashtable.Add("World", 10);

int hash = (int)hashtable["World"];
Console.WriteLine(hash);

#endregion
