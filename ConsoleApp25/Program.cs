using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House kv1 = new House();
            kv1.adress = "Адрес 1";
            kv1.floor = 2;
            kv1.count = 3;
            kv1.area = 63;
            House kv2 = new House();
            kv2.adress = "Адрес 2";
            kv2.floor = 4;
            kv2.count = 2;
            kv2.area = 46;
            House kv3 = new House();
            kv3.adress = "Адрес 3";
            kv3.floor = 5;
            kv3.count = 4;
            kv3.area = 100;
            House[] houses = { kv1, kv2, kv3 };
            Console.WriteLine("Введите число комнат");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите этаж");
            int floor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите площадь");
            int S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Список квартир с заданным числом комнат");
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i].count == num)
                {
                    Console.WriteLine($"Номер квартиры {i}");
                }
            }
            Console.WriteLine("Список квартир с заданным чилом комнат и на заданном этаже");
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i].count == num || houses[i].floor == floor)
                {
                    Console.WriteLine($"Номер квартиры {i}");
                }
            }
            Console.WriteLine("Список квартир с площадью более указанной");
            for (int i = 0; i < houses.Length; i++)
            {
                if (houses[i].area < S)
                {
                    Console.WriteLine($"Номер квартиры {i}");
                }
            }

        }
    }
}
public class House
{
    public string adress;
    public int floor;
    public int count;
    public double area;
}

