using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    public class Dinosaur
    {   //Create three objects and assign appropriate values to all objects

        //Member Variables

        public string type;
        public int health;
        public int energy;
        public int attackpower;


        




        //Constructor

       public Dinosaur(string type, int attackpower)
        {
            this.type = type;
            this.health = 100;
            this.energy = 100;
            this.attackpower = attackpower;


        }


        



        //Member Methods

        public void Attack(Robot robotBeingAttacked)
        {
            robotBeingAttacked.health -= attackPower;


        }




    }
}
