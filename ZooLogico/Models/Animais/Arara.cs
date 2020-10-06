using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class Arara : Animal, IVoador
    {
        public string Voar()
        {
            return this.GetType().Name + " consegue voar!";
        }
    }
}