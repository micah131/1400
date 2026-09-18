public class Program
{
    public static void GreetStudent(string name)
    {
        Console.WriteLine($"Hello, {name}! Ready to write some C#?");
    }
    public static void Printbanner()
    {
        Console.WriteLine("************************");
        Console.WriteLine("WELCOME TO CS 1400");
        Console.WriteLine("************************");
    }
    public static void Main(string[] args)
    {
        double celsius = FahrenheitToCelsius(98.6);
        Console.WriteLine($"98.6°F is equal to {celsius}°C");
        Printbanner();
        GreetStudent("Micah");
        double result = Square(6);
        Console.WriteLine($"The square of 6 is {result}");
        bool isEven = IsEven(6);
        Console.WriteLine($"Is 6 even? {isEven}");


// Console Output:
// Hello, Micah! Ready to write some C#?
// The square of 6 is 36
// Is 6 even? True
    }
    public static double Square(double x)
    {
        return x * x;
    }
    public static bool IsEven(double number)
    {
        if (number % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public static double FahrenheitToCelsius(double fahrenheit)
    {
        double celsius = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"98.6°F is equal to {celsius}°C");
        return celsius;
        
    }
}


