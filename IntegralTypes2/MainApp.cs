// See https://aka.ms/new-console-template for more information

class MainApp
{
    public static void Main(string[] args)
    {
        uint a = uint.MaxValue; // uint의 최대값, 4294967295
        Console.WriteLine(a);

        a = a + 1;
        Console.WriteLine(a);
    }
}