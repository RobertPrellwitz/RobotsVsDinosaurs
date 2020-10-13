using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RobotDinosaur
{
    public class Weapon
    {   //Member Variables
        public string type;
        public int weaponPower;
        //public List<Weapon> robotWeapons;

        public Weapon()
        {
            //robotWeapons = new List<Weapon>();
            //Weapon w1 = createWeapons("Broad Sword", 25);
            //PoplulateWeaponList(w1);
            //Weapon w2 = createWeapons("Mace", 15);
            //PoplulateWeaponList(w2);
            //Weapon w3 = createWeapons("Blaster", 50);
            //PoplulateWeaponList(w3);
            //Weapon w4 = createWeapons("Light Sabre", 75);
            //PoplulateWeaponList(w4);
            //Weapon w5 = createWeapons("Thors Hammer", 150);
            //PoplulateWeaponList(w5);
        }

        public Weapon(string type, int power)
        {
            this.type = type;
            this.weaponPower = power;
            
        }
        
    }
}
