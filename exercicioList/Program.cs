using System;
using System.Globalization;
using System.Collections.Generic;

namespace exercicioList
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("quantos empregados serao registrados?");
			int employee = int.Parse(Console.ReadLine());

			List<Empregado> emp = new List<Empregado>();

			for (int i = 1; i <= employee; i++)
			{
				Console.Write("Id");
				int id = int.Parse(Console.ReadLine());
				Console.Write("Nome: ");
				string nome = Console.ReadLine();
				Console.WriteLine("Salario : ");
				double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
				emp.Add(new Empregado(id, nome, salario));
			}
			Console.WriteLine("entre com a id do funcionario que tera um aumento de salario : ");
			int aumento = int.Parse(Console.ReadLine());

			Empregado search = emp.Find(x => x.Id == aumento);
			emp = null;
			if(search != null)
			{
				Console.WriteLine("entre com o valor do aumento");
				int porc = int.Parse(Console.ReadLine());

				foreach(Empregado obj in emp)
				{
					Console.WriteLine("lista atualizada de emmpregados: ");
					Console.WriteLine(obj);
				}
			}
			else
			{
				foreach (Empregado obj in emp)
				{
					Console.WriteLine("lista atualizada de emmpregados: ");
					Console.WriteLine(obj);
				}
			}
		}
	}
}
