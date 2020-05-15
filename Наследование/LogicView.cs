using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Inheritance_1
{
    class LogicView
    {

        public List<Man> List_Man_Student;
        private string String_Man = "m", String_Student = "s";
        public LogicView()
        {
            this.List_Man_Student = new List<Man>();
        }
        private bool IsValidMan(string[] s)
        {
            return (s[0] == String_Man && s.Length == 5) ? true : false;
        }
        private bool IsValidStudent(string[] s)
        {
            return (s[0] == String_Student && s.Length == 8) ? true : false;
        }
        public void ReadPersons(string s)
        {
            using (StreamReader df = new StreamReader(s, Encoding.GetEncoding(1251)))
            {
                string inputString;
                while ((inputString = df.ReadLine()) != null)
                {
                    if (inputString == "") throw new ArgumentException("Некорректные входные данные. Присутствует пустая строка.");
                    string[] str = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (IsValidMan(str))
                    {
                        int[] mas = new int[3];
                        for (int j = 0; j < 3; j++)
                        {
                            if (!int.TryParse(str[j + 2], out mas[j])) throw new ArgumentException("Некорректные входные данные.");
                        }
                        Man A = new Man(str[1], mas[0], mas[1], mas[2]);
                        List_Man_Student.Add(A);
                    }
                    else
                    if (IsValidStudent(str))
                    {
                        int[] mas = new int[6];
                        for (int j = 0; j < 6; j++)
                        {
                            if (!int.TryParse(str[j + 2], out mas[j])) throw new ArgumentException("Некорректные входные данные.");
                        }
                        Student A = new Student(str[1], mas[0], mas[1], mas[2], mas[3], mas[4], mas[5]);
                        List_Man_Student.Add(A);
                    }
                    else throw new ArgumentException("Некорректные входные данные.");
                }
            }
        }
        public void GetAll(string s)
        {
            using (StreamWriter sw = new StreamWriter(s, false, System.Text.Encoding.Default))
            {
                foreach (Man item in List_Man_Student)
                    sw.WriteLine(item);
            }
        }
    }
}
