using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class Tucano : Animal, IVoador
    {
        public string Voar()
        {
            return this.GetType().Name + " consegue voar!";
        }
    }
}