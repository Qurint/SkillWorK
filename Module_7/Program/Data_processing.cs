using static System.Console;
using static System.Convert;
using static System.IO.File;
namespace Program
{
    struct Data_processing
    {
        string _fileDataPerson;
        string[] _lineDataPerson;

        public void ReadDataPerson()
        {
            string[] _indexPerson = new string [10];
            string[] _fullName = new string [50];
            string[] _age = new string[50];
            string[] _growth = new string[50];
            string[] _dateOfBirth = new string[50];
            string[] _placeOfBirth = new string[50];
            string[] _timeCreate = new string[50];
            string[] _dataCreate = new string[50];
            int _index = 0;
            string _name;
            string _data;
            string _next;

            _fileDataPerson = ReadAllText(@"D:/PersonDocument.txt");

            _lineDataPerson = _fileDataPerson.Split('#'); //Делем данные в файле на подпункты

            for (int i = 0; i < _lineDataPerson.Length; i++)// Привязываем все полученые данные к переменнымЫ
            {
                if (i == 0)
                {
                    _indexPerson[i] = _lineDataPerson[i];
                }
                else if (i % 8 == 0)
                {
                    _indexPerson[i / 8] = _lineDataPerson[i];
                }
                else if (i % 8 == 1 && i != 0)
                {
                    _fullName[i / 8] = _lineDataPerson[i];
                }
                else if (i % 8 == 2 && i != 0)
                {
                    _age[i / 8] = _lineDataPerson[i];
                }
                else if (i % 8 == 3 && i != 0)
                {
                    _growth[i / 8] = _lineDataPerson[i];
                }
                else if (i % 8 == 4 && i != 0)
                {
                    _dateOfBirth[i / 8] = _lineDataPerson[i];
                }
                else if (i % 8 == 5 && i != 0)
                {
                    _placeOfBirth[i / 8] = _lineDataPerson[i];
                }
                else if (i % 8 == 6 && i != 0)
                {
                    _timeCreate[i / 8] = _lineDataPerson[i];
                }
                else if (i % 8 == 7 && i != 0)
                {
                    _dataCreate[i / 8] = _lineDataPerson[i];
                }
            }

              // создаем сотрудника с привязкой к данным
            Persons personData = new Persons(
                new PersonData(),
                new PersonData(),
                new PersonData(),
                new PersonData(),
                new PersonData(),
                new PersonData(),
                new PersonData(),
                new PersonData(),
                new PersonData(),
                new PersonData(),
                new PersonData()
                );

            for(int i = 0; i < _indexPerson.Length; i++)
            {
                personData[i] = new PersonData(_indexPerson[i], _fullName[i], _age[i], _growth[i],
                _dateOfBirth[i], _placeOfBirth[i], _timeCreate[i], _dataCreate[i]);
            }
            WriteLine("Какой именно будем искать сотрудника -n- если имя -d- если дата создания документа -i- если индекс");
            for (; ; )
            {
                _next = ReadLine();
                if (_next == "n" || _next == "N")
                {
                    WriteLine("Введите имя сотрудника как было зарегистрировано");
                    _name = ReadLine();
                    for (int i = 0; i < _indexPerson.Length; i++)
                    {
                        if (personData[i].FirstName() == _name)
                        {
                            WriteLine(personData[i].Print());
                            break;
                        }
                    }
                    break;
                }
                else if (_next == "i" || _next == "i")
                {
                    WriteLine("Введите номер сотрудника");
                    _index = ToInt32(ReadLine());
                    WriteLine(personData[_index - 1].Print());
                    break;
                }
                else if (_next == "d" || _next == "d")
                {
                    WriteLine("Введите дату как было зарегистрировано, пример 20.4.2022");
                    _data = ReadLine();
                    for (int i = 0; i < _indexPerson.Length; i++)
                    {
                        if (personData[i].DataCreate() == _data)
                        {
                            WriteLine(personData[i].Print());
                            break;
                        }
                    }
                    break;
                }
                else
                {
                    WriteLine($"Какой именно будем искать сотрудника -n- если имя -d- если дата создания документа -i- если индекс");
                }
            } // проверка и сортировка сотрудника по выброному поиску 
            ReadKey();
        }

