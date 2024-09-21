using API_Aluno.Repository;
using Microsoft.AspNetCore.Mvc;
using API_Aluno.Models;
using System.Security.Cryptography;

namespace API_Aluno.Controllers
{
    [ApiController]
    [Route("API/ALUNO_CONTROLLER")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoRepository alunoRepository;
    
        // D.P.I
        public AlunoController(IAlunoRepository _alunoRepository)
        {
            alunoRepository = _alunoRepository;
        }

        [HttpPost]
        [Route("Criar_Aluno")]
        public IActionResult Inserir(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            alunoRepository.InserirAluno(new Aluno()
            {
                CPF = aluno.CPF,
                Email = aluno.Email,
                Nome = aluno.Nome,
                Telefone = aluno.Telefone
            });

            return Ok($"{aluno.Nome} cadastrado(a) com sucesso!");
        }


        [HttpGet]
        [Route("GetAlunos")]
        public IActionResult GetAlunos()
        {
            return Ok(alunoRepository.GetAlunos());
        }

        [HttpGet]
        [Route("GetAlunoByCPF")]
        public IActionResult GetAlunoByCPF(string cpf)
        {
            var alunoPesquisado = alunoRepository.GetAlunoByCPF(cpf);

            if(alunoPesquisado is null)
            {
                return BadRequest($"{cpf} nao encontrado.");
            }

            return Ok(alunoPesquisado);
        }
    }
}




