using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_pt1_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";
            
            var aulas = new List<string>() { aulaIntro, aulaModelando, aulaSets };

            aulas.Add("Trabalhando com teste");
            aulas.Add("Trabalhando com front-end");
            aulas.Add("Trabalhando com back-end");

            Print(aulas);

            Console.WriteLine("A primeira aula com nome 'Trabalhando' é: " + aulas.First(aula => aula.Contains("Trabalhando")));
            Console.WriteLine("A última aula com nome 'Trabalhando' é: " + aulas.Last(aula => aula.Contains("Trabalhando")));
            


            Console.WriteLine("Aperte qualquer tecla para sair da aplicação . . .");
            Console.ReadLine();
        }

        private static void Print(List<string> aulas)
        {
            aulas.ForEach(aula => { Console.WriteLine(aula); });
        }
    }
}
