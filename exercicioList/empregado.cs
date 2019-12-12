using System.Globalization;

namespace exercicioList
{
	class Empregado
	{
		public int Id { get; private set; }
		public string Nome { get; private set; }
		public double Salario { get; private set; }

		public Empregado(int id, string nome, double salario)
		{
			Id = id;
			Nome = nome;
			Salario = salario;
		}

		public  void IncrementoSalario(double porcentagem)
		{
			porcentagem = Salario * porcentagem / 100;
		}

		public override string ToString()
		{
			return Id + ", " + Nome + "," + Salario.ToString("f2", CultureInfo.InvariantCulture);
		}
	}
}
