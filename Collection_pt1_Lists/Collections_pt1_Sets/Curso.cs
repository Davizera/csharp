using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Collections_pt1_Sets
{

    public class Curso
    {
        private IDictionary<int, Aluno> alunoDictionary = new Dictionary<int, Aluno>();
        private List<Aula> aulas;
        private ISet<Aluno> alunos = new HashSet<Aluno>();
        private string nome;
        private string instrutor;

        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        public IList<Aluno> Alunos
        {
            get { return new ReadOnlyCollection<Aluno>(alunos.ToList()); }
        }

        public void AddClass(Aula aula)
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

        public void Subscribe(Aluno aluno)
        {
            alunoDictionary.Add(aluno.NumeroMatricula, aluno);
            alunos.Add(aluno);
        }

        public void Unsubscribe(Aluno aluno)
        {
            alunos.Remove(aluno);
        }

        public bool IsSubscribed(Aluno aluno)
        {
            return Alunos.Contains(aluno);
        }

        public void ChangeSubscribe(Aluno aluno)
        {
            this.alunos.Add(aluno);
            this.alunoDictionary[aluno.NumeroMatricula] = aluno;
        }

        public int TotalTime
        {
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

        public Aluno Find(int numertoMatricula)
        {
            Aluno aluno = null;
            alunoDictionary.TryGetValue(numertoMatricula, out aluno);

            return aluno;
        }

        public override string ToString()
        {
            return $"Curso: {Nome}, Instrutor: {Instrutor}, Duração do curso: {TotalTime}, \nAulas\n{string.Join(",\n", aulas)}";
        }
    }
}
