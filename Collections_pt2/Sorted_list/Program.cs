using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_list
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string, Aluno> alunos = new Dictionary<string, Aluno>();

            alunos.Add("VT", new Aluno("Vanessa", 34672));
            alunos.Add("AL", new Aluno("Ana", 5618));
            alunos.Add("RN", new Aluno("Rafael", 18645));
            alunos.Add("WM", new Aluno("Wanderson", 11287));

            ImprimeAlunos(alunos);

            alunos.Remove("AL");
            alunos.Add("MR", new Aluno("Marcelo", 123456));

            Console.WriteLine();
            ImprimeAlunos(alunos);


            //Usando o sorted list, indices são ordenados
            IDictionary<string, Aluno> sorted = new SortedList<string, Aluno>();

            sorted.Add("VT", new Aluno("Vanessa", 34672));
            sorted.Add("AL", new Aluno("Ana", 5618));
            sorted.Add("RN", new Aluno("Rafael", 18645));
            sorted.Add("WM", new Aluno("Wanderson", 11287));

            Console.WriteLine();
            ImprimeAlunos(sorted);

            sorted.Remove("AL");
            sorted.Add("MR", new Aluno("Marcelo", 123456));
            
            Console.WriteLine();
            ImprimeAlunos(sorted);


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
