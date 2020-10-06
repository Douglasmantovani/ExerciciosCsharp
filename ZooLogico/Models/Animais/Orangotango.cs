using ZooLogico.Interfaces;

namespace ZooLogico.Models.Animais
{
    public class Orangotango : Animal, IArboricula
    {
        public string EscalarArvores()
        {
            return this.GetType().Name + " sobe em árvore";
        }
    }
}