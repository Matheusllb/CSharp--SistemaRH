using Pim3Semestre.Entities.Enums;

namespace Pim3Semestre.Entities
{
    public class Funcionario : Pessoa
    {
        public int IdFuncionario { get; protected set; }
        public string Email { get; protected set; }
        public DateTime DataAdmissao { get; protected set; }
        public Empresa Empresa { get; protected set; }
        public Cargo Cargo { get; protected set; }


        public Funcionario(int id, Endereco endereco, string nome, string cpf, DateTime dataNascimento, EstadoCivil estadoCivil,
        int idFuncionario, string email, DateTime dataAdimissao, Empresa empresa, Cargo cargo) : base(id, endereco, nome, cpf, dataNascimento, estadoCivil)
        {
            IdFuncionario = idFuncionario;
            Email = email;
            DataAdmissao = dataAdimissao;
            Empresa = empresa;
            Cargo = cargo;
        }


    }
}
