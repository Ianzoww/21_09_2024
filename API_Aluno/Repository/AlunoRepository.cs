using API_Aluno.Models;
using API_Aluno.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
namespace API_Aluno.Services
{
    /*Logica para:
     * 
     * Criar aluno e inserir na lista
     * Obter todos os alunos da lista
     * Buscar um aluno da lista pelo COF
     * 
     */
    public class AlunoRepository : IAlunoRepository
    {
        private static List<Aluno> listaDeAlunos = new List<Aluno>();

        // Metodo para inserir o aluno na lista
        public void InserirAluno(Aluno aluno)
        {
            listaDeAlunos.Add(aluno);
        }

        public Aluno GetAlunoByCPF(string cpf)
        { 
            return listaDeAlunos.Where(c => c.CPF == cpf).FirstOrDefault();
        }

        public List<Aluno> GetAlunos() 
        {
            return listaDeAlunos;
        }


    }
}
