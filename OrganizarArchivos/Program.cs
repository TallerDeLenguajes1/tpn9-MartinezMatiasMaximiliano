using Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OrganizarArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string Ruta = (@"C:\Repogit\tpn9-MartinezMatiasMaximiliano\OrganizarArchivos");
            string Receptora;

            if (!Directory.Exists(Ruta + @"\movidos"))  //crear carpeta receptora e insertar destino.dat
            {
                Directory.CreateDirectory(Ruta + @"\movidos");
                SoporteParaConfiguracion.CrearArchivoDeConfiguracion(Ruta + @"\movidos");
                Receptora = Ruta + @"\movidos";

            }
            else
            {
                SoporteParaConfiguracion.CrearArchivoDeConfiguracion(Ruta + @"\movidos");
                Receptora = Ruta + @"\movidos";
            }

            string leido = SoporteParaConfiguracion.LeerConfiguracion(Receptora);




           string[] ArregloPath = Directory.GetFiles(@"C:\Repogit\tpn9-MartinezMatiasMaximiliano\OrganizarArchivos\bin\Debug");

            foreach (string item in ArregloPath)
            {
                if (item.Contains(".mp3") || item.Contains(".txt"))
                {
                    string[] Cambio = item.Split(@"\");
                    int longitud = Cambio.Length;
                    Directory.Move(item, (leido + "\\" + Cambio[longitud - 1]));
                    
                }
            }



            //DirectoryInfo prueba = new DirectoryInfo(@"C:\Repogit\tpn9-MartinezMatiasMaximiliano\OrganizarArchivos\bin\Debug");
            //List<string> ArchivosEnDebug = prueba.GetFiles();
            //foreach (string item in ArchivosEnDebug)
            //{
            //    if (item.Contains(".mp3") || item.Contains(".txt")
            //    {
            //        File.Move(item,)
            //    }
            //}


        }
    }
}
