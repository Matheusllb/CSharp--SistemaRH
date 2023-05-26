using Pim3Semestre.Entities.Enums;
using Pim3Semestre.Entities.Static;

namespace Pim3Semestre.Entities
{
    public class Usuario : Pessoa
    {
        public int IdUsuario { get; protected set; }
        public bool Inativo { get; protected set; }
        public string Login { get; protected set; }
        public string Senha { get; protected set; }

        public Usuario(int id, Endereco endereco, string nome, string cpf, EstadoCivil estadoCivil,
            int idUsuario, string login, string senha) : base(id, endereco, nome, cpf, estadoCivil)
        {
            IdUsuario = idUsuario;
            Inativo = false;
            Login = login;
            Senha = senha;
        }

        public Usuario CriaUsuario()
        {
            if (Inativo == false) 
            {
                CadastroUsuario cadastro = new CadastroUsuario();
                cadastro.TelaCadastro();
            }
            return this;
        }

    }
}
