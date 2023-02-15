using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        //метод для рекурсивного бинарного поиска
        static int BinarySearch(int[] array, int searchedValue, int first, int last)
        {
            //границы сошлись
            if (first > last)
            {
                GlobalVar.count--;
                //элемент не найден
                return -1;
            }
            //средний индекс подмассива
            var middle = ((first + last) / 2);
            if (last == 1 && (first + last) / 2 == 0)
            {
                middle++;
            }
            //значение в средине подмассива
            var middleValue = array[middle];
            if (middleValue == searchedValue)
            {
                return middle;
            }
            else
            {
                if (middleValue > searchedValue)
                {
                    GlobalVar.count++;
                    //рекурсивный вызов поиска для левого подмассива
                    return BinarySearch(array, searchedValue, first, middle - 1);
                }
                else
                {
                    GlobalVar.count++;
                    //рекурсивный вызов поиска для правого подмассива
                    return BinarySearch(array, searchedValue, middle + 1, last);
                }
            }
        }
        static void Main(string[] args)
        {                       //y  z
            int[,] matr = new int[5, 5] 
            {
                    { 1, 74, 6, 13, 108},
                    { 2, 75,  7, 16, 130},
                    { 3, 76,  8, 17, 145},
                    { 4, 77,  9, 20, 179},
                    { 5, 78,  10, 30, 183}
            };
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(matr[j, i] + "  ");
                }
                Console.Write('\n');
            }
            Console.Write('\n');
            Console.Write("Введите искомое значение ");
            var k = Convert.ToInt32(Console.ReadLine());

            var array = new int[5];
            int j1 = 0;
            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    array[i] = matr[i, j];
                    j1 = j + 1;
                }
                var searchResult = BinarySearch(array, k, 0, 4);
                if (searchResult > -1)
                {
                    Console.WriteLine("Элемент найден. Индекс элемента {0} равен {1},{2}", k, searchResult + 1, j1 - 1);
                    Console.WriteLine("Шагов поиска : {0}", GlobalVar.count);
                }
            }
            Console.ReadLine();
        }
    }
}
