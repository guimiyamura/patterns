using Factory.Abstract;
using System;

namespace Factory.Concrete
{
    public class UnknowCharacter : ICharacter
    {
        public void ChosenCharacter()
        {
            Console.WriteLine("A habilidade escolhida nao corresponde a nenhum personagem");
        }
    }
}
