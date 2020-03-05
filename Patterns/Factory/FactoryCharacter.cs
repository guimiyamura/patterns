using Factory.Abstract;
using Factory.Concrete;

namespace Factory
{
    public class FactoryCharacter
    {
        public ICharacter ChoseCharacter(string skill)
        {
            switch (skill)
            {
                case "fogo": return new Scorpion();
                case "gelo": return new SubZero();
                case "raio": return new Raiden();
                default: return new UnknowCharacter();
            }
        }
    }
}
