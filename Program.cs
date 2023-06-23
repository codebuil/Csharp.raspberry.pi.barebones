using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace screens
{
    internal class Program
    {

        
        static void Main(string[] args)

        {
           string memory = "hello world...\n";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
			Console.Write(memory);
           

            Console.ReadLine();

        }
    }
}
