﻿using System;
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

    }
}
