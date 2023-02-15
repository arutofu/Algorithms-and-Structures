using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace QuickSort
{
    class Program
    {
        //метод для обмена элементов массива
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
        //метод возвращающий индекс опорного элемента
        static int Partition(int[] array, int minIndex, int maxIndex)
        {
            var pivot = minIndex - 1;
            for (var i = minIndex; i < maxIndex; i++)
            {
                if (array[i] < array[maxIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }
            pivot++;
            Swap(ref array[pivot], ref array[maxIndex]);
            return pivot;
        }
        //быстрая сортировка
        static int[] QuickSort(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex)
            {
                return array;
            }
            GlobalVar.count++;
            var pivotIndex = Partition(array, minIndex, maxIndex);
            
            QuickSort(array, minIndex, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, maxIndex);

            return array;
        }
        static int[] QuickSort(int[] array)
        {
            return QuickSort(array, 0, array.Length - 1);
        }
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            
            Console.Write("N = ");
            var len = Convert.ToInt32(Console.ReadLine());
            
            var a = new int[len];
            for (var i = 0; i < a.Length; ++i)
            {
                Console.Write("a[{0}] = ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            watch.Start();
            Console.WriteLine("Упорядоченный массив: {0}", string.Join(", ", QuickSort(a)));
            watch.Stop();
            Console.WriteLine("Действий: {0}", GlobalVar.count -1);
            Console.WriteLine(watch.ElapsedTicks + " мс.");
            Console.ReadLine();
        }
    }
}
