using System;
using static System.Console;

namespace Work_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                }
                else if (_nowNum < _numWin)
                {
                    WriteLine("Введенное число меньше заданного");
                }
                else if (_numWin == _nowNum)
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
