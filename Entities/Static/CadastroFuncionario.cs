using Pim3Semestre.Entities.Enums;

namespace Pim3Semestre.Entities.Static
{
    public class CadastroFuncionario
    {
        
        public Funcionario TelaCadastro(Empresa empresa)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------NOVO FUNCIONARIO--------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados Pessoais:");
            Random random = new Random(); //Processo temporario para salvar id sem que o usuario tenha que informa-lo
            int id = random.Next();       // Random gera numero aleatorio e id recebe
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Data de nascimento (dd/MM/yyyy): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            Console.Write("Estado Civil: ");
            EstadoCivil estadoCivil = Enum.Parse<EstadoCivil>(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("------------------------ENDEREÇO------------------------");
            int idEndereco = random.Next();
            int idCidade = random.Next();
            //--------------------------------------------------------------------------
            Console.Write("Cidade: ");
            string nomeCidade = Console.ReadLine();
            Console.Write("Estado (UF): ");
            Estado uf = Enum.Parse<Estado>(Console.ReadLine());
            Cidade cidade = new Cidade(idCidade, nomeCidade, uf);
            //--------------------------------------------------------------------------
            Console.Write("Logradouro: ");
            string logradouro = Console.ReadLine();
            Console.Write("Número: ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("Bairro: ");
            string bairro = Console.ReadLine();
            Console.Write("Cep: ");
            string cep = Console.ReadLine();
            Endereco endereco = new Endereco(idEndereco, logradouro, num, bairro, cep, cidade);
            Console.Clear();
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------NOVO FUNCIONARIO--------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados de Funcionario:");
            int idFuncionario = random.Next();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data de admissão (dd/MM/yyyy): ");
            DateTime dataAdmissao = DateTime.Parse(Console.ReadLine());
            Console.Clear();
            Pessoa novoFuncionario = new Funcionario(id, endereco, nome, cpf, dataNascimento, estadoCivil, idFuncionario, email, dataAdmissao, empresa);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------FUNCIONARIO REGISTRADO--------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
            return (Funcionario)novoFuncionario;
        }
    }
}

