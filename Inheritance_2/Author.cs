using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_2
{
    /*Создать класс Author, описывающий автора (имя, фамилия,год рождения).
     * Обеспечить нахождение класса в заведомо корректном состоянии.*/
    class Author
    {

        protected string name, surname;
        protected DateTime year_birth;
        public Author(string name, string surname, DateTime year_birth)
        {
            this.name = name;
            this.surname = surname;
            this.year_birth = year_birth;
        }
        public override string ToString()
        {
            return $"Автор:\nИмя: {name} Фамилия: {surname}, год рождения:{year_birth}\n";
        }
    }
}
