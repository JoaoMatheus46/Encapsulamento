    public class Pessoa
    {
        public string _nome;

        public int MyProperty { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Nome não pode ser nulo");
                }
                else
                {
                    _nome = value;
                }
            }
        }
    }
