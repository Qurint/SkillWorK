using static System.Console;
using static System.Convert;
using static System.IO.File;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string _next;
            Data_processing data_Processing = new Data_processing();

            WriteLine($"Привеет, это ваш помощник по просмотру и записи сотрудников");
            WriteLine($"Нажмите -r- для прочтания сотрудников, -w- для создания нового");

            for (; ; )
            {
                _next = ReadLine();
                if (_next == "r" || _next == "R")
                {
                    data_Processing.ReadDataPerson();
                    break;
                }
                else if (_next == "w" || _next == "W")
                {
                  data_Processing.CreatingDocument();
                    break;
                }
                else
                {
                    WriteLine($"Привет!, скажите пожалуйста, вы хотите внести сотрудника или прочитать имеющейся ? \nДля выбора введите -r- для чтения и -w- для записи");
                }
            }

        }
    }
}
