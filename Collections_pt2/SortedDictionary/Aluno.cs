namespace SortedDictionary
{
    public class Aluno
    {
        private string nome;
        private int numeroMatricula;

        public Aluno(string nome, int numeroMatricula)
        {
            this.nome = nome;
            this.numeroMatricula = numeroMatricula;
        }

        public string Nome
        {
            get { return nome; }
        }

        public int NumeroMatricula
        {
            get { return numeroMatricula; }
        }

        public override string ToString()
        {
            return $"Aluno: {Nome}, Matrícula: {NumeroMatricula}";
        }

        public override bool Equals(object obj)
        {
            Aluno outroAluno = obj as Aluno;

            if (outroAluno == null)
                return false;
            return Nome.Equals(outroAluno.Nome) && NumeroMatricula.Equals(outroAluno.NumeroMatricula);
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode() + NumeroMatricula.GetHashCode();
        }

    }
}
