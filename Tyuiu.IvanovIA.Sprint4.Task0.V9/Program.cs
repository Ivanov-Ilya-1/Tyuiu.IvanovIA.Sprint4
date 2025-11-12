using Tyuiu.IvanovIA.Sprint4.Task0.V9.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task0.V9 
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();



            Console.Title = "Спринт #4 | Выполнил: Иванов И. А. | ИИПБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Спринт #4                                                                *");
            Console.WriteLine(" Тема : Одномерные массивы                                                *");
            Console.WriteLine(" Задание #0                                                               *");
            Console.WriteLine(" Вариант #9                                                               *");
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

            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            for (int i = 0; i < array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
                
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Сумма массива = " + ds.GetSumEvenArrEl(array));

            Console.ReadKey();


        }
    }
}
