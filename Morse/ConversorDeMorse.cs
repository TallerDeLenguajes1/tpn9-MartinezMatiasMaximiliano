using System;
using System.Collections.Generic;
using System.IO;
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


        public static string MorseATexto(string FraseMorse)
        {
            string Texto = "";
            string[] Letras = FraseMorse.Split(' ');
            foreach (string item in Letras)
            {
                switch (item)
                {
                    case ".-":
                        Texto += 'a';
                        break;
                    case "-...":
                        Texto += 'b';
                        break;
                    case "-.-.":
                        Texto += 'c';
                        break;
                    case "-..":
                        Texto += 'd';
                        break;
                    case ".":
                        Texto += 'e';
                        break;
                    case "..-.":
                        Texto += 'f';
                        break;
                    case "--.":
                        Texto += 'g';
                        break;
                    case "....":
                        Texto += 'h';
                        break;
                    case "..":
                        Texto += 'i';
                        break;
                    case ".---":
                        Texto += 'j';
                        break;
                    case "-.-":
                        Texto += 'k';
                        break;
                    case ".-..":
                        Texto += 'l';
                        break;
                    case "--":
                        Texto += 'm';
                        break;
                    case "-.":
                        Texto += 'n';
                        break;
                    case "---":
                        Texto += 'o';
                        break;
                    case ".--.":
                        Texto += 'p';
                        break;
                    case "--.-":
                        Texto += 'q';
                        break;
                    case ".-.":
                        Texto += 'r';
                        break;
                    case "...":
                        Texto += 's';
                        break;
                    case "-":
                        Texto += 't';
                        break;
                    case "..-":
                        Texto += 'u';
                        break;
                    case "...-":
                        Texto += 'v';
                        break;
                    case ".--":
                        Texto += 'w';
                        break;
                    case "-..-":
                        Texto += 'x';
                        break;
                    case "-.--":
                        Texto += 'y';
                        break;
                    case "--..":
                        Texto += 'z';
                        break;
                    case ".----":
                        Texto += '1';
                        break;
                    case "..---":
                        Texto += '2';
                        break;
                    case "...--":
                        Texto += '3';
                        break;
                    case "....-":
                        Texto += '4';
                        break;
                    case ".....":
                        Texto += '5';
                        break;
                    case "-....":
                        Texto += '6';
                        break;
                    case "--...":
                        Texto += '7';
                        break;
                    case "---..":
                        Texto += '8';
                        break;
                    case "----.":
                        Texto += '9';
                        break;
                    case "-----":
                        Texto += '0';
                        break;
                    case "/":
                        Texto += ' ';
                        break;
                    default:
                        break;
                }
            }
            return Texto;
        }



        public static void CrearArchivoTAM(string textoT)
        {
            string textoM = TextoAMorse(textoT);
            string fecha = DateTime.Now.ToString("MM-dd-yyyy HH,mm,ss");
            string nombre = ($"{textoT}_[{fecha}].txt");
            string DireMorse = @"C:\Repogit\tpn9-MartinezMatiasMaximiliano\Morse\Morse\";


            if (!Directory.Exists(DireMorse))
            {
                Directory.CreateDirectory(DireMorse);
                StreamWriter writer = new StreamWriter(File.Open(DireMorse + nombre,FileMode.OpenOrCreate));
                writer.Write(textoM);
                writer.Close();

            }
            else
            {
                StreamWriter writer = new StreamWriter(File.Open(DireMorse + nombre, FileMode.Create));
                writer.Write($"{textoM}");
                writer.Close();

            }
        }

        public static string LeerArchivo(string Archivo)
        {
            string Directorio = @"C:\Repogit\tpn9-MartinezMatiasMaximiliano\Morse\Morse\";
            string[] archivosEnDirectorio = Directory.GetFiles(Directorio);
            string nombreArchivo= "";
            foreach (string item in archivosEnDirectorio)
            {
                if (item.Contains(Archivo))
                {
                    string[] nombre = item.Split(@"\");
                    nombreArchivo = nombre[nombre.Length - 1];
                }
            }
            
            
            

            StreamReader reader = new StreamReader(File.Open($"{Directorio}\\{nombreArchivo}", FileMode.Open));
            string TextoLeido = reader.ReadLine();
            reader.Close();

            return TextoLeido ;
        }

    }
}
