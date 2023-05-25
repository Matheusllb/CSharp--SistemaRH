using Pim3Semestre.Entities;
using Pim3Semestre.Entities.Enums;

namespace Pim3Semestre
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
            Random randomE = new Random();
            int idE = random.Next();
            Console.WriteLine("");
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("--------------------NOVO USUARIO--------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados de Usuario:");
            Random randomU = new Random();
            int idU = random.Next();
            Console.Write("Defina seu login: ");
            string login = Console.ReadLine();
            Console.Write("Defina sua senha: ");
            string senha = Console.ReadLine();
            Console.Write("Confirmar senha: ");
            string confirmaSenha = Console.ReadLine();
            while(senha != confirmaSenha)
            {
                Console.WriteLine("\nSenhas não coincidem!");
                Console.Write("Confirmar senha: ");
                confirmaSenha = Console.ReadLine();
            }
            Console.Clear();
            Pessoa novoUsuario = new Usuario(id, endereco, nome, cpf, estadoCivil, idU, login, senha);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("--------------------USUARIO CRIADO--------------------");
            Console.WriteLine("------------------------------------------------------");

        }
    }
}
