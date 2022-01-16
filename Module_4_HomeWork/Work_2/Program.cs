using System;
using static System.Console;

namespace Work_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            int _minValue = int.MaxValue;
            WriteLine("Задание #2");
            WriteLine("Введите размер массива");

            int[] _num = new int[int.Parse(ReadLine())];

            WriteLine("Введите числа через Ввод");
            for (int a = 0; a < _num.Length; a++)
            {
                _num[a] = int.Parse(ReadLine());
            }
            for (int a = 0; a < _num.Length; a++)
            {
                if (_num[a] < _minValue)
                {
                    _minValue = _num[a];
                }

                Write($"{_num[a]} ");
            }
            WriteLine();
            WriteLine($"Минимальное число : {_minValue}");
            ReadKey();
        }
    }
}
