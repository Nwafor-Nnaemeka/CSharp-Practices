using System.Xml.Schema;

void pause(){Console.ReadLine();}
// 13. Factorial of a given number

int factorial, total = 1;
Console.Write("Enter the number: ");
factorial = Convert.ToInt32(Console.ReadLine());

for (int i = factorial; i >= 1; i--)
{
    total *= i;
}
Console.WriteLine($"the factorial of {factorial} is : {total}");
pause();




//  12. Pyramid with Asterix
int row3, spc2 = 0;

Console.Write("Enter the number of asterix: ");
row3 = Convert.ToInt32(Console.ReadLine());

spc2 = row3 + 5;

for (int i = 1; i <= row3; i++)
{
    for (int spacing = spc2; spacing >= 1; spacing--)
        Console.Write(" ");
    
    for (int j  = 1; j <= i; j++)
        Console.Write("* ");

    Console.Write("\n");
    spc2--;
}
pause();



// 11. Pyramid With Numbers
int spc = 0, rows, t = 1;
Console.Write("Enter the Number: ");
rows = Convert.ToInt32(Console.ReadLine());

spc = rows + 4;

for (int i = 1; i <= rows; i++)
{
    for (int r = spc; r >= 1; r--)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i; j++)
        Console.Write($"{t++} ");

    Console.Write("\n");
    spc--;
}
pause();



// 10. Right Angle Triangle With Numbers
int row2;
int k = 1;
Console.Write("Enter the number you want: ");
row2 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= row2; i++)
{
    for (int j = 1; j <= i; j++)
        Console.Write($"{k++}");

    Console.Write("\n");

}
pause();



// 9. Right Angle Triangle with Asterix
int row;
Console.Write("Enter the number of rows: ");
row = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= row; i++)
{
    for (int j = 1; j <= i; j++)
            Console.Write("*");
        
    Console.Write("\n");
}

pause();




// 8. Display the n terms of Odd numbers and their sum
int oddNumber = 0;
int ii = 0;

Console.Write("Enter the number of terms: ");
oddNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("The odd numbers are: ");

for (int i = 1; i <= oddNumber; i++)
{
    Console.Write($"{2 * i -1} ");
    ii += 2 * i -1;
}
Console.WriteLine($"\nThe sum of the Odd numbers is: {ii}");
pause();




// 7. Display Multiplication Tables Vertically from 1 to n.
int multi2 = 0;
Console.Write("Enter an integer: ");
multi2 = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j <= multi2; j++)
    {
        if (j <= multi2 -1)
        {
             Console.Write($"{j} x {i} = {j * i},");
        }
        else
            Console.Write($"{j} x {i} = {j * i}");
    }
    Console.Write("\n");
}
pause();





// 6. Multiplication Table of an Integer
int multi = 0;
Console.Write("Enter the integer: ");
multi = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"{multi} x {i} = {multi * i}");
}
pause();



// 5. The Cube up to the given integer
int cube = 0;
Console.Write("Enter the integer: ");
cube = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= cube; i++)
{
    Console.WriteLine($"Number is :{i} and the cube is: {i*i*i}");
}

pause();



//4. Find the sum and Average of Ten Numbers
int a;
int sum = 0;
decimal avg = 0;

Console.WriteLine("Enter the Ten Numbers: ");
for (int i = 0; i < 10; i++)
{
    Console.Write($"Number-{i}:");
    a = Convert.ToInt32(Console.ReadLine());
    sum += a;
}
avg = sum / 10m;
Console.WriteLine($"The sum of the numbers are: {sum}");
Console.WriteLine($"The average of the numbers are: {avg}");



pause();



//3. Display the sum of n Natural Number
int n;
int num2 = 0;

Console.Write("Enter the number you want between 1- 1000: ");
n = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
        num2 += i;
}
Console.WriteLine($"The total is: {num2}");
pause();



//2. Sum of first 10 Natural Numbers
int num = 0;
for (int i = 0; i <= 10; i++)
{
    num += i;
}
Console.WriteLine($"{num}");
pause();



// 1. To display the first 10 natural Numbers
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i}");
}