using System;
using JogoRPG.src.Entities;

class Program
{
    static void Main(string[] args)
    {
        Knight knight = new Knight("Arus", 23, "Knight", 469, 749, 72, 76);
        Wizard wizard = new Wizard("Jennica", 23, "White Wizard", 325, 601, 474, 482);
        Ninja ninja = new Ninja("Wedge", 23, "Ninja", 292, 574, 89, 89);
        BlackWizard blackWizard = new BlackWizard("Topapa", 23, "Black Wizard", 106, 385, 611, 641);

        System.Console.WriteLine(knight);
        System.Console.WriteLine(wizard);
        System.Console.WriteLine(ninja);
        System.Console.WriteLine(blackWizard);

        System.Console.WriteLine();

        System.Console.WriteLine(knight.Attack(20));
        System.Console.WriteLine(wizard.Attack(25));
        System.Console.WriteLine(ninja.Attack(25));
        System.Console.WriteLine(blackWizard.Attack(25));
    }
}
