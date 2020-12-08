using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsvsDinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            string someNames = "";
            Console.WriteLine(someNames);
            Robot robotOne = new Robot("Jarvis", 60, 75);
            Robot robotTwo = new Robot("Matrix", 66, 80);
            Robot robotThree = new Robot("Roomba", 64, 70);


            Dinosaur dinosaurOne = new Dinosaur("Tyrannosaurus", 75);
            Dinosaur dinosaurTwo = new Dinosaur("Triceratops", 55);
            Dinosaur dinosaurThree = new Dinosaur("Velociraptor", 65);

            Console.WriteLine(robotOne.name);
            Console.WriteLine(robotTwo.name);
            Console.WriteLine(robotThree.name);
            Console.ReadLine();

            

            

        }
    }
}
