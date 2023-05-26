using Pim3Semestre.Entities.Enums;

namespace Pim3Semestre.Entities.Static
{
    public class CadastroUsuario
    {
        public Usuario TelaCadastro()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("--------------------NOVO USUARIO--------------------");
            Console.WriteLine("----------------------------------------------------");
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
            Console.WriteLine("----------------------ENDEREÇO----------------------");
            //--------------------------------------------------------------------------
            int idCidade = random.Next(); // Random gera numero aleatorio e id recebe
            Console.Write("Cidade: ");
            string nomeCidade = Console.ReadLine();
            Console.Write("Estado (UF): ");
            Estado uf = Enum.Parse<Estado>(Console.ReadLine());
            Cidade cidade = new Cidade(idCidade, nomeCidade, uf);
            //--------------------------------------------------------------------------
            int idEndereco = random.Next(); // Random gera numero aleatorio e id recebe
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
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("--------------------NOVO USUARIO--------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados de Usuario:");
            int idUsuario = random.Next(); // Random gera numero aleatorio e id recebe
            Console.Write("Defina seu login: ");
            string login = Console.ReadLine();
            Console.Write("Defina sua senha: ");
            string senha = Console.ReadLine();
            Console.Write("Confirmar senha: ");
            string confirmaSenha = Console.ReadLine();
            while (senha != confirmaSenha)
            {
                Console.WriteLine("\nSenhas não coincidem!");
                Console.Write("Confirmar senha: ");
                confirmaSenha = Console.ReadLine();
            }
            Console.Clear();
            Pessoa novoUsuario = new Usuario(id, endereco, nome, cpf, dataNascimento, estadoCivil, idUsuario, login, senha);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("--------------------USUARIO CRIADO--------------------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
            return (Usuario)novoUsuario;
        }
    }
}
