using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    public class Herd
    {   //Member Variables
        public List<Dinosaur> herd;
        public int herdHealth;
        public Herd()
        {
            //initiate sample herd
            herd = new List<Dinosaur>();
            Dinosaur d1=CreateDinosaur("Snorkasaurus", 250, 30, 50);
            PopulateHerd(d1);
            Dinosaur d2 = CreateDinosaur("Tyrano", 150, 50, 25);
            PopulateHerd(d2);
            Dinosaur d3 = CreateDinosaur("godzilla", 200, 100, 25);
            PopulateHerd(d3);
            startingHerdHealth(herd);
        }
        public Dinosaur CreateDinosaur(string dinoType, int dinoHealth, int dinoEnergy, int dinoAttackPower)
        {
            Dinosaur dino = new Dinosaur(dinoType, dinoHealth, dinoEnergy, dinoAttackPower);
            return dino;
        }
        public void PopulateHerd(Dinosaur dino)
        {
            herd.Add(dino);
        }
        public void startingHerdHealth(List<Dinosaur> herd)
        {
            herdHealth = 0;
            foreach(Dinosaur dinosaur in herd)
            {
                herdHealth = herdHealth + dinosaur.dinoHealth;
            }
        }
    }

}
