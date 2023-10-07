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
            Ship ship3 = new Ship("Emperial");
            Ship ship4 = new Ship("Queen");
            Ship ship5 = new Ship("Dark Soul");
            Ship ship6 = new Ship("Lost King");
            Ship ship7 = new Ship("Golden Fish");
            ship1.FillShip("Captain Jack");
            ship2.FillShip("Captain John");
            ship3.FillShip("Captain Diego");
            ship4.FillShip("Captain Herold");
            ship5.FillShip("Captain Dark");
            ship6.FillShip("Captain Arthur");
            ship7.FillShip("Cpatain Nemo");

            //battle
            /*
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
            */

            //create armadas
            Armada armada1 = new Armada("Captain Jack's Armada");
            Armada armada2 = new Armada("Royale Armada");
            armada1.AddShip(ship1);
            armada1.AddShip(ship5);
            armada1.AddShip(ship7);

            armada2.AddShip(ship2);
            armada2.AddShip(ship3);
            armada2.AddShip(ship4);
            armada2.AddShip(ship6);
            Console.WriteLine(armada1);
            Console.WriteLine(armada2);

            Console.WriteLine("--------------------------------------------After an armada war--------------------------------------------");
            if (armada1.ArmadaWar(armada2))
            {
                Console.WriteLine(armada1.Name + " is the winner.");
            }
            else
            {
                Console.WriteLine(armada2.Name + " is the winner.");
            }
            Console.WriteLine(armada1);
            Console.WriteLine(armada2);
            Console.ReadKey();
        }
    }
}
