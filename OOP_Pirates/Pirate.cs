using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pirates
{
    internal class Pirate
    {
        private string name;
        private int intoxicateLevel;
        private bool alive;     //TRUE = alive  FALSE = dead
        private static Random rnd = new Random();

        public Pirate(string name)
        {
            this.name = name;
            this.intoxicateLevel = 0;
            this.alive = true;
        }

        public string Name { get => name; set => name = value; }
        public int IntoxicateLevel { get => intoxicateLevel; set => intoxicateLevel = value; }
        public bool Alive { get => alive; set => alive = value; }

        public void DrinkSomeRum()
        {
            if (!this.alive)
            {
                Console.WriteLine("He's dead.");
            }
            else
            {
                this.intoxicateLevel++;
            }
        }

        public string HowsItGoingMate()
        {
            if (!this.alive)
            {
                return ("He's dead.");
            }
            else if(this.intoxicateLevel < 4)
            {
                return "Pour me anudder!";
            }
            else
            {
                intoxicateLevel = 0;
                return "Arghh, I'ma Pirate. How d'ya d'ink its goin?";
            }
        }

        public void Brawl(Pirate pirate)
        {
            if (!this.alive)
            {
                Console.WriteLine("He's dead.");
            }
            else if(!pirate.alive)
            {
                Console.WriteLine("The other Pirate is dead.");
            }
            else
            {
                int chance = rnd.Next(3);
                switch(chance)
                {
                    case 0:
                        Die();
                        Console.WriteLine("You lose and die.");
                        break;
                    case 1:
                        pirate.alive = false;
                        Console.WriteLine("You win, the other Pirate dies.");
                        break;
                    case 2:
                        Die();
                        pirate.alive = false;
                        Console.WriteLine("You both passed out.");
                        break;
                }
            }
        }

        public void Die()
        {
            if (!this.alive)
            {
                Console.WriteLine("He's dead.");
            }
            else
            {
                this.alive = false;
            }
        }

        public override string ToString()
        {
            if (!this.alive)
            {
                return $"{this.name}'s intoxicate level was {this.IntoxicateLevel} and he's dead.";
            }
            else
            {
                return $"{this.name}'s intoxicate level is {this.IntoxicateLevel} and he's alive.";
            }
        }
    }
}
