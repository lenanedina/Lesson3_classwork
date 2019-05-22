using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("вычисление");
		  double a = 12, b = 5, rezult;
			if (b == 0)
				Console.WriteLine("делитель равен 0");
			else
			{
				rezult = a / b;
				Console.WriteLine(rezult);
			}
		
			Console.WriteLine("вычисление");
			a = 2; double x = 90;
			if (x<60 && a<60)
				Console.WriteLine("Количество секунд не может быть больше 60");
			else
			{ rezult = a * x;
				Console.WriteLine(rezult);
			}
		}
			
	}
			
}
