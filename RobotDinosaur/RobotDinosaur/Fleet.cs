using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    public class Fleet
    {
        List<Robot> robots;

        public Fleet()
        {
            robots = new List<Robot>();
        }
        public Robot CreateRobot(string robotName, int robotHealth, int robotPower, int attackPower)//, List<string> weapon)
        {
            Robot robot = new Robot(robotName, robotHealth, robotPower, attackPower);//, weapon);
            return robot;
        }
        public void PoplulateFleet(Robot robot)
        {
            robots.Add(robot);

        }
    }
}
