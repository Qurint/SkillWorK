using static System.Console;

namespace Work_2
{
    internal class Program
    {
        static void SplitText(string _text)
        {
            string[] _letters = _text.Split(' ');

                Permutation(_letters);
           
        }

        static void Permutation(string[] _text)
        {
            string[] _letters = new string[_text.Length];
            for(int a = 0; a < _text.Length; a++)
            {
                _letters[a] = _text[a];
            }
            for(int a = _letters.Length -1; a >= 0; a--)
            {
                Write($"{_letters[a]} ");
            }
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
