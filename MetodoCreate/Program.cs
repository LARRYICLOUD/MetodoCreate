using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodoCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES EXCELENTE Y RECONOCIDO");

            //Creamos un objeto FileStream
            //FileStream fs;
            //************************************************************

            //Creamos un archivo
           FileStream fs = File.Create("Archivo con File.txt");
            //Codificamos una cadena para escrbirla en el archivo
            byte[] bufer = Encoding.UTF8.GetBytes("Prueba de texto nueva");

            //Escribimos en el archivo
            fs.Write(bufer, 0, (int)bufer.Length);
     

            //Cerramos el flujo de Create
            fs.Close();
            //Escribimos/anexamos texto a nuestro archivo
            File.AppendAllText("Archivo con file.txt", "Texto anexado by LARRYSALSA");
           

        }
    }
}
