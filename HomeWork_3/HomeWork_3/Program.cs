using System;
using static System.Console;
namespace HomeWork_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int _number;

            _number = int.Parse(ReadLine());

            if (_number % 2 == 0)
            {
              WriteLine($"Число {_number} четное");
            }
            else
            {
              WriteLine($"Число {_number} не четное");
            }

            ReadKey();

            int _summ = 0;
            int _numСards;
            string[] _Card = new string[10]; 

            WriteLine("Введите число карт на руках");

            
            _numСards = int.Parse(ReadLine());

            for(int a = 0; a < _numСards; a++)
            {
                WriteLine($"Введите номинал {a + 1} карты");

                _Card[a] = ReadLine();

                _summ += int.Parse(_Card[a]);

                switch (int.Parse(_Card[a]))
                {
                    case 2:
                        _Card[a] = "J";
                        break;
                    case 3:
                        _Card[a] = "Q";
                        break;
                    case 4:
                        _Card[a] = "K";
                        break;
                    case 11:
                        _Card[a] = "T";
                        break;
                }
            }

            ReadKey();

            Write("Ваши карты : ");

            for (int a = 0; a < _numСards; a++)
            {
                Write($" {_Card[a]}");
            }

            WriteLine("");
            WriteLine($"Сумма Ваших карт {_summ}");

            ReadKey();

            int _primeNumber;

            WriteLine($"Введите простое число");

           _primeNumber = int.Parse(ReadLine());
            int i = 2;

            bool result = true;
                while (i <= _primeNumber / 2)
                {
                    i++;
                    if (_primeNumber % i == 0)
                    {
                        result = false;
                        break;
                    }

                }
            if (!result)
            {
                WriteLine("Число не простое");
            }
            if (result)
            {
                WriteLine("Число простое");
            }

            ReadKey();
        }
    }
}
