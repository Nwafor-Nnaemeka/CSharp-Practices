using System;

class Methods
{
    static void Main()
    {
        Exercise6.SwapNumbers();
        Exercise5.SumOfArray();
        Exercise4.SubSpace();
        Exercise3.SumOfTwoNumbers();
        Exercise2.WelcomeUser();
        Exercise1.Welcome();
    }

// Welcome Friends  
    class Exercise1
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");
        }
    }

//Welcome User
    class Exercise2
    {
        public static void WelcomeUser()
        {
            Console.Write("Please enter your name: ");
            string str1 = Console.ReadLine();
            Console.WriteLine($"Welcome friend, {str1}");
            Console.WriteLine($"Have a nice day!");
            Console.ReadLine();
        }
    }

// Sum of Two Numbers
    class Exercise3
    {
        public static int SumOfTwoNumbers()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int total = num1 + num2;
            Console.WriteLine($"The sum of the numbers are: {total}");
            Console.ReadLine();
            return total;    
        }
    }

    // Number of Spaces Between Words
   class Exercise4
   {
        public static int Spaces(string str2)
        {
            int space = 0;
            string  str3;

            for (int i = 0; i < str2.Length; i++)
            {
                str3 = str2.Substring(i, 1);
                if (str3 == " ")
                    space++;
            }
            return space;
           
        }
        public static void SubSpace()
        {
            string str2;
            Console.Write("Pls input a string: ");
            str2 = Console.ReadLine();

            Console.WriteLine($"{str2}; has {Spaces(str2)} spaces");
            Console.ReadLine();
        }
   }

   // Calculate the Sum of Numbers in Array
   class Exercise5
   {
        public static int SumOfArray()
        {
            int sum = 0;
            Console.WriteLine("Enter the Integers Please: ");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"Element-{i} : ");
                int num = Convert.ToInt32(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"The sum of the Array is : {sum}");
            Console.ReadLine();
            return sum;
        }
   }

    // Swap two intergers
    class Exercise6
    {
        public static void SwapNumbers()
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Now the 1st is :{num2} and the 2nd is: {num1}");
            Console.ReadLine();
        }
    }

}
