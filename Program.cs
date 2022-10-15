using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_class_15_10_22г
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person ЕдаБогов = new Person();
            ЕдаБогов.name = "Хинкалы";
            ЕдаБогов.lastName = "Аварский";
            ЕдаБогов.shape = "Ромб";

            Person ЕдаБогов2 = new Person();
            ЕдаБогов2.name = "Хинкалы";
            ЕдаБогов2.lastName = "Кумыкский";
            ЕдаБогов2.shape = "Квадрат";

            Person ЕдаБогов3 = new Person();
            ЕдаБогов3.name = "Хинкалы";
            ЕдаБогов3.lastName = "Кукурузный";
            ЕдаБогов3.shape = "Круг";

            Console.WriteLine($"Название: {ЕдаБогов.name}, Вид: {ЕдаБогов.lastName}, Форма {ЕдаБогов.shape}");
            Console.WriteLine($"Название: {ЕдаБогов2.name}, Вид: {ЕдаБогов2.lastName}, Форма {ЕдаБогов2.shape}");
            Console.WriteLine($"Название: {ЕдаБогов3.name}, Вид: {ЕдаБогов3.lastName}, Форма {ЕдаБогов3.shape}");
            Console.ReadKey();
        }
    }

    class Person
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string shape { get; set; }
    }
}
