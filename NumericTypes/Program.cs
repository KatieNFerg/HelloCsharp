double area;


Console.WriteLine("What is the length of your rectangle?");
string length = Console.ReadLine();
Console.WriteLine("What is the width of your rectangle?");
string width = Console.ReadLine();
int length1 = int.Parse(length);
int width1 = int.Parse(width);
area = length1 * width1;
Console.WriteLine("The area of the rectangle is: " + area);

Console.WriteLine("How many miles did you drive?");
string mi = Console.ReadLine();
int miles = Int32.Parse(mi);
Console.WriteLine("How many gallons of gas did you use?");
string gas = Console.ReadLine();
int gas2 = Int32.Parse(gas);
int mpg = miles/gas2;
Console.WriteLine("The MPG for the trip was: " + mpg);

