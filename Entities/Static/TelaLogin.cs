using Pim3Semestre.Entities;
using Pim3Semestre.Entities.Enums;

namespace Pim3Semestre.Entities.Static
{
    public static class TelaLogin
    {
        public static void Cadastro()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("--------------------NOVO USUARIO--------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados Pessoais:");
            Random random = new Random();
            int id = random.Next();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CPF: ");
            string cpf = Console.ReadLine();
            Console.Write("Estado Civil: ");
            EstadoCivil estadoCivil = Enum.Parse<EstadoCivil>(Console.ReadLine());
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("----------------------ENDEREÇO----------------------");
            Console.WriteLine("----------------------------------------------------");
            int idEndereco = random.Next();
            int idCidade = random.Next();
            //--------------------------------------------------------------------------
            Console.Write("Cidade: ");
            string nomeCidade = Console.ReadLine();
            Console.WriteLine("Estado (UF):");
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
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("--------------------NOVO USUARIO--------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados de Usuario:");
            int idUsuario = random.Next();
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
            Pessoa novoUsuario = new Usuario(id, endereco, nome, cpf, estadoCivil, idUsuario, login, senha);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("--------------------USUARIO CRIADO--------------------");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadKey();
        }
    }
}
