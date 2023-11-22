namespace Example3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first value");
        long a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second value");
        int b = Convert.ToInt32(Console.ReadLine());

        long addition = a + b;
        long subtraction = a - b;
        long multiplication = a * b;
        double division = a / b;
        int modulo = (int)(a % b);

        Console.WriteLine($"The sum of a & b is {addition}");
        Console.WriteLine($"The difference of a & b is {subtraction}");
        Console.WriteLine($"The product of a & b is {multiplication}");
        Console.WriteLine($"The qoutient of a & b is {division}");
        Console.WriteLine($"The modulus of a & b is {modulo}");
    }
}
