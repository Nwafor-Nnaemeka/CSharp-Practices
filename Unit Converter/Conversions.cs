using Name;

namespace UnitConversion;

public class Conversion
{
   public static void Length()
   {
        Console.WriteLine("\nSelect from the following list of Operations\n");
        string[] operations = {"millimeters to centimeters", "centimeters to meters", "millimeters to meters"};
        for (int i = 0; i < operations.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {operations[i]}");
        }

        while(true)
        {
            Console.Write("\nEnter you conversion option: ");
            string input = Console.ReadLine();

            decimal num = 0;
            decimal input2 = 0;

            void Input2()
            {
                Console.Write("\nEnter the number: ");
                input2 = Convert.ToDecimal(Console.ReadLine());
            }

            if (input == "1")
            {
                Input2();
                num = input2 / 10m;
                Console.WriteLine($"\n{input2} mm is equal to {num} cm");

                Repeat();
            }
            else if (input == "2")
            {
                Input2();
                num = input2 / 100m;
                Console.WriteLine($"\n{input2} cm is equal to {num} m");
                Repeat();
            }
            else if (input == "3")
            {
                Input2();
                num = input2 / 1000m;
                Console.WriteLine($"\n{input2} mm is equal to {num} m");
                Repeat();
            }
            else 
                Console.WriteLine("Enter a valid option pls.");
        }  
   }

    public static void Repeat()
    {
        Console.Write("\nDo you want to continue (Y/N):");
        string answer = Console.ReadLine();
            
        if (answer.ToLower() == "yes"|| answer.ToLower() == "y")
            Length();
        else
            Operations.Operation();    
        }      

   public static void Temperature()
   {
        Console.WriteLine("\nSelect from the following list of Operations\n");
        string[] operations = {"Fahrenheit to Celcuis", "Celcuis to Fahrenheit", "Celcuis to Kelvin"};
        for (int i = 0; i < operations.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {operations[i]}");
        }

        while(true)
        {
            Console.Write("\nEnter your option: ");
            string option = Console.ReadLine();

            decimal num = 0;
            decimal input = 0;

            void Temperature()
            {
                Console.Write("\nEnter the temperature to convert: ");
                input = Convert.ToDecimal(Console.ReadLine());
            }

            if (option == "1")
            {
                Temperature();
                num = (input - 32) * (5 / 9m);
                Console.WriteLine($"\n{input} F is equal to {num} C");
                Repeat();
            }
            else if (option == "2")
            {
                Temperature();
                num = ((input * 9) + 160) / 5m;
                Console.WriteLine($"\n{input} C is equal to {num} F");
                Repeat();
            }
            else if (option == "3")
            {
                Temperature();
                num = input + 273m;
                Console.WriteLine($"\n{input} C is equal to {num} K");
                Repeat();
            }
            else 
                Console.WriteLine("Enter a valid option");
        }
   }
}