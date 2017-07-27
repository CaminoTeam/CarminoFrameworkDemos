using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminoLib
{
    public class Unit
    {
        private static int[] attack = { 1, 0, 2, 3, 1, 3, 4 };
        private static int[] defense = { 1, 2, 2, 1, 3, 3, 4};
        
        public int UnitID { get; set; }
        public bool HasAction { get; set; }
        public int Owner { get; set; }

        public Unit()
        {
            UnitID = 0;
            HasAction = false;
            Owner = 0;
        }

        public Unit(int unitID, int owner) : this()
        {
            UnitID = UnitID;
            Owner = owner;
        }

        public int GetAttack()
        {
            return attack[UnitID];
        }

        public int GetDefense()
        {
            return defense[UnitID];
        }

        public bool Kills(Unit unit)
        {
            var output = true;
            if (unit.GetDefense() > this.GetAttack())
            {
                output = false;
            }
            return output;
        }
    }
}
