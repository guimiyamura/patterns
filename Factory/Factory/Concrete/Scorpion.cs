using Factory.Abstract;
using System;

namespace Factory.Concrete
{
    public class Scorpion : ICharacter
    {
        public void ChosenCharacter()
        {
            Console.WriteLine("Voce eh o Scorpion");
        }
    }
}
