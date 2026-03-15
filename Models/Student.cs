namespace project
{
    class Aluno
    {
        private string matricula;
        private string nome;
        private int idade;

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }
    }
}