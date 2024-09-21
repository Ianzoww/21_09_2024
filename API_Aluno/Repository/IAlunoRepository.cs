using API_Aluno.Models;

namespace API_Aluno.Repository
{
    public interface IAlunoRepository
    {
        public void InserirAluno(Aluno aluno);

        public Aluno GetAlunoByCPF(string cpf);

        public List<Aluno> GetAlunos();
    }
}
