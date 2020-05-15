using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_1
{
    class Man
    {
        protected string name;
        protected int age, weight, height;
        public Man(string name, int age, int weight, int height)
        {
            this.name = name;
            this.age = age;
            this.weight = weight;
            this.height = height;
        }
        public override string ToString()
        {
            return $"Человек:\nИмя: {name}\nВозраст: {age} вес: {weight} рост: {height}\n";
        }
    }
}
