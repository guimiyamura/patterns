using Factory.Abstract;
using System;

namespace Factory.Concrete
{
    public class Raiden : ICharacter
    {
        public void ChosenCharacter()
        {
            Console.WriteLine("Voce eh o Raiden!");
        }
    }
}