        public void CreatingDocument()
        {
            int _num = 0;
            string[] _indexPerson = new string[50];
            string _fullName;
            string _age;
            string _growth;
            string _dateOfBirth;
            string _placeOfBirth;
            string _timeCreate;
            string _dataCreate;
            int _indexNext;
            //читаем файл и начинаем создание нового сотрудника
            _fileDataPerson = ReadAllText(@"D:/PersonDocument.txt");
            _lineDataPerson = _fileDataPerson.Split('#');
            for (int i = 0; i < _lineDataPerson.Length; i++)// Привязываем все полученые данные к переменнымЫ
            {
                if (i == 0)
                {
                    _indexPerson[i] = _lineDataPerson[i];
                }
                else if (i % 8 == 0)
                {
                    _indexPerson[i / 8] = _lineDataPerson[i];
                }
             
            }

            WriteLine($"Привет!!!");
            WriteLine($"Я помощник по внесению сотрудников в нашу любимую студию)");
            WriteLine($"---Для начала работы нажмите любую клавишу---");
            ReadKey();
            WriteLine($"Для начала давайте узнаем как зовут везунчика,\nвведите ФИО разделяя пробелом");
            _fullName = ReadLine();
            WriteLine($"Хорошо!, теперь давай узнаем дату рождения нового сотрудника,\nвведите дату рождения, день месяц год например 01.01.1991");
            _dateOfBirth = ReadLine();
            WriteLine($"Теперь введите сколько лет, нашему герою");
            _age = ReadLine();
            WriteLine($"Класс, теперь нужен рост нашего героя, вдруг в нашем царстве он не пройдет в дверь),\nвведите рост в мм");
            _growth = ReadLine();
            WriteLine($"Вот и все, осталось лишь ввести город, где родился наш человечек,\nвведите город с заглавной буковки(Ох уж этот Русский)");
            _placeOfBirth = ReadLine();

            _timeCreate = $"{System.DateTime.Now.Hour}:{System.DateTime.Now.Minute}:{System.DateTime.Now.Second}";
            _dataCreate = $"{System.DateTime.Now.Day}.{System.DateTime.Now.Month}.{System.DateTime.Now.Year}";

            Persons personData = new Persons(
               new PersonData("0", _fullName, _age, _growth,
               _dateOfBirth, _placeOfBirth, _timeCreate, _dataCreate)
               );

            WriteLine($"Ваш сотрудник\n{personData[0]}");

            WriteLine($"Если вас не устраивает нажмите -n-, если все хорошо, -y-");

            for (; ; )
            {
               string _next = ReadLine();
                if (_next == "y")
                {
                    break;
                }
                else if (_next == "n")
                {
                    CreatingDocument();
                    break;
                }
                else
                {
                    WriteLine($"Если вас не устраивает нажмите -n-, если все хорошо, -y-");
                }
            }
            for (int i = 0; i < _lineDataPerson.Length; i++)// Привязываем все полученые данные к переменнымЫ
            {
                if (i == 0)
                {
                    _indexPerson[i] = _lineDataPerson[i];
                }
                else if (i % 8 == 0)
                {
                    _indexPerson[i / 8] = _lineDataPerson[i];
                }
            }

            for(int i = 0; ; i++ )
            {
               if (_indexPerson[i] != null)
                {
                    _num++;
                }
                else
                {
                    break;
                }
            }
            //находим индекс и записываем новые данные
            _indexNext = ToInt32(_indexPerson[_num - 2]) + 1;
            _fileDataPerson += $"\n{_indexNext}#{_fullName}#{_age}" +
                $"#{_growth}#{_dateOfBirth}#{_placeOfBirth}#{_timeCreate}#{_dataCreate}#";
            WriteLine(_fileDataPerson);
            ReadKey();

            WriteAllText(@"d:\PersonDocument.txt", _fileDataPerson);
        }
      
    }
}
