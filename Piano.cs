using System;
using System.Collections.Generic;
using Xperiments.DesignPatterns.Flyweight.Models;

namespace Xperiments.DesignPatterns.Flyweight
{
    public class Piano
    {
        public void Tocar(IList<INota> musica)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, 500);
            }
        }
    }
}
