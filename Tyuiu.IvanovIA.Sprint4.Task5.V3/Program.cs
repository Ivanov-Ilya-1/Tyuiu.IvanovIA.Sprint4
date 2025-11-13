using Tyuiu.IvanovIA.Sprint4.Task5.V3.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();



            Console.Title = "Спринт #4 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #4                                                                *");
            Console.WriteLine(" Тема : Двумерные массивы                                                 *");
            Console.WriteLine(" Задание #3                                                               *");
            Console.WriteLine(" Вариант #15                                                              *");
            Console.WriteLine(" Выполнил : Иванов Илья Анатольевич | ИИПБ-25-1                           *");
            Console.WriteLine(" Спринт #4                                                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" УСЛОВИЕ:                                                                 *");
            Console.WriteLine(" Дан одномерный целочисленный массив на 10 элементов  заполненный         *");
            Console.WriteLine(" статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных    *");
            Console.WriteLine(" *                                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("***************************************************************************");

            int[,] nums = new int[5, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (nums[i, j] % 2 == 0)
                    {
                        nums[i, j] = rnd.Next(-5, 4);
                    }
                }
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Нечетных чисел = " + ds.Calculate(nums));

            Console.ReadKey();


        }
    }
}