public class A
{
    private int _value = 10;

    public class B : A
    {
        public int GetValue()
        {
            return _value;
        }
    }
}

// public class C : A
// {
//     public int GetValue();
//     {
//         return _value;
//     }
// }

public class AccessExample
{
    public static void Main(string[] args)
    {
        var b = new A.B();
        Console.WriteLine(b.GetValue());

        // Public members
        B2 b2 = new B2();
        b2.Method1();
    }
}

public class A2
{
    public void Method1()
    {
        // Method Implementation
    }
}

public class B2 : A2
{ }