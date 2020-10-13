using System;
namespace RobotDinosaur
{
    public class Dinoattack
    {
        //Member Variables
        public string attackMethod;
        public double attackMult;
        public Dinoattack()
        {
        }
        public Dinoattack(string attackMethod, double attackMult)
        {
            this.attackMethod = attackMethod;
            this.attackMult = attackMult;

        }
    //    public Dinoattack[] dinoAttackArray = new Dinoattack[2];

    //    public void AddDinoAttack()
    //    {
    //        dinoAttackArray[0] = new Dinoattack("Crane Kick", 2);
    //        dinoAttackArray[1] = new Dinoattack("Kung Fu Grip", 0.5);
    //        dinoAttackArray[2] = new Dinoattack("Camel Clutch", 1.25);
    //    }
    }
}
