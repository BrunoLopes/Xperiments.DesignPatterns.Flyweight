using System;
using System.Collections.Generic;
using Xperiments.DesignPatterns.Flyweight.Models;

namespace Xperiments.DesignPatterns.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            NotasMusicais notas = new NotasMusicais();

            IList<INota> musica = new List<INota>(){
                notas.Pega("Dó"), 
                notas.Pega("Ré"), 
                notas.Pega("Mi"), 
                notas.Pega("Fá"), 
                notas.Pega("Fá"), 
                notas.Pega("Fá"), 
                notas.Pega("Dó"), 
                notas.Pega("Ré"), 
                notas.Pega("Dó"), 
                notas.Pega("Ré"), 
                notas.Pega("Ré"), 
                notas.Pega("Ré"), 
                notas.Pega("Dó"), 
                notas.Pega("Sol"), 
                notas.Pega("Fá"), 
                notas.Pega("Mi"), 
                notas.Pega("Mi"), 
                notas.Pega("Mi"), 
                notas.Pega("Dó"), 
                notas.Pega("Ré"), 
                notas.Pega("Mi"), 
                notas.Pega("Fá"), 
                notas.Pega("Fá"), 
                notas.Pega("Fá"),
            };

            Piano piano = new Piano();

            piano.Tocar(musica);

        }
    }
}
