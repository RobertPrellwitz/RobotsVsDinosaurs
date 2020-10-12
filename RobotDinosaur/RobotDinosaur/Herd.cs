using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    public class Herd
    {
        List<Dinosaur> dinos;

        public Herd()
        {
            dinos = new List<Dinosaur>();
        }
        public Dinosaur CreateDinosaur(string dinoType, int dinoHealth, int dinoEnergy, int dinoAttackPower)
        {
            Dinosaur dino = new Dinosaur(dinoType, dinoHealth, dinoEnergy, dinoAttackPower);
            return dino;
        }
        public void PopulateHerd(Dinosaur dino)
        {
            dinos.Add(dino);
        }
            
    }

}
