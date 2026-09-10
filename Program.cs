namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "João"; // Atribuindo valor ao nome usando a propriedade
            
            Console.WriteLine(p.Nome);



            Console.ReadKey();
        }
    }
}
