using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    public class Battlefield
    {
        // Member Variables
        public int robotDamage;
        public int  dinoDamage;
        public Herd bedRock;
        public Fleet rebel;
        public int attackEnergy;
        //Random rand;  for later gameplay enhancment
        
        public Robot battleBot;
        public Dinosaur battleDino;
        // Fleet object

        public Battlefield()
        {
           // Game Initialization
            bedRock = new Herd();
            rebel = new Fleet();
            attackEnergy = 10;
           // rand = new Random(); for later gameplay enhancement
        }
        // attack proccess

        public void PickAttackBot()
        {   /// select robot for attack
            for (int i = 0; i < rebel.fleet.Count; i++)
            {
                if (rebel.fleet[i].robotHealth > 0 && rebel.fleet[i].robotPower > 10)
                {
                    battleBot = rebel.fleet[i];
                    break;
                }          
            }
            // Dino to be attacked
            for (int j = 0; j < bedRock.herd.Count; j++)
            {
                if (bedRock.herd[j].dinoHealth > 0)
                {
                    battleDino = bedRock.herd[j];
                    break;
                }
            }
        }

        public void PickAttackDino()
        {   /// select robot to be attacked
            for (int i = 0; i < rebel.fleet.Count; i++)
            {
                if (rebel.fleet[i].robotHealth > 0)
                {
                    battleBot = rebel.fleet[i];
                    break;
                }
            }
            /// Dino for attack
            for (int j = 0; j < bedRock.herd.Count; j++)
            {
                if (bedRock.herd[j].dinoHealth > 0 && bedRock.herd[j].dinoEnergy > 10)
                {
                    battleDino = bedRock.herd[j];
                    break;
                }
            }
        }

        public void DinoAttack()
        {
            Console.WriteLine("The Bedrock Herd is launching an attack against the Robot Fleet");
            Console.WriteLine(battleDino.dinoType + " is attacking "+ battleBot.robotName);
            Console.WriteLine("\nBattle Bot " + battleBot.robotName + " health: " + battleBot.robotHealth);
            Console.WriteLine("Rebel Fleet overall health " + rebel.fleetHealth+"\n");
            

            if (battleBot.robotHealth > battleDino.dinoAttackPower)
            {
                battleBot.robotHealth = battleBot.robotHealth - battleDino.dinoAttackPower;
                rebel.fleetHealth = rebel.fleetHealth - battleDino.dinoAttackPower;
                battleDino.dinoEnergy = battleDino.dinoEnergy - attackEnergy;
            }
            else
            {
                rebel.fleetHealth = rebel.fleetHealth - battleBot.robotHealth;
                battleBot.robotHealth = 0;
                battleDino.dinoEnergy = battleDino.dinoEnergy - attackEnergy;

            }
            Console.WriteLine("Battle Bot "+ battleBot.robotName + " remaining health: "+battleBot.robotHealth);
            Console.WriteLine("Rebel Fleet remaining overall health "+ rebel.fleetHealth+"\n");
        }

        public void BotAttack()
        {
            Console.WriteLine("The Rebel Fleet is preparing for their attack run");
            Console.WriteLine(battleBot.robotName +" is attacking "+ battleDino.dinoType);
            Console.WriteLine("\nBattle Dino " + battleDino.dinoType + " health: " + battleDino.dinoHealth);
            Console.WriteLine("Bedrocks overall heard heath: " + bedRock.herdHealth + "\n");
           

            if (battleDino.dinoHealth > battleBot.weapon.weaponPower)
            {

                battleDino.dinoHealth = battleDino.dinoHealth - battleBot.weapon.weaponPower;
                bedRock.herdHealth = bedRock.herdHealth - battleBot.weapon.weaponPower;
                battleBot.robotPower = battleBot.robotPower - attackEnergy;
            }
            else
            {
                bedRock.herdHealth = bedRock.herdHealth - battleDino.dinoHealth;
                battleDino.dinoHealth = 0;
                battleBot.robotPower = battleBot.robotPower - attackEnergy;
            }
            Console.WriteLine("\nBattle Dino "+ battleDino.dinoType + " health: "+battleDino.dinoHealth);
            Console.WriteLine("Bedrocks overall heard heath: " + bedRock.herdHealth+"\n");
        }
          // Current Standings
        public void UpDateStandings()
        {
            Console.WriteLine("At the end of this round of battle the standings are");
            Console.WriteLine("Robots with " + rebel.fleetHealth + " health remaining!");
            Console.WriteLine("Dinosaurs with "+ bedRock.herdHealth+ " health remaining!");
        }

        public void RunBattle()
        {
            // While loop to run until either rebel fleet or bedrock herd lose
            while (rebel.fleetHealth > 0 && bedRock.herdHealth > 0)
            {
                PickAttackDino();
                DinoAttack();
                if (rebel.fleetHealth == 0)
                {
                    break;
                }
                PickAttackBot();
                BotAttack();
                UpDateStandings();
            }
            if(rebel.fleetHealth > bedRock.herdHealth)
            {
                Console.WriteLine ("The rebel alliance wins! Congrats Robot combatants");
            }
            else
            {
                Console.WriteLine("The BedRock herd proved extinct Reptiles still have it with the win");
            }
           

        }
    }
}
