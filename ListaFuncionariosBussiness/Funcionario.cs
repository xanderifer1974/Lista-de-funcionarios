using System.Globalization;

namespace ListaFuncionariosBussiness
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int id, string nome)
        {
            Id = id;
            Nome = nome;
            Salario = 0;
        }

        public Funcionario(int id, string nome, double salario): this(id,nome)
        {
            SalarioInicial(salario);

        }

        private void SalarioInicial(double salarioInicial)
        {
            Salario += salarioInicial;
        }

        public void AumentarSalario(double percentual)
        {
            Salario += Salario * percentual;
        }
        
        public override string ToString()
        {
            return Id + "," + Nome + "," + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }

    }
}
