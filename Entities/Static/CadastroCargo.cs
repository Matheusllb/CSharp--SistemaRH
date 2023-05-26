namespace Pim3Semestre.Entities.Static
{
    public class CadastroCargo
    {
        public Cargo TelaCadastro(Empresa empresa)
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------NOVO CARGO--------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Dados Cargo:");
            Random random = new Random();  //Processo temporario para salvar id sem que o usuario tenha que informa-lo
            int id = random.Next();        // Random gera numero aleatorio e id recebe
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Clear();
            Cargo novoCargo = new Cargo(id, nome, empresa);
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("--------------------CARGO REGISTRADO--------------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("\nPressione 'Enter' para continuar...");
            Console.ReadKey();
            Console.Clear();
            return novoCargo;
        }
    }
}
