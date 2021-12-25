using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HomeWC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _inirials;
            int _age;
            string _email;
            float _progScores = 95.2f;
            float _mathScores = 80.1f;
            float _phyScores = 35.3f;
            float _summScores;
            float _midScores;

            _summScores = _progScores + _mathScores + _phyScores;
            _midScores = _summScores / 3f;

            WriteLine("Привет" + " Введите свою ФИО");
            _inirials = ReadLine();
            WriteLine("Теперь ваш возраст");
            _age = Convert.ToInt32(ReadLine());
            WriteLine("Теперь вашу почту");
            _email = ReadLine();

            Write("{0} \nВаш возраст: {1}  \nВаша почта: {2}  \nВаш бал по программированию {3} \nВаш бал по математике {4} \nВаш бал по физике {5}",
                             _inirials,
                                  _age,
                                _email,
                           _progScores,
                           _mathScores,
                            _phyScores);

            ReadKey();

            Write("\nСумма ваших баллов: {0}  \nСреднее арифметическое ваших баллов : {1}",
                        _summScores,
                        _midScores);

            ReadKey();
              
        }
    }
}
