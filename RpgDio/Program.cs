using System;
using RpgDio.src.entities;

namespace RpgDio
{
    internal class Program
    {
        static void Main(string[] args)
        {  
             Knigth hero1 = new Knigth ("Aurus",17,"Knigth");
             BlackWizard hero2 = new BlackWizard("Snape",17, "BlackWizard");
             Ninja hero3 = new Ninja("Tsunage", 17, "Ninja");
             WithWizard hero4 = new WithWizard ("Lis",17, "WithWizard");

            
            Console.WriteLine(hero1.Attack(10));
            Console.WriteLine(hero3.Attack(9));
            Console.WriteLine(hero4.Attack(6));
            Console.WriteLine(hero2.Attack(7));
        }
    }
}
