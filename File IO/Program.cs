using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FileIO
{
    class Program
    {
        static void Main(string [] args)
        {
            //- First Method File.Exists()

            //string path = @"d:\Example.txt";
            //if (File.Exists(path))
            //    Console.WriteLine("File Exists");
            //else
            //    Console.WriteLine("File Doesn't Exist!");

            //Console.ReadKey();

            //- Second Method ReadAllLines()
            //string path = @"d:\Example.txt";
            //string[] lines;
            //lines = File.ReadAllLines(path);

            ///*
            //Console.WriteLine(lines[0]);
            //Console.WriteLine(lines[1]);
            //*/


            //foreach (string line in lines)
            //{
            //    Console.WriteLine(line);
            //}

            //Console.ReadKey();


            //- Third Method ReadAllText()
            //string path = @"D:\Example.txt";
            //string lines;
            //lines = File.ReadAllText(path);
            //Console.WriteLine(lines);

            //Console.ReadKey();

            //- Forth Method File.Copy

            //string path = @"D:\Example.txt";                                //Source File
            //string copyOfPath = @"D:\newExample.txt";                       //Destination File
            //File.Copy(path, copyOfPath);                                    //Creating the copy using File copy command
            //Console.ReadKey();

            //- Fifth Method File.Delete                     
            // Note ---> using this method is never recommended but if you do so make sure you delete the copies of the file only.

            string path = @"D:\newExample.txt";
            File.Delete(path);

            Console.ReadKey();
        }
    }
}
