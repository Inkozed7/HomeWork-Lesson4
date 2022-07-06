using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    internal class Program
    {

        static int[] ArrayOfNumbers(string seriesNew)
        {

            int[] arrayOfNumbers = new int[1];    // инициализация массива из 1 элемента

            int j = 0;

            for (int i = 0; i < seriesNew.Length; i++)
            {
                string seriesNew1 = "";

                while (seriesNew[i] != ',' && i < seriesNew.Length)
                {
                    seriesNew1 += seriesNew[i];
                    СheckNumber2(seriesNew[i]);
                    i++;
                }
                arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    // заполняет массив значениями из строки
                if (i < seriesNew.Length - 1)
                {
                    arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();    // добавляет новый нулевой элемент в конец массива
                }
                j++;
            }
            return arrayOfNumbers;
        }


        static void PrintArry(int[] coll)
        {
            int count = coll.Length;
            int index = 0;
            Console.Write("[");
            while (index < count)
            {
                Console.Write(coll[index]);
                index++;
                if (index < count)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }

        static string RemovingSpaces(string series)
        {
            string seriesNew = "";
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] != ' ')
                {
                    seriesNew += series[i];
                }
            }
            return seriesNew;
        }

        //  функция  проверки на правильность ввода 
        static void СheckNumber2(int series)
        {

            if (series == '0' || series == '1' || series == '2'
            || series == '3' || series == '4' || series == '5' || series == '6'
            || series == '7' || series == '8' || series == '9' || series == ','
            || series == '-')
            {
            }
            else
            {
                Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");

            }
        }

        static void Main(string[] args)
        {

            //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            Console.WriteLine("введите число A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число B");
            int b = Convert.ToInt32(Console.ReadLine());
            int step = a;

            for (int i = 1; i < b; i++)
            {
                step = step * a;
            }
            Console.WriteLine("A в степени B равно: " + step);

            ///Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
            Console.WriteLine("Введите число");
           int c = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (c > 0)
            {
                int num = c % 10;
                c = c / 10;
                sum = sum + num;
            }
            Console.WriteLine("сумма всех цифр в числе равна: " + sum);

            /// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            Console.Write("Введите ряд чисел, разделенных запятой : ");
            string seriesOfNumbers = Console.ReadLine();

            seriesOfNumbers = seriesOfNumbers + ",";    

          
       

            string seriesNew = RemovingSpaces(seriesOfNumbers);

            int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

            PrintArry(arrayOfNumbers);
        }
    }
}
