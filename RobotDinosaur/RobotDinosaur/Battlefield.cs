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
        // counter variable

        public Robot battleBot;
        public Dinosaur battleDino;
        // Fleet object

        public Battlefield()
        {
           // Game Initialization
            bedRock = new Herd();
            rebel = new Fleet();
            
        }
        // attack proccess

        public void PickCombatants()
        {   /// select robot for attack
            for (int i = 0; i < rebel.fleet.Count; i++)
            {
                if (rebel.fleet[i].robotHealth > 0)
                {
                    battleBot = rebel.fleet[i];
                    break;
                }          
            }
            for (int j = 0; j < bedRock.herd.Count; j++)
            {
                if (bedRock.herd[j].dinoHealth > 0)
                {
                    battleDino = bedRock.herd[j];
                    break;
                }
            }
        }
        public void DinoAttack()
        {
            Console.WriteLine("\nBattle Bot " + battleBot.robotName + " health: " + battleBot.robotHealth);
            Console.WriteLine("Rebel Fleet overall health " + rebel.fleetHealth+"\n");
            Console.WriteLine("The Bedrock Herd is launching another attack");

            if (battleBot.robotHealth > battleDino.dinoAttackPower)
            {
                battleBot.robotHealth = battleBot.robotHealth - battleDino.dinoAttackPower;
                rebel.fleetHealth = rebel.fleetHealth - battleDino.dinoAttackPower;
            }
            else
            {
                rebel.fleetHealth = rebel.fleetHealth - battleBot.robotHealth;
                battleBot.robotHealth = 0;

            }
            Console.WriteLine("Battle Bot "+ battleBot.robotName + " health: "+battleBot.robotHealth);
            Console.WriteLine("Rebel Fleet overall health "+ rebel.fleetHealth+"\n");
        }

        public void BotAttack()
        {
            Console.WriteLine("\nBattle Dino " + battleDino.dinoType + " health: " + battleDino.dinoHealth);
            Console.WriteLine("Bedrocks overall heard heath: " + bedRock.herdHealth + "\n");
            Console.WriteLine("The Rebel Fleet is preparing for their attack run");

            if (battleDino.dinoHealth > battleBot.weapon.weaponPower)
            {

                battleDino.dinoHealth = battleDino.dinoHealth - battleBot.weapon.weaponPower;
                bedRock.herdHealth = bedRock.herdHealth - battleBot.weapon.weaponPower;
            }
            else
            {
                bedRock.herdHealth = bedRock.herdHealth - battleDino.dinoHealth;
                battleDino.dinoHealth = 0;
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
                PickCombatants();
                DinoAttack();
                PickCombatants();
                BotAttack();
                UpDateStandings();
            }
            if(rebel.fleetHealth > bedRock.herdHealth)
            {
                Console.WriteLine ("The rebel alliance wins!  Congrats Robot combatants");
            }
            else
            {
                Console.WriteLine("The BedRock herd proved extinct Reptiles still have it with the win");
            }
           

        }
    }
}
