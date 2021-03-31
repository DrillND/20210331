using System;

namespace ConsoleApp3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("숫자를 입력해주세요 : ");
                string input = Console.ReadLine();
                int changeinput = 50000;

                try
                {
                    changeinput = int.Parse(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    return;
                }
                finally
                {
                    Console.WriteLine(changeinput);
                }
            }
        }

    }
}
