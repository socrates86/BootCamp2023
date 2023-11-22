namespace Example4;

class Program
{
    static void Main(string[] args)
    {
        long firstNumber = 2000;
        long secondNumber = 4000;

        long add = Add(firstNumber, secondNumber);
        long difference = Substract(firstNumber, secondNumber);
        long product = Product(firstNumber, secondNumber);
        float division = Division(firstNumber, secondNumber);

        Console.WriteLine($"The sum of a and b { add }");
        Console.WriteLine($"The difference of a and b { difference }");
        Console.WriteLine($"The production of a and b { product }");
        Console.WriteLine($"The division of a and b { division }");
    }

    private static long Add(long a, long b) 
    {
        long sum = a + b;
        return sum;
    }

    private static long Substract(long a, long b) 
    {
        long difference = a - b;
        return difference;
    }

    private static long Product(long a, long b) 
    {
        long product = a * b;
        return product;
    }
    
    private static float Division(long a, long b) 
    {
        float division = a / b;
        return division;
    }

    private static long Modulo(long a, long b) 
    {
        long modulo = a % b;
        return modulo;
    }
}
