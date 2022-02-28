using static System.Console;
using static System.Convert;
using static System.IO.File;
namespace AddPerson
{
    internal class Program
    {
        static int agePerson;
        static int dateOfBirth;
        static int dayOfBirth;
        static int mounthOfBirth;
        static int yearOfBirth;
        static int badNum;
        static int growth;

        static int timeAddTextHour;
        static int timeAddTextMinute;
        static int timeAddTextSecond;
        static int timeAddTextMonth;
        static int timeAddTextYear;
        static int timeAddTextDay;

        static string down = "\n";
        static string[] words;
        static string text;
        static string fullNamePerson;
        static string placeOfBirth;
        static string next;
        static string[] lineText;
        static void Main(string[] args)
        {
            WriteLine($"Привет!, скажите пожалуйста, вы хотите внести сотрудника или прочитать имеющейся список ? \nДля выбора введите -r- для чтения и -w- для записи");

            for (; ; )
            {
                next = ReadLine();
                if (next == "r" || next == "R")
                {
                    ReadDocument();
                    break;
                }
                else if (next == "w" || next == "W")
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
                lineText = ReadAllLines(@"d:\PersonDocument.txt");
                for(int a = 0;a < lineText.Length * 6;a++ )
                {
                    if (lineText.Length - 1 >= a)  
                    words = lineText[a].Split('#');
                    
                    if (words.Length - 1 >= a)
                    Write($" {words[a]}");

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
                    next = ReadLine();
                    if (next == "e" || next == "E")
                    {
                        break;
                    }
                    else if (next == "w" || next == "W")
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
            fullNamePerson = ReadLine();
            WriteLine($"Хорошо!, теперь давай узнаем дату рождения нового сотрудника,\nвведите дату рождения слитно, с начала - день месяц год например 10122001");
            dateOfBirth = ToInt32(ReadLine());

            dayOfBirth = dateOfBirth / 1000000;
            yearOfBirth = dateOfBirth % 10000;
            badNum = dateOfBirth % 1000000;
            mounthOfBirth = badNum / 10000;

            timeAddTextHour = System.DateTime.Now.Hour;
            timeAddTextMinute = System.DateTime.Now.Minute;
            timeAddTextSecond = System.DateTime.Now.Second;
            timeAddTextDay = System.DateTime.Now.Day;
            timeAddTextMonth = System.DateTime.Now.Month;
            timeAddTextYear = System.DateTime.Now.Year;

            if(timeAddTextMonth == mounthOfBirth)
            {
                if(timeAddTextDay >= dayOfBirth)
                {
                 agePerson = timeAddTextYear - yearOfBirth;
                }
            }else if(timeAddTextMonth > mounthOfBirth)
            {
                agePerson = timeAddTextYear - yearOfBirth;
            }
            else
            {
                agePerson = timeAddTextYear - yearOfBirth - 1;
            }

            WriteLine($"Класс, теперь нужен рост нашего героя, вдруг в нашем царстве он не пройдет в дверь),\nвведите рост в мм");
            growth = ToInt32(ReadLine());
            WriteLine($"Вот и все, осталось лишь ввести город, где родился наш человечек,\nвведите город с заглавной буковки(Ох уж этот Русский)");
            placeOfBirth = ReadLine();
            ReconciliationData();
        }
        static void ReconciliationData()
        {
            WriteLine($"Теперь давай сверим данные \n Нажми любую клавишу если готов");
            ReadKey();
            WriteLine($"ФИО {fullNamePerson} \nДата рождения {dayOfBirth}.{mounthOfBirth}.{yearOfBirth} \nВозраст получается {agePerson} \nРост {growth} \nИ родился он в {placeOfBirth}");
            WriteLine($"Все верно или хотите повторить ввод данных ? \nЕсли все верно нажмите -y- , иначе -n-");
            for (; ; )
            {
                next = ReadLine();
                if (next == "y")
                {
                    CreatingDocument();
                    break;
                }
                else if (next == "n")
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
                text = ReadAllText(@"d:\PersonDocument.txt");
                lineText = ReadAllLines(@"d:\PersonDocument.txt");

                words = lineText[lineText.Length - 1].Split('#');

                if (ToInt32(words[0]) > 0)
                {
                    iD = ToInt32(words[0]) + 1;
                }
                else
                {
                    iD = 1;
                    down = null;
                }

            }

            text += $"{down}{iD}#{timeAddTextDay}.{timeAddTextMonth}.{timeAddTextYear}#{fullNamePerson}" +
                $"#{timeAddTextHour}:{timeAddTextMinute}:{timeAddTextSecond}#{agePerson}#{growth}#{dayOfBirth}.{mounthOfBirth}.{yearOfBirth}#{placeOfBirth}";

            WriteLine(text);
            ReadKey();

            WriteAllText (@"d:\PersonDocument.txt",text);
        }
    }
}
