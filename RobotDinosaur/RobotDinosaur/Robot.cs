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
        public int index;
        public Weapon weapon;
        Random rand;


        public Robot(string robotName, int robotHealth, int robotPower, Weapon weapon)
        {
            //List<Weapon> availableWeapons = new List<Weapon>();
            // fill up the list
            // choose our 

            this.robotName = robotName;
            this.robotHealth = robotHealth;
            this.robotPower = robotPower;
            this.weapon = weapon;


        }
        //public Robot(string robotName, int robotHealth, int robotPower)
        //{
        //    this.robotName = robotName;
        //    this.robotHealth = robotHealth;
        //    this.robotPower = robotPower;
        //    this.weapon = new Weapon("sword", 25);
        //}
    }
}
