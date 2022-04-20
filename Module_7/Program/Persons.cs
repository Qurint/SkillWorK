
namespace Program
{
    struct Persons
    {
        //нужен для обращения к структуре персонала, для удобного контроля
        PersonData[] persons;

        public PersonData this[int index]// Индексация данных клиента для обращения к нему
        {
            get { return persons[index]; }
            set { persons[index] = value; }                               // Возможность чтения с вызовоп печати
        }

        public Persons(params PersonData[] datas)
        {
            this.persons = datas;
        }
    }
}
