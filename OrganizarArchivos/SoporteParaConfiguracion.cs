using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Helpers
{
    class SoporteParaConfiguracion
    {

        public static void CrearArchivoDeConfiguracion(string Ruta)
        {
            BinaryWriter writer = new BinaryWriter(File.Open(Ruta + @"\destino.dat",FileMode.OpenOrCreate));
            writer.Write(Ruta);
            writer.Close();
        }


        public static string LeerConfiguracion(string Ruta)
        {

            BinaryReader reader = new BinaryReader(File.OpenRead(Ruta + @"\destino.dat"));
            string leido = reader.ReadString();
            return leido;
        }

    }
}
