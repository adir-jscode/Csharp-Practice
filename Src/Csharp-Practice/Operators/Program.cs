#region Example 1 - Increment/Decrement operator
int i = 3;
Console.WriteLine(i);   // output: 3
Console.WriteLine(i++); // output: 3
Console.WriteLine(i);   // output: 4

double a = 1.5;
Console.WriteLine(a);   // output: 1.5
Console.WriteLine(++a); // output: 2.5
Console.WriteLine(a);   // output: 2.5

int i2 = 3;
Console.WriteLine(i2);   // output: 3
Console.WriteLine(i2--); // output: 3
Console.WriteLine(i2);   // output: 2

double a2 = 1.5;
Console.WriteLine(a2);   // output: 1.5
Console.WriteLine(--a2); // output: 0.5
Console.WriteLine(a2);   // output: 0.5

#endregion


#region Example 2 - Unary plus and minus operators

Console.WriteLine(+4);  // output: 4
Console.WriteLine(-4);  // output: -4
Console.WriteLine(-(-4));  // output: 4
#endregion

#region Example 3 - Math operators
Console.WriteLine(5 * 2);       // output: 10
Console.WriteLine(0.5 * 2.5);   // output: 1.25
Console.WriteLine(0.1m * 23.4m);  // output: 2.34

Console.WriteLine(13 / 5);  // output: 2
Console.WriteLine(-13 / 5);   // output: -2
Console.WriteLine(13 / -5);   // output: -2

Console.WriteLine(-13 / -5);  // output: 2

Console.WriteLine(16.8f / 4.1f);   // output: 4.097561
Console.WriteLine(16.8d / 4.1d);   // output: 4.09756097560976
Console.WriteLine(16.8m / 4.1m);   // output: 4.09756097560975609756097560

Console.WriteLine(5 % 4);   // output: 1
Console.WriteLine(5 % -4);  // output: 1
Console.WriteLine(-5 % 4);  // output: -1
Console.WriteLine(-5 % -4); // output: -1

Console.WriteLine(-5.2f % 2.0f); // output: -1.2
Console.WriteLine(5.9 % 3.1);   // output: 2.8
Console.WriteLine(5.9m % 3.1m);  // output: 2.8

Console.WriteLine(5 + 4);       // output: 9
Console.WriteLine(5 + 4.3);     // output: 9.3
Console.WriteLine(5.1m + 4.2m); // output: 9.3

Console.WriteLine(47 - 3);      // output: 44
Console.WriteLine(5 - 4.3);     // output: 0.7
Console.WriteLine(7.5m - 2.3m); // output: 5.2

int x = 5;
x += 9;
Console.WriteLine(x);  // output: 14

x -= 4;
Console.WriteLine(x);  // output: 10

x *= 2;
Console.WriteLine(x);  // output: 20

x /= 4;
Console.WriteLine(x);  // output: 5

x %= 3;
Console.WriteLine(x);  // output: 2

#endregion

#region Example 4 - Bitwise complement operator ~



#endregion