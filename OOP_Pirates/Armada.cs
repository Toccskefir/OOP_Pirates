using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pirates
{
    internal class Armada
    {
        private string name;
        private List<Ship> ships;

        public Armada(string name)
        {
            this.name = name;
            this.ships = new List<Ship>();
        }

        public string Name { get => name; set => name = value; }
        internal List<Ship> Ships { get => ships; }

        public void AddShip(Ship ship)
        {
            this.ships.Add(ship);
        }

        public bool ArmadaWar(Armada otherArmada)
        {
            int thisNumberOfShip = 0;
            int otherNumberOfShip = 0;
            Ship thisCurrentShip = this.ships[thisNumberOfShip];
            Ship otherCurrentShip = otherArmada.Ships[otherNumberOfShip];
            while (thisNumberOfShip <= this.ships.Count && otherNumberOfShip <= otherArmada.Ships.Count)
            {
                if(thisCurrentShip.Battle(otherCurrentShip))
                {
                    otherNumberOfShip++;
                    otherCurrentShip = otherArmada.Ships[otherNumberOfShip];
                }
                else
                {
                    thisNumberOfShip++;
                    thisCurrentShip = this.ships[thisNumberOfShip];
                }
            }

            if (thisNumberOfShip == this.ships.Count)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder($"{this.name} armada has {this.ships.Count} ship:");
            foreach (Ship item in this.ships)
            {
                sb.AppendLine();
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}