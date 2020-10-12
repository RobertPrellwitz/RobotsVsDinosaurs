using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Fleet Test = new Fleet();
            Robot robot = Test.CreateRobot("Rob", 100, 100, 10);// "sword");
            Test.PoplulateFleet(robot);
            Robot robot1 = Test.CreateRobot("Stan", 100, 100, 15);
            Test.PoplulateFleet(robot1);

            Herd Samp = new Herd();
            Dinosaur dinosaur = Samp.CreateDinosaur("Tyrano", 100, 100, 12);
            Samp.PopulateHerd(dinosaur);
            Dinosaur dinosaur1 = Samp.CreateDinosaur("Snorkasaurus", 100, 125, 25);
            Samp.PopulateHerd(dinosaur1);
        }
    }
}
