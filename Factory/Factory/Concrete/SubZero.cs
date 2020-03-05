using Factory.Abstract;
using System;

namespace Factory.Concrete
{
    public class SubZero : ICharacter
    {
        public void ChosenCharacter()
        {
            Console.WriteLine("Voce eh o SubZero!");
        }
    }
}
