// See https://aka.ms/new-console-template for more information

using static System.Console;

namespace HelloWorld
{
    class HelloWorld
    {
        // 프로그램이 실행이 시작되는 곳
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : HelloWorld.exe <이름>");
                return;
            }

            WriteLine("Hello, {0}!", args[0]);
            // {0} {1} 이런식으로 한개씩 늘릴수있네여. 이건 자바랑 비슷 쓰는 문자열은 다르지만
            // args[0] args[1] 이런식으로 순서대로 들어갈 수 있게 해주면 되네여!
        }
    }
}