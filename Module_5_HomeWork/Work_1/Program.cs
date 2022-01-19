using static System.Console;

namespace Work_1
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param Split="Ввод входных данных и их обработка"></param>
        static void SplitText(string _text)
        {
            string[] _letters = _text.Split(' ');

            foreach (var _letter in _letters)
            {
                 Conclusion(_letter);
            }
        }
        static void Conclusion(string _text)
        {
            WriteLine($"Вывод : {_text} ");
        }

            static void Main(string[] args)
        {
            string _text;
            _text = ReadLine();            

            SplitText(_text);

            ReadKey();
           
        }
    }
}
