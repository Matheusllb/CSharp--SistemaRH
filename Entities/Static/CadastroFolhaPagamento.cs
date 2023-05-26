using System.Globalization;

namespace Pim3Semestre.Entities.Static
{
    public class CadastroFolhaPagamento
    {
        public FolhaPagamento TelaCadastro(Empresa empresa, Salario salario, ItensFolha itens)
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("--------------------NOVA FOLHA-DE-PAGAMENTO--------------------");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados Iniciais:");
            Random random = new Random();
            int id = random.Next();
            Console.Write("Data do fechamento: ");
            DateTime dataFec = DateTime.Parse(Console.ReadLine());
            Console.Write("Data do pagamento: ");
            DateTime dataPag = DateTime.Parse(Console.ReadLine());
            Console.Write("Salario bruto R$: ");
            decimal salBruto = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Hora-extra: ");
            decimal horaExtra = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Clear();
            FolhaPagamento novaFolhaP = new FolhaPagamento(id, empresa, dataPag, salario, horaExtra, itens);
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("--------------------FOLHA REGISTRADA--------------------");
            Console.WriteLine("--------------------------------------------------------------");
            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
            return novaFolhaP;
        }
    }
}
