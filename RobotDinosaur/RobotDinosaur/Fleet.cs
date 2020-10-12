using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    public class Fleet
    {
        List<Robot> fleet;
        public int fleetHealth;

        public Fleet()
        {
            fleet = new List<Robot>();
            Robot R1 = CreateRobot("R2 D2", 300, 25);
            Robot R2 = CreateRobot("C3PO", 50, 5);
            Robot R3 = CreateRobot("Eliminator", 350, 100);
        }
        public Robot CreateRobot(string robotName, int robotHealth, int robotPower)//, List<string> weapon)
        {
            Robot robot = new Robot(robotName, robotHealth, robotPower);//, weapon);
            return robot;
        }
        public void PoplulateFleet(Robot robot)
        {
            fleet.Add(robot);

        }
        public void startingFleetHealth(List<Robot> fleet)
        {
            fleetHealth = 0;
            foreach(Robot robot in fleet)
            {
                fleetHealth = fleetHealth + robot.robotHealth;

            }
        }

        public void FleetDamage()
        {
          //  fleetHealth = fleetHealth - Battlefield.robotDamage;
        }
    }
}
