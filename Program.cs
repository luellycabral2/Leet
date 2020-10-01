using System;

namespace leet
{
    class Program
    {
        static void Main(string[] args)
        {
            string tradutor ;

            //<--- inicio (digite)--->//
            Console.Write(" digite algo do seu interese: ");
            tradutor = Console.ReadLine();
            //<---fim (digite)--->//

            //<---inicio(tradutor)--->//
            Console.WriteLine(tradutor
            .Replace("A"  , "4")
            .Replace("a" , "4")

            
            .Replace("E" , "3")
            .Replace("e" , "3")
            
            .Replace("I" , "1")
            .Replace("i" , "1")
            .Replace("L" , "1")
            .Replace("l" , "1")

            .Replace("O" , "0")
            .Replace("o" , "0")

            .Replace("T" , "7")
            .Replace("t" , "7")

            .Replace("S" , " 5")
            .Replace("s" , "5" ));
            //<---fim (tradutor)--->//
            
            //<---inicio(sair)--->//
            Console.WriteLine("ConsoleSpecialKey na tecla ENTER para sair");
            Console.ReadKey();
            //<---fim(sair)--->//


        }
    }
}
