using System;
using System.IO;
namespace DirectoryInfo;
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite putanju direktorija: ");
            string putanja = Console.ReadLine();
            // Instanciramo DirectoryInfo objekt
            DirectoryInfo diIzvor = new DirectoryInfo(putanja);
            // Ispisujemo sve poddirektorije
            Console.WriteLine("\n-- Poddirektoriji:");
            foreach (DirectoryInfo di in diIzvor.GetDirectories())
            {

                //Uvod u objektno - orijentirano programiranje
            
Console.WriteLine("{ 0}\t{ 1}\t{ 2}",
di.Name, di.CreationTime, di.LastAccessTime);

            }
            // Ispisujemo sve datoteke
            Console.WriteLine("\n-- Datoteke:");
            foreach (FileInfo fi in diIzvor.GetFiles())
            {
                Console.WriteLine("{ 0}\t{ 1}\t{ 2}",
fi.Name, fi.CreationTime, fi.LastAccessTime);

            }
            Console.ReadKey();
        }
    }
}
