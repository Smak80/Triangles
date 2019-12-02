using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
	class Program
	{
		static void Main(string[] args)
		{
			int n;
			string ui;
			do
			{
				Console.Write("Введите число точек, которые нужно разместить на плоскости: ");
				ui = Console.ReadLine();
			} while (!int.TryParse(ui, out n));
		}
	}
}
