using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    public class Weapon
    {   //Member Variables
        public string type;
        public int weaponPower;
        
        public Weapon()
        {
        }

        public Weapon(string type, int power)
        {
            this.type = type;
            this.weaponPower = power;
        }
        
    }
}
