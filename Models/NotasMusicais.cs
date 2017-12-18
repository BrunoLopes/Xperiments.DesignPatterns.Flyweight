using System;
using System.Collections.Generic;


namespace Xperiments.DesignPatterns.Flyweight.Models
{
    public class NotasMusicais
    {
        private static IDictionary<string, INota> notas = new Dictionary<string, INota>()
        {
                {"Dó", new Do()}, 
                {"Ré", new Re()}, 
                {"Mi", new Mi()}, 
                {"Fá", new Fa()}, 
                {"Sol", new Sol()}, 
                {"Lá", new La()}, 
                {"Si", new Si()}
               
        };

        public INota Pega(string nome)
        {
            return notas[nome];
        }
        
    }
}
