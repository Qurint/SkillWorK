
namespace Program
{
    struct Persons
    {
        //нужен для обращения к структуре персонала, для удобного контроля
        PersonData[] persons;

        public string this[int index]// Индексация данных клиента для обращения к нему
        {
            get { return persons[index].Print(); }// Возможность чтения с вызовоп печати
        }

        public Persons(params PersonData[] datas)
        {
            this.persons = datas;
        }
    }
}
