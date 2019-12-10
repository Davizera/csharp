using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    class Program
    {
        static void Main(string[] args)
        {

            //método com sobrecarga para resolver o problema de um mesmo aluno escrito de maneira diferente
            ISet<string> alunos = new SortedSet<string>(new comparador()) { "Fábio Gushiken", "Davi Sousa", "FÁBIO GUSHIKEN", "Lara Cardoso", "Caio Alves" };

            foreach (var aluno in alunos)
            {
                Console.WriteLine($"Nome: {aluno}");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }

    internal class comparador : IComparer<string>
    {
        public int Compare(string aluno, string outroAluno)
        {
            return string.Compare(aluno, outroAluno, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
