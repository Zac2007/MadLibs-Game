using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Start
{
    class Program
    {
        static void Main(string[] args)

            
        {
        // MadLibs game

            string colour, pluralNoun, celebrity;

            Console.Write("Emter a colour: ");
            colour = Console.ReadLine();
            Console.Write("Emter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Emter a celebrity name: ");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses are " + colour);
            Console.WriteLine(pluralNoun + " are blue");
            Console.WriteLine("I love " + celebrity);

        }
    }
}
