using System;
class MyProgram
{
    public static void GetName()
    {
        Console.WriteLine("Hello, what is your name?");
        string myname = Console.ReadLine();
        if (myname == "cole")
        {
            Console.WriteLine("That's me!");
        }
        else
        {
            Console.WriteLine($"Hello,{myname}!");
        }
    }
    public static void GetAge()
    {
        Console.WriteLine("What is your age?");
        string age = Console.ReadLine();
        int numAge = Convert.ToInt32(age);
        if (numAge < 18)
        {
            Console.WriteLine($"Your {age} years young!");
        }
        else
        {
            Console.WriteLine($"Your {age} years not young!");
        }
    }
    public static void Main()
    {
        GetName();
        GetAge();
        Console.ReadKey();
    }
}
