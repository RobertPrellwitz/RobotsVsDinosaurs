using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    public class Fleet
    {
        public List<Robot> fleet;
        public int fleetHealth;

        public Fleet()
        {
            fleet = new List<Robot>();
            Robot R1 = CreateRobot("R2 D2", 100, 50);
            PoplulateFleet(R1);
            Robot R2 = CreateRobot("C3PO", 100, 50);
            PoplulateFleet(R2);
            Robot R3 = CreateRobot("Eliminator", 100, 100);
            PoplulateFleet(R3);
            startingFleetHealth(fleet);
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

    }
}
