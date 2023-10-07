using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pirates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create ships
            Ship ship1 = new Ship("The Black Pearl");
            Ship ship2 = new Ship("Royale");
            ship1.FillShip("Captain Jack");
            ship2.FillShip("Captain John");
            Console.WriteLine(ship1);
            Console.WriteLine(ship2);

            //battle
            Console.WriteLine("--------------------------------------------After a battle--------------------------------------------");
            if (ship1.Battle(ship2))
            {
                Console.WriteLine(ship1.Name + " is the winner.");
            }
            else
            {
                Console.WriteLine(ship2.Name + " is the winner.");
            }
            Console.WriteLine(ship1);
            Console.WriteLine(ship2);
            Console.ReadKey();
        }
    }
}
