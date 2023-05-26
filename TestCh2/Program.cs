// See https://aka.ms/new-console-template for more information

class TestCh2
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("여러분, 안녕하세요?");
            return;
        }

        Console.WriteLine("여러분, 안녕하세요?");
        Console.WriteLine("{0}", args[0]);
    }
}
