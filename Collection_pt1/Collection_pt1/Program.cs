using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_pt1
{
    class Program
    {
        static void Main(string[] args)
        {
            //os elementos que entrarão no array
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            //declarando um array populado
            string[] aulas = new string[]
            {
                aulaIntro,
                aulaModelando,
                aulaSets
            };

            Print(aulas);
            
            aulaModelando = "Trabalhando com Arrays";
            Console.ReadLine();
        }

        private static void Print(string[] aulas)
        {
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
