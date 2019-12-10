using System;
using System.Collections.Generic;

namespace Collections_pt1_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso cSharpcollections = new Curso("C# Collections", "Marcelo Oliveira");
            LinkedList<string> dias = new LinkedList<string>();

            cSharpcollections.AddClass(new Aula("Trabalhando com Listas", 45));
            cSharpcollections.AddClass(new Aula("Crinado uma Aula", 15));
            cSharpcollections.AddClass(new Aula("Modelando com Sets", 30));

            Aluno vanessa = new Aluno("Vanessa Tonini", 34672);
            Aluno ana = new Aluno("Ana  Losnak", 5618);
            Aluno rafael = new Aluno("Rafael Nercessian", 18645);

            cSharpcollections.Subscribe(vanessa);
            cSharpcollections.Subscribe(ana);
            cSharpcollections.Subscribe(rafael);
            Console.WriteLine(string.Join(",\n", cSharpcollections.Alunos) + "\nEstão Subscribedos no curso: " + cSharpcollections.Nome);

            Console.WriteLine();

            cSharpcollections.Unsubscribe(ana);
            Console.WriteLine(string.Join(",\n", cSharpcollections.Alunos) + "\nEstão Subscribedos no curso: " + cSharpcollections.Nome);

            Console.WriteLine();
            Console.WriteLine("O aluno " + ana + " está matrículado? " + (cSharpcollections.IsSubscribed(ana) ? "Sim" : "Não"));
            Console.WriteLine("O aluno " + rafael + " está matrículado? " + (cSharpcollections.IsSubscribed(rafael) ? "Sim" : "Não"));

            Console.WriteLine();
            Aluno alunoEncontrado = cSharpcollections.Find(rafael.NumeroMatricula);
            Console.WriteLine($"O aluno da matricula {alunoEncontrado.NumeroMatricula} é {alunoEncontrado}");

            Console.WriteLine();
            alunoEncontrado = cSharpcollections.Find(1235);
            Console.WriteLine("O aluno da matricula 1235 é " + (alunoEncontrado == null ? "Aluno não encontrado": alunoEncontrado.ToString()));

            Console.WriteLine();

            alunoEncontrado = cSharpcollections.Find(vanessa.NumeroMatricula);
            Console.WriteLine($"O aluno da matricula {alunoEncontrado.NumeroMatricula} é {alunoEncontrado}");
            cSharpcollections.ChangeSubscribe(new Aluno("Davi Alves", 34672));
            alunoEncontrado = cSharpcollections.Find(34672);
            Console.WriteLine($"O aluno da matricula {alunoEncontrado.NumeroMatricula} é {alunoEncontrado}");

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para sair da aplicação . . .");
            Console.ReadLine();


        }
    }
}
