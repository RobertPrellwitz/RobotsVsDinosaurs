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
        public int counter;
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
            int i = 0; int j = 0;
            if (rebel.fleet[i].robotHealth > 0)
            {
                battleBot = rebel.fleet[i];
            }
            else
            {
                i++;
            }
            if (bedRock.herd[j].dinoHealth > 0)
            {
                battleDino = bedRock.herd[j];
            }
            else
            {
                j++;
            }
        }
        public void DinoAttack()
        {
            battleBot.robotHealth = battleBot.robotHealth - battleDino.dinoAttackPower;
        }
        public void BotAttack()
        {
            battleDino.dinoHealth = battleDino.dinoHealth - battleBot.robotPower;
        }
        
        
        
        // Current Standings
        public void UpDateScore()
        {

        }

        public void RunBattle()
        {

        }
    }
}
