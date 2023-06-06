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

        public Usuario(int id, Endereco endereco, string nome, string cpf, DateTime dataNascimento, EstadoCivil estadoCivil,
            int idUsuario, string login, string senha) : base(id, endereco, nome, cpf, dataNascimento, estadoCivil)
        {
            IdUsuario = idUsuario;
            Inativo = false;
            Login = login;
            Senha = senha;
        }

        //------------------------------------------------------Métodos para Usuário------------------------------------------------------
        public void CadastraUsuario()
        {   
            CadastroUsuario cadastro = new CadastroUsuario();
            Usuario novoUsuario = cadastro.TelaCadastro();
            Usuarios.Add(novoUsuario);
        }

        public void ProcuraUsuarioPorId(int id)
        {
            Usuario usuarioEncontrado = Usuarios.Find(u => u.Id == id);
            if(usuarioEncontrado != null)
            {
                Console.WriteLine($"Usuário encontrado: {usuarioEncontrado}");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }

        public void ProcuraUsuarioPorNome(string nome)
        {
            Usuario usuarioEncontrado = Usuarios.Find(u => u.Nome == nome);

            if (usuarioEncontrado != null)
            {
                Console.WriteLine($"Usuário encontrado: {usuarioEncontrado}");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
            }
        }

        public List<Usuario> ProcuraUsuariosPorParteDoNome(string parteNome)
        {
            List<Usuario> usuariosEncontrados = Usuarios.FindAll(u => u.Nome.Contains(parteNome));
            return usuariosEncontrados;
        }

        public List<Usuario> ProcuraUsuariosPorIdade(int idade)
        {
            DateTime dataAtual = DateTime.Today;
            List<Usuario> usuariosEncontrados = Usuarios.FindAll(u => CalculaIdade(u.DataNascimento, dataAtual) == idade);
            return usuariosEncontrados;
        }

        public int CalculaIdade(DateTime dataNascimento, DateTime dataAtual)
        {
            int idade = dataAtual.Year - dataNascimento.Year;
            if (dataNascimento > dataAtual.AddYears(-idade))
            {
                idade--;
            }
            else if (dataNascimento.Month == dataAtual.Month && dataNascimento.Day > dataAtual.Day)
            {
                idade--;
            }
            return idade;
        }

        public void RemoveUsuario(Usuario usuario)
        {
            Usuarios.Remove(usuario);
        }

        //-------------------------------------------------------Métodos para Empresas----------------------------------------------------

        public void CadastraEmpresa()
        {
            CadastroEmpresa cadastro = new CadastroEmpresa();
            Empresa novaEmpresa = cadastro.TelaCadastro();
            Empresas.Add(novaEmpresa);
        }

        public void ProcuraEmpresaPorId(int id)
        {
            Empresa empresaEncontrada = Empresas.Find(e => e.Id == id);
            if (empresaEncontrada != null)
            {
                Console.WriteLine($"Empresa encontrada: {empresaEncontrada}");
            }
            else
            {
                Console.WriteLine("Empresa não encontrada.");
            }
        }

        public List<Empresa> ProcuraEmpresaPorNome(string nome)
        {
            List<Empresa> empresasEncontradas = Empresas.FindAll(e => e.Nome == nome);
            if (empresasEncontradas != null)
            {
                return empresasEncontradas;
            }
            else
            {
                Console.WriteLine("Empresa não encontrada.");
            }
            return empresasEncontradas;
        }
        
        public List<Empresa> ProcuraEmpresaPorSetor(string setor)
        {
            List<Empresa> empresasEncontradas = Empresas.FindAll(e => e.Setor == setor);
            return empresasEncontradas;
        }

        public List<Empresa> ProcuraEmpresaPorEstado(Estado estado)
        {
            List<Empresa> empresasEncontradas = Empresas.FindAll(e => e.Endereco.Cidade.Uf == estado);
            return empresasEncontradas;
        }

        public List<Empresa> ProcuraEmpresaPorNomeCidade(string nomeCidade)
        {
            List<Empresa> empresasEcontradas = Empresas.FindAll(e => e.Endereco.Cidade.Nome == nomeCidade);
            return empresasEcontradas;
        }
        public List<Empresa> ProcuraEmpresaPorCep(string cep)
        {
            List<Empresa> empresasEncontrada = Empresas.FindAll(e => e.Endereco.Cep == cep);
            return empresasEncontrada;
        }
        public void ProcuraEmpresaPorLogradouro(string logradouro)
        {
            Empresa empresaEncontrada = Empresas.Find(e => e.Endereco.NomeLogradouro == logradouro);
            if (empresaEncontrada != null)
            {
                Console.WriteLine($"Empresa encontrada: {empresaEncontrada}");
            }
            else
            {
                Console.WriteLine("Empresa não encontrada.");
            }
        }

        public void RemoveEmrpesa(Empresa empresa)
        {
            Empresas.Remove(empresa);
        }

        //-----------------------------------------------------Métodos para Funcionário----------------------------------------------------

        public void CadastraFuncionario(Empresa empresa, Cargo cargo)
        {
            CadastroFuncionario cadastro = new CadastroFuncionario();
            Funcionario novoFuncionario = cadastro.TelaCadastro(empresa, cargo);
            Funcionarios.Add(novoFuncionario);
        }

        public void ProcuraFuncionarioPorId(int id)
        {
            Funcionario funcionarioEncontrado = Funcionarios.Find(f => f.Id == id);
            if (funcionarioEncontrado != null)
            {
                Console.WriteLine($"Funcionário encontrado: {funcionarioEncontrado}");
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }

        public List<Funcionario> ProcuraFuncionarioPorNome(string nome)
        {
            List<Funcionario> funcionariosEncontrados = Funcionarios.FindAll(f => f.Nome == nome);
            if (funcionariosEncontrados != null)
            {
                return funcionariosEncontrados;
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            return funcionariosEncontrados;
        }

        public List<Funcionario> ProcuraFuncionarioPorDataAdimissao(DateTime dataAdimissao)
        {
            List<Funcionario> funcionariosEncontrados = Funcionarios.FindAll(f => f.DataAdmissao == dataAdimissao);
            if (funcionariosEncontrados != null)
            {
                return funcionariosEncontrados;
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            return funcionariosEncontrados;
        }
        public List<Funcionario> ProcuraFuncionarioPorMesNascimento(int mesNascimento)
        {
            List<Funcionario> funcionariosEncontrados = Funcionarios.FindAll(f => f.DataNascimento.Month == mesNascimento);
            if (funcionariosEncontrados != null)
            {
                return funcionariosEncontrados;
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            return funcionariosEncontrados;
        }
        public List<Funcionario> ProcuraFuncionarioPorAnoNascimento(int anoNascimento)
        {
            List<Funcionario> funcionariosEncontrados = Funcionarios.FindAll(f => f.DataNascimento.Year == anoNascimento);
            if (funcionariosEncontrados != null)
            {
                return funcionariosEncontrados;
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            return funcionariosEncontrados;
        }
        public List<Funcionario> ProcuraFuncionarioPorDataNascimento(DateTime dataNascimento)
        {
            List<Funcionario> funcionariosEncontrados = Funcionarios.FindAll(f => f.DataNascimento == dataNascimento);
            if (funcionariosEncontrados != null)
            {
                return funcionariosEncontrados;
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            return funcionariosEncontrados;
        }

        public List<Funcionario> ProcuraFuncionarioPorEmpresa(string nomeEmpresa)
        {
            List<Funcionario> funcionariosEncontrados = Funcionarios.FindAll(f => f.Empresa.Nome == nomeEmpresa);
            if (funcionariosEncontrados != null)
            {
                return funcionariosEncontrados;
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            return funcionariosEncontrados;
        }
        public List<Funcionario> ProcuraFuncionarioPorCargo(string cargo)
        {
            List<Funcionario> funcionariosEncontrados = Funcionarios.FindAll(f => f.Cargo.Nome == cargo);
            if (funcionariosEncontrados != null)
            {
                return funcionariosEncontrados;
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
            return funcionariosEncontrados;
        }

        public void RemoveFuncionario(Funcionario funcionario)
        {
            Funcionarios.Remove(funcionario);
        }

        //--------------------------------------------------------Métodos para Cargos-------------------------------------------------------

        public void CadastraCargo(Empresa empresa)
        {
            CadastroCargo cadastro = new CadastroCargo();
            Cargo novoCargo = cadastro.TelaCadastro(empresa);
            Cargos.Add(novoCargo);
        }

        public void ProcuraCargoPorId(int id)
        {
            Cargo cargoEncontrado = Cargos.Find(c => c.Id == id);
            if (cargoEncontrado != null)
            {
                Console.WriteLine($"Cargo encontrado: {cargoEncontrado}");
            }
            else
            {
                Console.WriteLine("Cargo não encontrado.");
            }
        }

        public List<Cargo> ProcuraCargoPorNome(string nome)
        {
            List<Cargo> cargosEncontrados = Cargos.FindAll(c => c.Nome == nome);
            if (cargosEncontrados != null)
            {
                return cargosEncontrados;
            }
            else
            {
                Console.WriteLine("Cargo não encontrado.");
            }
            return cargosEncontrados;
        }

        public List<Cargo> ProcuraCargoPorEmpresa(string nomeEmpresa)
        {
            List<Cargo> cargosEncontrados = Cargos.FindAll(c => c.Empresa.Nome == nomeEmpresa);
            if (cargosEncontrados != null)
            {
                return cargosEncontrados;
            }
            else
            {
                Console.WriteLine("Cargo não encontrado.");
            }
            return cargosEncontrados;
        }

        public void RemoveCargo(Cargo cargo)
        {
            Cargos.Remove(cargo);
        }

        //-------------------------------------------------------Métodos para Salários-------------------------------------------------------

        public void CadastraSalario(Funcionario funcionario, Cargo cargo)
        {
            CadastroSalario cadastro = new CadastroSalario();
            Salario novoSalario = cadastro.TelaCadastro(funcionario, cargo);
            Salarios.Add(novoSalario);
        }

        public List<Salario> ProcuraSalarioPorValor(decimal valor)
        {
            List<Salario> salariosEncontrados = Salarios.FindAll(s => s.Valor == valor);
            if (salariosEncontrados != null)
            {
                return salariosEncontrados;
            }
            else
            {
                Console.WriteLine("Salário não encontrado.");
            }
            return salariosEncontrados;
        }

        public List<Salario> ProcuraSalarioPorDataDeInicio(DateTime data)
        {
            List<Salario> salariosEncontrados = Salarios.FindAll(s => s.DataInicio == data);
            if (salariosEncontrados != null)
            {
                return salariosEncontrados;
            }
            else
            {
                Console.WriteLine("Salário não encontrado.");
            }
            return salariosEncontrados;
        }

        public List<Salario> ProcuraSalarioPorFuncionario(string nomeFuncionario)
        {
            List<Salario> salariosEncontrados = Salarios.FindAll(s => s.Funcionario.Nome == nomeFuncionario);
            if (salariosEncontrados != null)
            {
                return salariosEncontrados;
            }
            else
            {
                Console.WriteLine("Salário não encontrado.");
            }
            return salariosEncontrados;
        }

        public List<Salario> ProcuraSalarioPorCargo(string nomeCargo)
        {
            List<Salario> salariosEncontrados = Salarios.FindAll(s => s.Cargo.Nome == nomeCargo);
            if (salariosEncontrados != null)
            {
                return salariosEncontrados;
            }
            else
            {
                Console.WriteLine("Salário não encontrado.");
            }
            return salariosEncontrados;
        }

        public void RemoveSalario(Salario salario)
        {
            Salarios.Remove(salario);
        }

        //--------------------------------------------------Métodos para Folhas De Pagamento--------------------------------------------------

        public void CadastraFolhaPagamento(Empresa empresa, Salario salBruto, ItensFolha itens)
        {
            CadastroFolhaPagamento cadastro = new CadastroFolhaPagamento();
            FolhaPagamento novaFolhaP = cadastro.TelaCadastro(empresa, salBruto, itens);
            Folhas.Add(novaFolhaP);
        }

        public List<FolhaPagamento> ProcuraFolhaPorEmpresa(string nomeEmpresa)
        {
            List<FolhaPagamento> folhasEncontradas = Folhas.FindAll(f => f.Empresa.Nome == nomeEmpresa);
            if (folhasEncontradas != null)
            {
                return folhasEncontradas;
            }
            else
            {
                Console.WriteLine("Folha não encontrada.");
            }
            return folhasEncontradas;
        }

        public List<FolhaPagamento> ProcuraFolhaPorDataFechamento(DateTime fechamento)
        {
            List<FolhaPagamento> folhasEncontradas = Folhas.FindAll(f => f.DataFechamento == fechamento);
            if (folhasEncontradas != null)
            {
                return folhasEncontradas;
            }
            else
            {
                Console.WriteLine("Folha não encontrada.");
            }
            return folhasEncontradas;
        }
        
        public List<FolhaPagamento> ProcuraFolhaPorDataPagamento(DateTime pagamento)
        {
            List<FolhaPagamento> folhasEncontradas = Folhas.FindAll(f => f.DataPagamento == pagamento);
            if (folhasEncontradas != null)
            {
                return folhasEncontradas;
            }
            else
            {
                Console.WriteLine("Folha não encontrada.");
            }
            return folhasEncontradas;
        }

        public List<FolhaPagamento> ProcuraFolhaPorSalarioBruto(decimal valor)
        {
            List<FolhaPagamento> folhasEncontrados = Folhas.FindAll(f => f.SalarioBruto.Valor == valor);
            if (folhasEncontrados != null)
            {
                return folhasEncontrados;
            }
            else
            {
                Console.WriteLine("Folha não encontrada.");
            }
            return folhasEncontrados;
        }
        public List<FolhaPagamento> ProcuraFolhaPorVencimentos(decimal valor)
        {
            List<FolhaPagamento> folhasEncontrados = Folhas.FindAll(f => f.TotalVencimentos == valor);
            if (folhasEncontrados != null)
            {
                return folhasEncontrados;
            }
            else
            {
                Console.WriteLine("Folha não encontrada.");
            }
            return folhasEncontrados;
        }

        public List<FolhaPagamento> ProcuraFolhaPorItens(ItensFolha itens)
        {
            List<FolhaPagamento> folhasEncontrados = Folhas.FindAll(f => f.Itens == itens);
            if (folhasEncontrados != null)
            {
                return folhasEncontrados;
            }
            else
            {
                Console.WriteLine("Folha não encontrada.");
            }
            return folhasEncontrados;
        }

    }

}
