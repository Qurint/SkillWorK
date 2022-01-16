using System;
using static System.Console;

namespace Work_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _matrixSizeX;
            int _matrixSizeY;
            int _summa = 0;

            Random _randomNum = new Random(); ;

            WriteLine("Задание #1");
            ReadKey();
            WriteLine("Введите размер матрицы");
            WriteLine("Введите размер матрицы по X");
            _matrixSizeX = int.Parse(ReadLine());
            WriteLine("Введите размер матрицы по Y");
            _matrixSizeY = int.Parse(ReadLine());

            int[,] _matrix = new int[_matrixSizeX, _matrixSizeY];

            for (int a = 0; a < _matrix.GetLength(0); a++)
            {
                for (int i = 0; i < _matrix.GetLength(1); i++)
                {
                    _matrix[a, i] = _randomNum.Next(10);
                    Write($"{_matrix[a, i]} ");
                    _summa += _matrix[a, i];
                }
                WriteLine();
            }
            WriteLine($"Сумма всех чисел в матрице : {_summa}");
            ReadKey();
        }
    }
}
