using UnitConversion;
namespace Name;

public class Operations
{
    public static void Operation()
    {
        Console.WriteLine("\nOperation to perform:\n");

        string[] operations = {"Length","Temperature", "Time", "Weight"};

        for (int i = 0; i < operations.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {operations[i]}");
        }

        while(true)
        {
            Console.Write("\nSelect the Operation to perform: ");
            string input = Console.ReadLine();

            if (input == "1")
                Conversion.Length();   

            else if (input == "2")
                Conversion.Temperature();

            else    
                Console.WriteLine("Enter a valid option");
        }
    }
    static void Main(string[] args)
    {
        Operation();
    }

}

