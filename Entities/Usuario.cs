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
        public List<Usuario> Usuarios { get; private set; } = new List<Usuario>();
        public List<Empresa> Empresas { get; private set; } = new List<Empresa>();
        public List<Funcionario> Funcionarios { get; private set; } = new List<Funcionario>();
        public List<Cargo> Cargos { get; private set; } = new List<Cargo>();
        public List<Salario> Salarios { get; private set; } = new List<Salario>();
        public List<FolhaPagamento> Folhas { get; private set; } = new List<FolhaPagamento>();

        public Usuario(int id, Endereco endereco, string nome, string cpf, EstadoCivil estadoCivil,
            int idUsuario, string login, string senha) : base(id, endereco, nome, cpf, estadoCivil)
        {
            IdUsuario = idUsuario;
            Inativo = false;
            Login = login;
            Senha = senha;
        }
        public void CadastraUsuario()
        {   
            CadastroUsuario cadastro = new CadastroUsuario();
            Usuario novoUsuario = cadastro.TelaCadastro();
            Usuarios.Add(novoUsuario);
        }

        public void CadastraEmpresa()
        {
            CadastroEmpresa cadastro = new CadastroEmpresa();
            Empresa novaEmpresa = cadastro.TelaCadastro();
            Empresas.Add(novaEmpresa);
        }

        public void CadastraFuncionario(Empresa empresa)
        {
            CadastroFuncionario cadastro = new CadastroFuncionario();
            Funcionario novoFuncionario = cadastro.TelaCadastro(empresa);
            Funcionarios.Add(novoFuncionario);
        }

        public void CadastraCargo(Empresa empresa)
        {
            CadastroCargo cadastro = new CadastroCargo();
            Cargo novoCargo = cadastro.TelaCadastro(empresa);
            Cargos.Add(novoCargo);
        }

        public void CadastraSalario(Funcionario funcionario, Cargo cargo)
        {
            CadastroSalario cadastro = new CadastroSalario();
            Salario novoSalario = cadastro.TelaCadastro(funcionario, cargo);
            Salarios.Add(novoSalario);
        }
        
        public void CadastraFolhaPagamento(Empresa empresa, Salario salario, ItensFolha itens)
        {
            CadastroFolhaPagamento cadastro = new CadastroFolhaPagamento();
            FolhaPagamento novaFolhaP = cadastro.TelaCadastro(empresa, salario, itens);
            Folhas.Add(novaFolhaP);
        }

    }
}
