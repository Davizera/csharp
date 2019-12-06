using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_pt1_List_Read_Only
{
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
