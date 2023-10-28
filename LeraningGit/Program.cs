// See https://aka.ms/new-console-template for more information

public class Numbers
{
    private int a, b;

    public void SetNumbers(int newA, int newB)
    {
        a = newA;
        b = newB;
    }

    public int Sum()
    {
        return a + b;
    }
}

public class Program
{
    public static void Main()
    {
        var n1 = new Numbers();
        
        n1.SetNumbers(3, 5);
        n1.Sum();
        
        Console.WriteLine("Your sum is " + n1.Sum());
    }
}