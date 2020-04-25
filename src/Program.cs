using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    /*
     ПРОГРАММА ОРГАНИЗОВАННА ЧЕРЕЗ List, 
     Т.К. ОН ТОЖЕ ЯВЛЯЕТСЯ МАССИВОМ ЗНАЧЕНИЙ 
     */
    class Program
    {
        static public int N;
        static public List<Smartphone> Phones = new List<Smartphone>();
        static void Main(string[] args)
        {
            Array();
            sorting();
            Save_file();
            Console.ReadKey();
        }

        private static void Array()
        {
            try
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
            catch (Exception)
            {
                Console.WriteLine("Вы ввели не число!");
            }
        }
        private static void sorting()
        {
            Phones.Sort((a,b)=>string.Compare(a.Brand, b.Price.ToString()));
        }

        static public void Save_file()
        {
            using (StreamWriter s = new StreamWriter("Smartphone.txt"))
            {
                foreach (Smartphone sp in Phones)
                    s.WriteLine(sp.Brand + ", " + sp.Model + ", " + sp.Price.ToString());
            }
        }
    }
}
