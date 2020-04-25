using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    class Program
    {
        static public int N;
        static public List<Smartphone> Phones = new List<Smartphone>();
        static void Main(string[] args)
        {
            Array();
            Console.ReadKey();
        }

        private static void Array()
        {
            Console.WriteLine("Какое количество смартфонов Вы хотите заполнить:");
            N = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < N; i++)
                {
                Console.WriteLine("Заполните информацию о" + " " + (i + 1) + "-м " + "смартфоне:");
                Smartphone TempPhones = new Smartphone();
                    Console.WriteLine("Марка:");
                    TempPhones.Brand = Console.ReadLine();

                    Console.WriteLine("Модель:");
                    TempPhones.Model = Console.ReadLine();

                    Console.WriteLine("Цена:");
                    TempPhones.Price = Convert.ToDouble(Console.ReadLine());

                Phones.Add(TempPhones);
                }
        }
    }
}
