using Tyuiu.IvanovIA.Sprint4.Task1.V5.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task1.V5
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
            Console.WriteLine(" Задание #1                                                               *");
            Console.WriteLine(" Вариант #5                                                               *");
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

            int len;
            Console.Write("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];

            for (int i = 0; i < len - 1; i++)
            {
                Console.Write("Введите значение элемента: ");
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.Write("Массив: ");
            for (int i = 0; i < len - 1; i++)
            {
                Console.WriteLine(array[i]);

            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Сумма массива = " + ds.Calculate(array));

            Console.ReadKey();


        }
    }
}
