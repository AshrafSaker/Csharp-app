// See https://aka.ms/new-console-template for more information

using System; // The first line of the code defines the System namespace with the using

public class Program {  // name of program
    public static void Main(string[] args) // Main is cover to program
    {  
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hi there !");
        // String

        string myname = "Ashraf Saker";
        Console.WriteLine(myname);

        //math
        int a = 5;
        int b = 8;
        int c = a+b;
        Console.WriteLine(c);

        int sec = 1;
        int min = 60 * sec;
        int hour = 60 * min;
        int day = 24 * hour;
        int month = 30 * day;

        Console.WriteLine(month);
    }


}

