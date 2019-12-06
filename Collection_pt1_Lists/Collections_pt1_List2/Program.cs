using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_pt1_List2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula aulaIntro = new Aula("Introdução às Coleções", 60);
            Aula aulaModelando = new Aula("Modelando a Classe Aula", 30);
            Aula aulaSets = new Aula("Trabalhando com Conjuntos", 90);

            List<Aula> aulas = new List<Aula>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);
            aulas.Add(new Aula("Aprendendo sobre Ethical Hacking", 180));

            //Fazendo ordenação em ordem alfabética
            aulas.Sort();
            Aula.print(aulas);

            //Fazendo ordenação em duração
            aulas.Sort((aula, outraAula) => aula.Tempo.CompareTo(outraAula.Tempo));
            Aula.print(aulas);

            Console.WriteLine();
            Console.WriteLine("Aperte qualquer tecla para sair da aplicação . . .");
            Console.ReadLine();

        }

        class Aula : IComparable
        {
            private string _titulo;
            private int _tempo;

            public Aula(string _titulo, int _tempo)
            {
                Titulo = _titulo;
                this._tempo = _tempo;
            }

            public string Titulo { get { return _titulo; } set { _titulo = value; } }
            public int Tempo { get { return _tempo; } private set { } }

            public override string ToString()
            {
                return $"Nome: {Titulo}, Duração: {Tempo}";
            }

            public static void print(List<Aula> aulas)
            {
                Console.Clear();
                aulas.ForEach(aula => { Console.WriteLine(aula); });
            }

            public int CompareTo(object obj)
            {
                Aula outraAula = obj as Aula;

                if (outraAula == null)
                    return -1;

                return Titulo.CompareTo(outraAula.Titulo);
            }
        }
    }
}
