using System;
using static System.Console;

namespace HomeW_4
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

            int[,] _matrix = new int[_matrixSizeX,_matrixSizeY];

            for (int a = 0; a < _matrix.GetLength(0); a++)
            { 
               for(int i = 0; i < _matrix.GetLength(1); i++)
                    {
                    _matrix[a, i] = _randomNum.Next(10);
                    Write($"{_matrix[a,i]} ");
                    _summa += _matrix[a,i];
                    }
                WriteLine();
            }
            WriteLine($"Сумма всех чисел в матрице : {_summa}");
            ReadKey();


            int _minValue = int.MaxValue;
            WriteLine("Задание #2");
            WriteLine("Введите размер массива");

            int[] _num = new int [int.Parse(ReadLine())];

            WriteLine("Введите числа через Ввод");
            for(int a = 0;a < _num.Length;a++)
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



            int _size;
            int _nowNum;
            bool _win = false;
            Random _numRandom = new Random();

            WriteLine("Задание #3");
            WriteLine("Введите диапазон загаданного числа");

            _size = int.Parse(ReadLine());
            int _numWin = _numRandom.Next(_size);

            WriteLine("Игра началась");
            WriteLine("Если устал нажми - пробел");
            while (true)
            {
                if (ReadKey().Key == ConsoleKey.Spacebar)
                {
                    break;
                }
                WriteLine("Введи число");
              
                _nowNum = int.Parse(ReadLine());

                if (_nowNum > _numWin)
                {
                    WriteLine("Введенное число больше заданного");
                } else if (_nowNum < _numWin)
                {
                    WriteLine("Введенное число меньше заданного");
                } else if (_numWin == _nowNum)
                {
                    _win = true;
                    break;
                }
            }
            if (!_win)
            {
                WriteLine($"Заданное число было {_numWin} ты был близок )");
            }
            else
            {
                WriteLine("Вы победили!!!!!!!!!!!");
            }

            ReadKey();
        }
    }
}
