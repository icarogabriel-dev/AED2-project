using System.Security.Cryptography.X509Certificates;

namespace project
{
    class StudentController
    {
        private Student[] students;
        private int qttStudents;

        public AlunoController(Aluno[] students, int qttStudents)
        {
            this.students = students;
            this.qttStudents = qttStudents;
        }

        public int GetQttStudent()
        {
            return qttStudents;
        }

        public void RegisterStudent()
        {
            Student stud = new Student();

            System.Console.Write("Nome do aluno: ");
            stud.Name = Console.ReadLine();

            System.Console.Write("Idade do aluno: ");
            stud.Age = int.Parse(Console.ReadLine());

            stud.Matricula = qttStudents + 1;
            students[qttStudents] = stud;
            qttStudents++;

            System.Console.WriteLine("Aluno cadastrado com sucesso.");
        }

        public void ListAluno()
        {
            for (int i = 0; i < qttStudents; i++)
            {
                System.Console.WriteLine(students[i].Matricula + " - " 
                + students[i].Name + " - "
                + students[i].Age);
            }
        }

        public Student ToSearchStudent(string value)
        {
            for (int i = 0; i < qttStudents; i++)
            {
                if (students[i].Name.ToLower() == value.ToLower() || students[i].Matricula.ToString() == value)
                {
                    return students[i];
                }
                
                else 
                {
                    System.Console.WriteLine("Aluno não encontrado. Tente novamente.");
                    return null;
                }
            }
        }
    }
}