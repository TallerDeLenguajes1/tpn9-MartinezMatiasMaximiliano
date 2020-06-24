using System;
using System.Linq;
using Helpers;
using System.IO;

namespace Morse
{
    class Program
    {
        static void Main(string[] args)
        {
        //    string TextoLeido = Console.ReadLine();

        //    string result = ConversorDeMorse.TextoAMorse(TextoLeido);
        //    Console.WriteLine(result);


        string MorseLeido = Console.ReadLine();
        string result = ConversorDeMorse.MorseATexto(MorseLeido);
        }
    }
}
