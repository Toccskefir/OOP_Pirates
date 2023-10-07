using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pirates
{
    internal class Ship
    {
        private string name;
        private List<Pirate> crew;
        private Captain captain;
        private static Random rnd = new Random();

        public Ship(string name)
        {
            this.name = name;
            this.crew = new List<Pirate>();
        }

        internal List<Pirate> Crew { get => crew;}
        public string Name { get => name; set => name = value; }
        internal Captain Captain { get => captain; set => captain = value; }

        public void FillShip(string captainName)
        {
            this.captain = new Captain(captainName);
            int numberOfPirates = rnd.Next(114);
            for (int i = 0; i < numberOfPirates; i++)
            {
                Pirate p = new Pirate("Pirate#" + (i + 1));
                this.crew.Add(p);
            }
        }

        public int AlivePirates()
        {
            int sum = 0;
            foreach (Pirate item in this.crew)
            {
                if (item.Alive)
                {
                    sum++;
                }
            }
            return sum;
        }

        public int CalculatedScore()
        {
            return AlivePirates() - this.captain.IntoxicateLevel;
        }

        public void Losses()
        {
            foreach (Pirate item in this.crew)
            {
                int random = rnd.Next(2);
                if (random == 0)
                {
                    item.Die();
                }
            }
        }

        public void Party()
        {
            int drinkedRumCaptain = rnd.Next(1, 5);
            for (int i = 0; i < drinkedRumCaptain; i++)
            {
                this.captain.DrinkSomeRum();
            }

            for (int i = 0; i < this.crew.Count; i++)
            {
                int drinkedRum = rnd.Next(1, 5);
                for (int j = 0; j < drinkedRum; j++)
                {
                    this.crew[i].DrinkSomeRum();
                }
            }
        }

        public bool Battle(Ship otherShip)
        {
            if (CalculatedScore() > otherShip.CalculatedScore())
            {
                otherShip.Losses();
                Party();
                return true;
            }
            else
            {
                Losses();
                otherShip.Party();
                return false;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"Captain of {this.name} ship: {this.captain}");
            sb.AppendLine();
            sb.AppendLine($"Number of alive pirates in the crew: {AlivePirates()}");
            return sb.ToString();
        }
    }
}
