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


            string TextoInser = Console.ReadLine(); // ... --- ... / 


            ConversorDeMorse.CrearArchivoTAM(TextoInser);
        
        //string result = ConversorDeMorse.MorseATexto(MorseLeido);
        //   result = result.ToUpper();
        //    Console.WriteLine(result);
        }
    }
}
