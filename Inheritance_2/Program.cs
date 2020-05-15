using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Inheritance_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            try
            {
                List<Book> Book_list = new List<Book>();
                List<Author> Author_list = new List<Author>();
                using (StreamReader df = new StreamReader("input.txt", Encoding.GetEncoding(1251)))
                {
                    string inputString;
                    while ((inputString = df.ReadLine()) != null)
                    {
                        if (inputString == "") throw new ArgumentException("Некорректные входные данные. Присутствует пустая строка.");
                        if (inputString == "a")
                        {
                            string name = df.ReadLine(), surname = df.ReadLine();
                            string[] date = df.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            int[] mas = new int[3];
                            for (int j = 0; j < 3; j++)
                            {
                                if (!int.TryParse(date[j], out mas[j])) throw new ArgumentException("Некорректные входные данные.");
                            }
                            DateTime Date = new DateTime(mas[0], mas[1], mas[2]);

                            Author_list.Add(new Author(name, surname, Date));
                        }
                        else
                        if (inputString == "b")
                        {
                            string name = df.ReadLine(), publised = df.ReadLine();
                            int count;
                            int.TryParse(df.ReadLine(), out count);
                            string[] date1 = df.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            int[] mas = new int[3];
                            for (int j = 0; j < 3; j++)
                            {
                                if (!int.TryParse(date1[j], out mas[j])) throw new ArgumentException("Некорректные входные данные.");
                            }
                            DateTime date_publication = new DateTime(mas[0], mas[1], mas[2]);
                            string[] date2 = df.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                            mas = new int[3];
                            for (int j = 0; j < 3; j++)
                            {
                                if (!int.TryParse(date2[j], out mas[j])) throw new ArgumentException("Некорректные входные данные.");
                            }
                            try
                            {
                                DateTime date_writing = new DateTime(mas[0], mas[1], mas[2]);
                                Book_list.Add(new Book(name, publised, count, date_publication, date_writing));
                            }
                            catch
                            {
                                throw new InvalidDataException("Дата указана неверно.");
                            }
                        }
                        else throw new ArgumentException("Некорректные входные данные.");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}

