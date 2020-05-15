using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_1
{
    class Student : Man
    {
        protected int year_of_receipt, course, group;

        public Student(string name, int age, int weight, int height, int year_of_receipt, int course, int group) : base(name, age, weight, height)
        {
            this.year_of_receipt = year_of_receipt;
            this.course = course;
            this.group = group;
        }

        public override string ToString()
        {
            return $"Студент:\nИмя: {name}\nВозраст: {age} вес: {weight} рост: {height}\n" +
                $"Год начала обучения: {year_of_receipt}, курс: {course} номер группы: {group}\n";
        }

    }
}
