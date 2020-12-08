using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Robot
    {  //Create three objects and assign appropriate values to all objects

        //Member Variables

        public string name;
        public int health;
        public int powerlevel;
        public  Weapon weapon;
        public int attackpower;




        


        //Constructor


        public Robot(string name, int attackpower, int powerlevel)
        {
            this.name = name;
            this.health = 100;
            this.powerlevel = powerlevel;
            this.attackpower = attackpower;
            

        }
        



        //Member Methods



    }
}
