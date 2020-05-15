using System;
using System.IO;
using System.Text;

namespace Inheritance_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            try
            {
                LogicView C = new LogicView();
                C.ReadPersons("input.txt");
                C.GetAll("GetAllMan.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
        }
    }
}
