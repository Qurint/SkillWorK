using static System.Console;
using static System.Convert;
using static System.IO.File;
namespace AddPerson
{
    internal class Program
    {
        static int _agePerson;
        static int _dateOfBirth;
        static int _dayOfBirth;
        static int _mounthOfBirth;
        static int _yearOfBirth;
        static int _badNum;
        static int _growth;

        static int _timeAddTextHour;
        static int _timeAddTextMinute;
        static int _timeAddTextSecond;
        static int _timeAddTextMonth;
        static int _timeAddTextYear;
        static int _timeAddTextDay;

        static string _down = "\n";
        static string[] _words;
        static string _text;
        static string _fullNamePerson;
        static string _placeOfBirth;
        static string _next;
        static string[] _lineText;
        static void Main(string[] args)
        {
            WriteLine($"Привет!, скажите пожалуйста, вы хотите внести сотрудника или прочитать имеющейся список ? \nДля выбора введите -r- для чтения и -w- для записи");

            for (; ; )
            {
                _next = ReadLine();
                if (_next == "r" || _next == "R")
                {
                    ReadDocument();
                    break;
                }
                else if (_next == "w" || _next == "W")
                {
                    IntroductionData();
                    break;
                }
                else
                {
                    WriteLine($"Привет!, скажите пожалуйста, вы хотите внести сотрудника или прочитать имеющейся список ? \nДля выбора введите -r- для чтения и -w- для записи");
                }
            }
        }

        static void ReadDocument()
        {
            if (Exists(@"d:\PersonDocument.txt"))
            {
                _lineText = ReadAllLines(@"d:\PersonDocument.txt");
                for(int a = 0;a < _lineText.Length * 6;a++ )
                {
                    if (_lineText.Length - 1 >= a) 
                    {
                        _words = _lineText[a].Split('#');
                    }
              
                    Write($" {_words[a]}");
                    if(a == 5)
                    {
                        WriteLine();
                    }
                }
                ReadKey();
            }
            else
            {
                WriteLine($"Прошу прощения, но файла не существует, хотите создать его или выйти для создания нажмите -w- для выхода -e-");
                for (; ; )
                {
                    _next = ReadLine();
                    if (_next == "e" || _next == "E")
                    {
                        break;
                    }
                    else if (_next == "w" || _next == "W")
                    {
                        IntroductionData();
                        break;
                    }
                    else
                    {
                        WriteLine($"Прошу прощения, но файла не существует, хотите создать его или выйти для создания нажмите -w- для выхода -e-");
                    }
                }
            }
        }
        static void IntroductionData()
        {
            WriteLine($"Привет!!!");
            WriteLine($"Я помощник по внесению сотрудников в нашу любимую студию)");
            WriteLine($"---Для начала работы нажмите любую клавишу---");
            ReadKey();
            WriteLine($"Для начала давайте узнаем как зовут везунчика,\nвведите ФИО разделяя пробелом");
            _fullNamePerson = ReadLine();
            WriteLine($"Хорошо!, теперь давай узнаем дату рождения нового сотрудника,\nвведите дату рождения слитно, с начала - день месяц год например 10122001");
            _dateOfBirth = ToInt32(ReadLine());

            _dayOfBirth = _dateOfBirth / 1000000;
            _yearOfBirth = _dateOfBirth % 10000;
            _badNum = _dateOfBirth % 1000000;
            _mounthOfBirth = _badNum / 10000;

            _timeAddTextHour = System.DateTime.Now.Hour;
            _timeAddTextMinute = System.DateTime.Now.Minute;
            _timeAddTextSecond = System.DateTime.Now.Second;
            _timeAddTextDay = System.DateTime.Now.Day;
            _timeAddTextMonth = System.DateTime.Now.Month;
            _timeAddTextYear = System.DateTime.Now.Year;

            if(_timeAddTextMonth == _mounthOfBirth)
            {
                if(_timeAddTextDay >= _dayOfBirth)
                {
                 _agePerson = _timeAddTextYear - _yearOfBirth;
                }
            }else if(_timeAddTextMonth > _mounthOfBirth)
            {
                _agePerson = _timeAddTextYear - _yearOfBirth;
            }
            else
            {
                _agePerson = _timeAddTextYear - _yearOfBirth - 1;
            }

            WriteLine($"Класс, теперь нужен рост нашего героя, вдруг в нашем царстве он не пройдет в дверь),\nвведите рост в мм");
            _growth = ToInt32(ReadLine());
            WriteLine($"Вот и все, осталось лишь ввести город, где родился наш человечек,\nвведите город с заглавной буковки(Ох уж этот Русский)");
            _placeOfBirth = ReadLine();
            ReconciliationData();
        }
        static void ReconciliationData()
        {
            WriteLine($"Теперь давай сверим данные \n Нажми любую клавишу если готов");
            ReadKey();
            WriteLine($"ФИО {_fullNamePerson} \nДата рождения {_dayOfBirth}.{_mounthOfBirth}.{_yearOfBirth} \nВозраст получается {_agePerson} \nРост {_growth} \nИ родился он в {_placeOfBirth}");
            WriteLine($"Все верно или хотите повторить ввод данных ? \nЕсли все верно нажмите -y- , иначе -n-");
            for (; ; )
            {
                _next = ReadLine();
                if (_next == "y")
                {
                    CreatingDocument();
                    break;
                }
                else if (_next == "n")
                {
                    IntroductionData();
                    break;
                }
                else
                {
                    WriteLine($"Все верно или хотите повторить ввод данных ? \nЕсли все верно нажмите -y- , иначе -n- и нажмите Enter");
                }
            }
        }
        static void CreatingDocument()
        {
            int _iD = 0;

            if (Exists(@"d:\PersonDocument.txt"))
            {
                _text = ReadAllText(@"d:\PersonDocument.txt");
                _lineText = ReadAllLines(@"d:\PersonDocument.txt");

                _words = _lineText[_lineText.Length - 1].Split('#');

                if (ToInt32(_words[0]) > 0)
                {
                    _iD = ToInt32(_words[0]) + 1;
                }
                else
                {
                    _iD = 1;
                    _down = null;
                }

            }

            _text += $"{_down}{_iD}#{_timeAddTextDay}.{_timeAddTextMonth}.{_timeAddTextYear}#{_fullNamePerson}" +
                $" {_timeAddTextHour}:{_timeAddTextMinute}:{_timeAddTextSecond}#{_agePerson}#{_growth}#{_dayOfBirth}.{_mounthOfBirth}.{_yearOfBirth}#{_placeOfBirth}";

            WriteLine(_text);
            ReadKey();

            WriteAllText (@"d:\PersonDocument.txt",_text);
        }
    }
}
