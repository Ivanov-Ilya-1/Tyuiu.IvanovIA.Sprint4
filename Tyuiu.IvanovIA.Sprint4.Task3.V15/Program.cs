using Tyuiu.IvanovIA.Sprint4.Task3.V15.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task3.V15
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

            int[,] nums = new int[5, 5]
            {   { 7, 4, 2, 5, 3 },
                { 4, 3, 2, 5, 6 },
                { 6, 3, 4, 7, 5 },
                { 5, 7, 4, 3, 8 },
                { 7, 8, 8, 5, 6 } };


            int rows = nums.GetUpperBound(0) + 1;
            int cols = nums.Length / rows;

            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Нечетных чисел = " + ds.Calculate(nums));

            Console.ReadKey();


        }
    }
}
