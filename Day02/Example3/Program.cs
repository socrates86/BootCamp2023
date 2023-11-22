namespace Example3;

class Program
{
    static void Main(string[] args)
    {
        int time;
        float rate;
        double principal;
        double simpleInterest;

        time = 2;
        rate = 15.20F;
        principal = 2000300.0;

        simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("S. I. is " + simpleInterest);
        Console.WriteLine($"S. I. is  {simpleInterest}");  
    }
}
