// See https://aka.ms/new-console-template for more information

class MainApp
{
    static void Main(string[] args)
    {
        int a = int.MaxValue;
        var b = int.MaxValue;

        Console.WriteLine(a);
        Console.WriteLine(b);

        a = a + 1;
        b = b + 1;

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}