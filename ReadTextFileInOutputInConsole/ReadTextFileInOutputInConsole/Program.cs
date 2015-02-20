using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadTextFileInOutputInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("TextFile.txt");
                
                
                
                    String textLine = sr.ReadToEnd();
                    Console.WriteLine(textLine);
                
            }
            catch (Exception e)
            {
                
                Console.WriteLine("The file could not found");
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();

        }
    }
}
