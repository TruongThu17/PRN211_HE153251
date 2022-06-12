using System;
using System.IO;
using System.Text;

namespace Slot12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //write
            Console.WriteLine("**** Demo FileStream Class****");
            using FileStream f = File.Open("MyFile.dat", FileMode.Create);
            string msg = "ACDEFG";
            byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
            f.Write(msgAsByteArray, 0, msgAsByteArray.Length);
            f.Position = 0;
            //read
            Console.WriteLine("print message as an array of bytes: ");
            byte[] bytesFromFile = new byte[msgAsByteArray.Length];
            for (int i = 0; i < msgAsByteArray.Length; i++)
            {
                bytesFromFile[i] = (byte) f.ReadByte();
                Console.WriteLine($"{bytesFromFile[i],5}");
            }
            //display decoded message
            Console.WriteLine("Decoded Message: ");
            Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
            Console.ReadLine();
        }
    }
}
