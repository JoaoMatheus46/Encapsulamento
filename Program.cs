////PRODUTO - Encapsulamento
//namespace Encapsulamento
//{
//    internal class Produto
//    {
//        private double _preco;

//        public int MyProperty { get; set; }

//        public double Preco
//        {
//            get { return _preco; }
//            set
//            {
//                if (value < 0)
//                {
//                    Console.WriteLine("O preço é 0");
//                }
//                else
//                {
//                    _preco = value;
//                }
//            }
//        }
//    }
//}

////PESSOA - Encapsulamento
//namespace Encapsulamento
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Pessoa p = new Pessoa();
//            p.Nome = "João"; // Atribuindo valor ao nome usando a propriedade

//            Console.WriteLine(p.Nome);



//            Console.ReadKey();
//        }
//    }
//}

////CARRO - Encapsulamento
//namespace Encapsulamento
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Carro meuCarro = new Carro();

//            Console.WriteLine($"Velocidade inicial: {meuCarro.VelocidadeAtual} km/h");

//            meuCarro.Acelerar();
//            meuCarro.Acelerar();
//            Console.WriteLine($"Após acelerar duas vezes: {meuCarro.VelocidadeAtual} km/h");

//            meuCarro.Frear();
//            Console.WriteLine($"Após frear uma vez: {meuCarro.VelocidadeAtual} km/h");

//            Console.ReadKey();
//        }
//    }
//}


//TERMOMETRO - Encapsulamento
namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Termometro meuTermometro = new Termometro();

            meuTermometro.Celsius = 25;

            Console.WriteLine($"Celsius: {meuTermometro.Celsius} °C");
            Console.WriteLine($"Fahrenheit: {meuTermometro.Fahrenheit} °F");
            Console.WriteLine($"kelvin: {meuTermometro.Kelvin} °K");

            Console.WriteLine("--- Alterando Temperatura para Fahrenheit (68 °F) ---");
            meuTermometro.Fahrenheit = 68;

            Console.WriteLine($"Celsius: {meuTermometro.Celsius} °C");
            Console.WriteLine($"Fahrenheit: {meuTermometro.Fahrenheit} °F");
            Console.WriteLine($"Kelvin: {meuTermometro.Kelvin} K");

            Console.WriteLine("--- Alterando Temperatura para Kelvin (296.15 °K) ---");
            meuTermometro.Kelvin = 296.15;

            Console.WriteLine($"Celsius: {meuTermometro.Celsius} °C");
            Console.WriteLine($"Fahrenheit: {meuTermometro.Fahrenheit} °F");
            Console.WriteLine($"Kelvin: {meuTermometro.Kelvin} K");
        }
    }
}