using System;

namespace ConsoleApp13
{
	class Program
	{
		static void Main(string[] args)
		{
            //task3();
            task10();
		}

        private static void task3()
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

        private static void task10()
        {
            Console.WriteLine("В каком году началась вторая мировая война?");
            int data = Convert.ToInt32(Console.ReadLine());
            if(data != 1939) 
            {
                Console.WriteLine("Верный ответ - 1939 год");
            } else {
                Console.WriteLine("Верный ответ!!!!!");
            }
        }
	}	
    
}
