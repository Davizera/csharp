using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_pt1_List_Read_Only
{
    class Curso
    {
        private IList<Aula> aulas;
        private string nome;
        private string instrutor;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        internal void AddClass(Aula aula)
        {
            aulas.Add(aula);
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        
        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TotalTime {
            get
            {
                return aulas.Sum(aula => aula.Tempo);
            }
        }

        public Curso(string nome, string instrutor)
        {
            Nome = nome;
            Instrutor = instrutor;
            aulas = new List<Aula>();
        }

        public override string ToString()
        {
            return $"Curso: {Nome}, Instrutor: {Instrutor}, Duração do curso: {TotalTime}, \nAulas\n{string.Join(",\n",aulas)}";
        }

    }
}
