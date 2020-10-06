using System.Collections.Generic;

namespace ZooLogico.Models.Animais
{
    public class Arca
    {
        public static Dictionary<int, Animal> Animais = new Dictionary<int, Animal>(){
            {1, new Arara()},
            {2, new Chimpanze()},
            {3, new Golfinho()},
            {4, new Leao()},
            {5, new Orangotango()},
            {6, new Pinguim()},
            {7, new Tartaruga()},
            {8, new TubaraoMartelo()},
            {9, new Tucano()}
        };
    }
}