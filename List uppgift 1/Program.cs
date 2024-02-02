using System;
using System.Collections.Generic; 

class Program
{
    static void Main(string[] args)
    {
        List<string> lista = new List<string>();

        Console.WriteLine("Nu ska du skriva in namn");
        string namn = "empty";


        while (namn != "")
        {
            Console.WriteLine("Skriv in ett namn");
            namn = Console.ReadLine();
            if (namn != "")
            {
                lista.Add(namn);
            }
        }

        Console.WriteLine("Här är de namn du skrev fast bakänges");
        lista.Reverse();

        foreach (string s in lista)
        {
            Console.WriteLine(s);
        }

        Console.ReadKey();
    }
}
