using static System.Console;
using static System.Convert;
using static System.IO.File;
namespace AddPerson
{
    internal class Program
    {
        static int AgePerson;
        static int DateOfBirth;
        static int DayOfBirth;
        static int MounthOfBirth;
        static int YearOfBirth;
        static int BadNum;
        static int Growth;

        static int TimeAddTextHour;
        static int TimeAddTextMinute;
        static int TimeAddTextSecond;
        static int TimeAddTextMonth;
        static int TimeAddTextYear;
        static int TimeAddTextDay;

        static string Down = "\n";
        static string[] Words;
        static string Text;
        static string FullNamePerson;
        static string PlaceOfBirth;
        static string Next;
        static string[] LineText;
        static void Main(string[] args)
        {
            WriteLine($"Привет!, скажите пожалуйста, вы хотите внести сотрудника или прочитать имеющейся список ? \nДля выбора введите -r- для чтения и -w- для записи");

            for (; ; )
            {
                Next = ReadLine();
                if (Next == "r" || Next == "R")
                {
                    ReadDocument();
                    break;
                }
                else if (Next == "w" || Next == "W")
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
                LineText = ReadAllLines(@"d:\PersonDocument.txt");
                for(int a = 0;a < LineText.Length * 6;a++ )
                {
                    if (LineText.Length - 1 >= a)  
                    Words = LineText[a].Split('#');
                    
                    if (Words.Length - 1 >= a)
                    Write($" {Words[a]}");

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
                    Next = ReadLine();
                    if (Next == "e" || Next == "E")
                    {
                        break;
                    }
                    else if (Next == "w" || Next == "W")
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
            FullNamePerson = ReadLine();
            WriteLine($"Хорошо!, теперь давай узнаем дату рождения нового сотрудника,\nвведите дату рождения слитно, с начала - день месяц год например 10122001");
            DateOfBirth = ToInt32(ReadLine());

            DayOfBirth = DateOfBirth / 1000000;
            YearOfBirth = DateOfBirth % 10000;
            BadNum = DateOfBirth % 1000000;
            MounthOfBirth = BadNum / 10000;

            TimeAddTextHour = System.DateTime.Now.Hour;
            TimeAddTextMinute = System.DateTime.Now.Minute;
            TimeAddTextSecond = System.DateTime.Now.Second;
            TimeAddTextDay = System.DateTime.Now.Day;
            TimeAddTextMonth = System.DateTime.Now.Month;
            TimeAddTextYear = System.DateTime.Now.Year;

            if(TimeAddTextMonth == MounthOfBirth)
            {
                if(TimeAddTextDay >= DayOfBirth)
                {
                 AgePerson = TimeAddTextYear - YearOfBirth;
                }
            }else if(TimeAddTextMonth > MounthOfBirth)
            {
                AgePerson = TimeAddTextYear - YearOfBirth;
            }
            else
            {
                AgePerson = TimeAddTextYear - YearOfBirth - 1;
            }

            WriteLine($"Класс, теперь нужен рост нашего героя, вдруг в нашем царстве он не пройдет в дверь),\nвведите рост в мм");
            Growth = ToInt32(ReadLine());
            WriteLine($"Вот и все, осталось лишь ввести город, где родился наш человечек,\nвведите город с заглавной буковки(Ох уж этот Русский)");
            PlaceOfBirth = ReadLine();
            ReconciliationData();
        }
        static void ReconciliationData()
        {
            WriteLine($"Теперь давай сверим данные \n Нажми любую клавишу если готов");
            ReadKey();
            WriteLine($"ФИО {FullNamePerson} \nДата рождения {DayOfBirth}.{MounthOfBirth}.{YearOfBirth} \nВозраст получается {AgePerson} \nРост {Growth} \nИ родился он в {PlaceOfBirth}");
            WriteLine($"Все верно или хотите повторить ввод данных ? \nЕсли все верно нажмите -y- , иначе -n-");
            for (; ; )
            {
                Next = ReadLine();
                if (Next == "y")
                {
                    CreatingDocument();
                    break;
                }
                else if (Next == "n")
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
            int iD = 0;

            if (Exists(@"d:\PersonDocument.txt"))
            {
                Text = ReadAllText(@"d:\PersonDocument.txt");
                LineText = ReadAllLines(@"d:\PersonDocument.txt");

                Words = LineText[LineText.Length - 1].Split('#');

                if (ToInt32(Words[0]) > 0)
                {
                    iD = ToInt32(Words[0]) + 1;
                }
                else
                {
                    iD = 1;
                    Down = null;
                }

            }

            Text += $"{Down}{iD}#{TimeAddTextDay}.{TimeAddTextMonth}.{TimeAddTextYear}#{FullNamePerson}" +
                $"#{TimeAddTextHour}:{TimeAddTextMinute}:{TimeAddTextSecond}#{AgePerson}#{Growth}#{DayOfBirth}.{MounthOfBirth}.{YearOfBirth}#{PlaceOfBirth}";

            WriteLine(Text);
            ReadKey();

            WriteAllText (@"d:\PersonDocument.txt",Text);
        }
    }
}
