using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> alunos = new SortedDictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5618));
            alunos.Add("RN", new Aluno("Rafael", 18645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            ImprimeAlunos(alunos);

            alunos.Remove("AL");
            alunos.Add("MR", new Aluno("Marcelo", 123456));

            Console.WriteLine();
            ImprimeAlunos(alunos);

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para sair da aplicação . . .");
            Console.ReadLine();

        }

        private static void ImprimeAlunos(IDictionary<string, Aluno> alunos)
        {
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
