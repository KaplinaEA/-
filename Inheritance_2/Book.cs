using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_2
{
    /*Создать класс Book, описывающий книгу (Название, количество страниц, издательство,
дата издания, дата написания) */
    class Book
    {
        protected string name, publised;
        protected int count;
        protected DateTime date_publication, date_writing;
        public Book(string name, string publised, int count, DateTime date_publication, DateTime date_writing)
        {
            this.name = name;
            this.publised = publised;
            this.count = count;
            this.date_publication = date_publication;
            this.date_writing = date_writing;
        }
        public override string ToString()
        {
            return $"Книга:\nНазвание: {name}\nКол-во страниц: {count}, издательство: {publised}\nДата издания: {date_publication}написания: \n{date_writing}\n";
        }
    }
}
