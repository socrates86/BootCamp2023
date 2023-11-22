namespace Example2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the Principal?");
        string? Principal = Console.ReadLine();
        double? principal = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("What is the Rate?");
        string? Rate = Console.ReadLine();
        double? rate = Convert.ToDouble(Rate);

        Console.WriteLine("What is the Time?");
        string? Time = Console.ReadLine();
        int time = Convert.ToInt16(Time);

        double? simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"simpleInterest is  {simpleInterest}");
    }
}
