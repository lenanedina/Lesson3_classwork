using System;

namespace ConsoleApp13
{
	class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Введите время (минут) -> ");
            int minutes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Введите время (секунд) -> ");
            int seconds = Convert.ToInt16(Console.ReadLine());

            if (minutes < 0) {
                Console.WriteLine("Количество минут не может быть меньше 0");
            } else {
                if (seconds >60) {
                    Console.WriteLine("Количество секунд не может быть больше 60");
                } else {
                    int result=minutes*60+seconds;
                    Console.WriteLine("Общее количество секунд: "+result);
                }
            }
		}
	}			
}
