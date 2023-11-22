namespace Example1;

class Program
{
    static void Main(string[] args)
    {
        double principal = 2000.0;
        double rate = 12.4;
        int time = 3;

        double simpleInterest = 
        (principal * rate * time) / 100;

        Console.WriteLine($"Simple interest is {simpleInterest}");
    }
}

    
