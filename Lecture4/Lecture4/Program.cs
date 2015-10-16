using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPlayerName;
            Console.WriteLine("Enter Player Name");
            myPlayerName = Console.ReadLine();
            Console.WriteLine("Welcome {0}, to our game", myPlayerName);
            Console.Read();
        }
    }
}
