using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    class ConversorDeMorse
    {
        static Dictionary<char, string> DiccionarioMorse = new Dictionary<char, string>()
        {
            {'A' , ".-"},
            {'B' , "-..."},
            {'C' , "-.-."},
            {'D' , "-.."},
            {'E' , "."},
            {'F' , "..-."},
            {'G' , "--."},
            {'H' , "...."},
            {'I' , ".."},
            {'J' , ".---"},
            {'K' , "-.-"},
            {'L' , ".-.."},
            {'M' , "--"},
            {'N' , "-."},
            {'O' , "---"},
            {'P' , ".--."},
            {'Q' , "--.-"},
            {'R' , ".-."},
            {'S' , "..."},
            {'T' , "-"},
            {'U' , "..-"},
            {'V' , "...-"},
            {'W' , ".--"},
            {'X' , "-..-"},
            {'Y' , "-.--"},
            {'Z' , "--.."},
            {'1',".---"},
            {'2',"..---"},
            {'3',"...--"},
            {'4',"....-"},
            {'5',"....."},
            {'6',"-...."},
            {'7',"--..."},
            {'8',"---.."},
            {'9',"----."},
            {'0',"-----"},

        };
    

        public static string TextoAMorse(string recibido)
        {
            string resultado = "";

            recibido = recibido.ToUpper();
            char[] arreglo = recibido.ToCharArray();

            foreach (char item in arreglo)
            {
                char aux = item;
                if (aux == Convert.ToChar(" "))
                {
                    resultado += "/";
                }else
                {
                    resultado += " " + DiccionarioMorse[item]+ " ";
                }
            }
            
            return resultado;
        }


        public static string MorseATexto(string recibido)
        {
            string resultado = "";
            string[] arreglo = recibido.Split("/");

            foreach (string item in arreglo)
            {
                string[] letra = item.Split(" ");
                foreach (string let in letra)
                {
                    resultado += DiccionarioMorse[let];
                }
            }

            return resultado;
        }

    }
}
