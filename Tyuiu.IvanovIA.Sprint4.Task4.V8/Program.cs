using Tyuiu.IvanovIA.Sprint4.Task4.V8.Lib;
namespace Tyuiu.IvanovIA.Sprint4.Task4.V8
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

            int rows;
            Console.Write("Введите количество элементов массива: ");
            rows = Convert.ToInt32(Console.ReadLine());

            int cols;
            Console.Write("Введите количество элементов массива: ");
            cols = Convert.ToInt32(Console.ReadLine());


            int[,] matrix = new int[rows, cols];



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Console.Write("Введите значение элемента: ");
                        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Массив равен " + ds.Calculate(matrix));

            Console.ReadKey();


        }
    }
}