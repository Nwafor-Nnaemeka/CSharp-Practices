//10. Menu-driven Program For simple Calculation
int int1, int2;

string[] calcOptions = {"Addition", "Subtraction", "Multiplication", "Division", "Exit"};

Console.Write("Enter the first integer: ");
int1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second integer: ");
int2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nHere are the following options:\n ");

for (int i = 0; i < calcOptions.Length; i++)
    Console.WriteLine($"{i + 1}. {calcOptions[i]}");

int userChoice = 0;
bool validChoice = false;

while (!validChoice)
{
    Console.Write("Select an option: ");
    userChoice = Convert.ToInt32(Console.ReadLine());

    if (userChoice >= 1 && userChoice <= calcOptions.Length)
        validChoice = true;

    else
        Console.WriteLine("Invalid Option, Enter a valid option");
}

if (userChoice == 1)
   {
        int add = int1 + int2;
        Console.WriteLine($"The {calcOptions[0]} of {int1} and {int2} is: {add}");
   } 
   else if (userChoice == 2)
   {
        int sub;
        if (int1 > int2)
            sub = int1 - int2;

        else
            sub = int2 - int1;

        Console.WriteLine($"The {calcOptions[1]} of {int1} and {int2} is: {sub}");
   }     
    else if (userChoice ==3)
    {
        int multi = int1 * int2;
        Console.WriteLine($"The {calcOptions[2]} of {int1} and {int2} is: {multi}");
    }
    else if (userChoice == 4)
    {
        int div = int1 / int2;
        Console.WriteLine($"The {calcOptions[3]} of {int1} and {int2} is: {div}");
    }
    else if (userChoice == 5)
        Console.Clear();
    


Console.ReadLine();



//9. Location of a Coordinate
int x, y;
Console.Write("Enter the value for X: ");
x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the value for Y: ");
y = Convert.ToInt32(Console.ReadLine());

if (x == 0 && y == 0)
     Console.WriteLine($"The coordinate point ({x},{y}) is at the origin.");

else if (x >= 0 && y >= 0)
    Console.WriteLine($"The coordinate point ({x},{y}) is in the first quadrant.");

else if (x <= 0 && y >= 0)
    Console.WriteLine($"The coordinate point ({x},{y}) is in the second quadrant.");

else if (x <= 0 && y <= 0)
    Console.WriteLine($"The coordinate point ({x},{y}) is in the third quadrant.");

 else if (x >= 0 && y <= 0)
    Console.WriteLine($"The coordinate point ({x},{y}) is in the fourth quadrant.");

Console.ReadLine();




//8. Find the largest of three numbers
int a,b,c;
Console.WriteLine("Finding the highest of three numbers\n");
Console.Write("Enter the first number: ");
a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
b = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third number: ");
c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
    Console.WriteLine($"The First Number, {a} is the greatest");
else if (b > a && b > c)
    Console.WriteLine($"The Second Number, {b} is the greatest");
else    
    Console.WriteLine($"The Third Number, {c} is the greatest");

Console.ReadLine();




//7. To Evaluate the Height of a Person
float height;
Console.Write("Enter your height in cm: ");
height = Convert.ToInt32(Console.ReadLine
());

if (height >= 190.0)
    Console.WriteLine($"This is a tall man");

else if (height <= 189.0 && height >= 160.0)
    Console.WriteLine($"This is an average height person");

else if (height <= 159.0 && height >=140.0)
    Console.WriteLine("this is a short man");

else 
    Console.WriteLine("The person is a dwarf");

Console.ReadLine();




//6. Read the value of an Integer and display the Value of another
int m, n;
Console.Write("Enter the Integer: ");
m = Convert.ToInt32(Console.ReadLine());

if (m > 0)
    n = 1;

else if (m == 0)
    n = 0;

else
    n = -1;

Console.WriteLine($"The value for m is: {m}");
Console.WriteLine($"The value for n is: {n}");

Console.ReadLine();




//5. Legible For Voting
int age;
Console.Write("Enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

if (age <= 17)
{
    Console.WriteLine($"Your age is {age}: You are not eligible to vote");
}
else
{
    Console.WriteLine($"Your age is {age}: You are eligible to vote");
}

Console.ReadLine();




//4. Check if a Given Year is a Leap Year
int year;
Console.Write("Enter the year: ");
year = Convert.ToInt32(Console.ReadLine());

if (year % 4 == 0)
{
    Console.WriteLine($"{year} is a leap year");
}
else
{
    Console.WriteLine($"{year} is not a leap year");
}


Console.ReadLine();




//3. Check Whether a Number is Positive or Negative
int num3;
Console.Write("Enter the number: ");
num3 = Convert.ToInt32(Console.ReadLine());

if (num3 < 0)
{
    Console.WriteLine($"{num3} is a negative number");
}
else
{
    Console.WriteLine($"{num3} is a positive number");
}

Console.ReadLine();




// 2. To Check Whether a Number is Odd or Even
int num;
Console.Write("Enter the number: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} is an even number");
}
else
{
    Console.WriteLine($"{num} is an odd number");
}

Console.ReadLine();





// 1. Check if whether two intergers are equal

int value1 = 0;
int value2 = 0;

Console.Write("Enter the first value: ");
value1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second value: ");
value2 = Convert.ToInt32(Console.ReadLine());

if (value1 == value2)
{
    Console.WriteLine($"{value1} and {value2} are equal");
}
else
{
    Console.WriteLine($"{value1} and {value2} are not equal");
}