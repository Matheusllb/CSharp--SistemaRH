using Pim3Semestre.Entities.Enums;

namespace Pim3Semestre.Entities.Static
{
    public class CadastroEmpresa
    {
        public Empresa TelaCadastro()
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("--------------------NOVA EMPRESA--------------------");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados Empresariais:");
            Random random = new Random();
            int id = random.Next();
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("CNPJ: ");
            string cnpj = Console.ReadLine();
            Console.Write("Setor: ");
            string setor = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("----------------------ENDEREÇO----------------------");
            //--------------------------------------------------------------------------
            int idCidade = random.Next();
            Console.Write("Cidade: ");
            string nomeCidade = Console.ReadLine();
            Console.WriteLine("Estado (UF):");
            Estado uf = Enum.Parse<Estado>(Console.ReadLine());
            Cidade cidade = new Cidade(idCidade, nomeCidade, uf);
            //--------------------------------------------------------------------------
            int idEndereco = random.Next();
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
            Empresa novaEmpresa = new Empresa(id, nome, cnpj, setor, email, telefone, endereco);
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("--------------------EMPRESA REGISTRADA--------------------");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
            return (novaEmpresa);
        }
    }
}
