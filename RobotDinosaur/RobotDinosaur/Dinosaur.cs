using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    public class Dinosaur
    {
        // Memeber Variables
        public string dinoType;
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;
        //public Dinoattack attackMultiple;

        public Dinosaur(string dinoType, int dinoHealth, int dinoEnergy, int dinoAttackPower)
        {
            this.dinoType = dinoType;
            this.dinoHealth = dinoHealth;
            this.dinoEnergy = dinoEnergy;
            this.dinoAttackPower = dinoAttackPower;
        }

        //public  Dinoattack[] dinoAttackArray = new Dinoattack[2];

        //public void AddDinoAttack()
        //{
        //    dinoAttackArray[0] = new Dinoattack("Crane Kick", 2);
        //    dinoAttackArray[1] = new Dinoattack("Kung Fu Grip", 0.5);
        //    dinoAttackArray[2] = new Dinoattack("Camel Clutch", 1.25);
        //}


    }
}
