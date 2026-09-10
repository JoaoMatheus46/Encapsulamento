namespace Encapsulamento
{
    internal class Carro
    {
        private int _VelocidadeAtual;

        public int VelocidadeAtual
        {
            get { return _VelocidadeAtual; }
        }

        public void Acelerar()
        {
            _VelocidadeAtual += 10;
        }

        public void Frear()
        {
            if (_VelocidadeAtual >= 10)
            {
                _VelocidadeAtual -= 10;
            }
            else
            {
                _VelocidadeAtual = 0;
            }



        }
    }
}
