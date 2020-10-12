using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    public class Robot
    {
        // Member Variables
        public string robotName;
        public int robotHealth;
        public int robotPower;
        public int attackPower;
        public List<string> weapon = new List<string>();

        public Robot(string robotName, int robotHealth, int robotPower, int attackPower, List<string> weapon )
        {
            this.robotName= robotName;
            this.robotHealth = robotHealth;
            this.robotPower = robotPower;
            this.attackPower = attackPower;
            this.weapon = weapon;


        }
    }
}
