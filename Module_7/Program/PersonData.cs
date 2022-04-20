namespace Program
{
    struct PersonData
    {
        string _index { get; set; }
        string _age { get; set; }
        string _growth { get; set; }
        string _fullName { get; set; }
        string _dataCreate { get; set; }
        string _timeCreate { get; set; }
        string _dateOfBirth { get; set; }
        string _placeOfBirth { get; set; }

        public PersonData(string _index, string _fullName, string _age, string _growth, string _dateOfBirth, string _placeOfBirth, string _timeCreate, string _dataCreate)// инициализация
        {
            this._index = _index;
            this._age = _age;
            this._growth = _growth;
            this._fullName = _fullName;
            this._dataCreate = _dataCreate;
            this._timeCreate = _timeCreate;
            this._dateOfBirth = _dateOfBirth;
            this._placeOfBirth = _placeOfBirth;
        }

        public string Print()// возвращаем значения в стринг и делаем метод
        {
            return $"Номер по списку:{_index}\nФио: {_fullName}\nВозраст: {_age} "+
                $"\nРост: {_growth}\nДата рождения: {_dateOfBirth}\nМесто рождения: {_placeOfBirth} "+
                $"\nВремя создания документа: {_timeCreate}\nДата создания документа: {_dataCreate}";
        }

    }
}
