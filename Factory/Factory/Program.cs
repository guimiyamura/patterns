using Factory.Abstract;
using System;

namespace Factory
{
    public class Program
    {
        static void Main(string[] args)
        {
            var factory = new FactoryCharacter();

            Console.WriteLine("Habilidades: Gelo | Fogo | Raio");
            Console.WriteLine();

            Console.WriteLine("Escolha uma das habilidades");
            string skill = Console.ReadLine();
            ICharacter character = factory.ChoseCharacter(skill.Trim().ToLower());
            Console.WriteLine();

            character.ChosenCharacter();
            Console.ReadKey();
        }
    }
}
