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
        public Weapon botWeapon;
        public List<Weapon> robotWeapons;


        public Fleet()
        {
           
            robotWeapons = new List<Weapon>();
            Weapon w1 = createWeapons("Broad Sword", 25);
            //robotWeapons.Add(w1);
            PoplulateWeaponList(w1);
            Weapon w2 = createWeapons("Mace", 15);
            PoplulateWeaponList(w2);
            Weapon w3 = createWeapons("Blaster", 50);
            PoplulateWeaponList(w3);
            Weapon w4 = createWeapons("Light Sabre", 75);
            PoplulateWeaponList(w4);
            Weapon w5 = createWeapons("Thors Hammer", 150);
            PoplulateWeaponList(w5);


            fleet = new List<Robot>();

            for (int i = 0; i < robotWeapons.Count; i++)

            {
                Console.WriteLine(i +" "+ robotWeapons[i].type );
            }

            Console.WriteLine("BattleBot please choose your weapon:\n enter a number to select");
            int R1int = Convert.ToInt16(Console.ReadLine());
            Weapon R1Weapon = robotWeapons[R1int];
            Robot R1 = CreateRobot("R2 D2", 100, 30, R1Weapon);
            PoplulateFleet(R1);

            Console.WriteLine("BattleBot please choose your weapon:\n enter a number to select");
            int R2int = Convert.ToInt16(Console.ReadLine());
            Weapon R2Weapon = robotWeapons[R2int];
            Robot R2 = CreateRobot("C3PO", 100, 50,R2Weapon);
            PoplulateFleet(R2);

            Console.WriteLine("BattleBot please choose your weapon:\n enter a number to select");
            int R3int = Convert.ToInt16(Console.ReadLine());
            Weapon R3Weapon = robotWeapons[R3int];
            Robot R3 = CreateRobot("Eliminator", 100, 100,R3Weapon);
            PoplulateFleet(R3);

            startingFleetHealth(fleet);
        }
        public Robot CreateRobot(string robotName, int robotHealth, int robotPower,Weapon weapon)//, List<string> weapon)
        {
            Robot robot = new Robot(robotName, robotHealth, robotPower, weapon);//, weapon);
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
        public Weapon createWeapons(string type, int power)
        {
            Weapon weapon = new Weapon(type, power);
            return weapon;
        }
        public void PoplulateWeaponList(Weapon weapon)
        {
            robotWeapons.Add(weapon);
        }

    }
}
