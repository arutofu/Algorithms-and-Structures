using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Алгоритм_Кнута_Морриса_Пратта
{
    class Program
    {
        static int[] GetPrefix(string s, string d)
        {
            int[] result = new int[d.Length];
            result[0] = 0;
            int index = 0;

            for (int i = 0; i < d.Length; i++)
            {
                while (index >= 0 && s[index] != d[i]) { index--; }
                index++;
                if (result[i] == 0)
                {
                    result[i] = index;
                }
                if (index == s.Length)
                {
                    index = 0;
                    i = i - (s.Length / 2);
                }
            }
            Console.WriteLine("Таблица  :  {0}", string.Join("", d));
            Console.WriteLine("сдвига   :  {0}", string.Join("", result));
            return result;
        }

        static int FindSubstring(string pattern, string text)
        {
            int[] pf = GetPrefix(pattern, text);
            int index = 0;

            for (int i = text.Length; index != pattern.Length; i--)
            {
                index = pf[i - 1];
                if (index == pattern.Length)
                {
                    Console.WriteLine("Начало подстроки i = {0}" + '\n' + "Конец подстроки i = {1}", i - pattern.Length + 1, i);
                    return 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            string text;
            string pattern;

            Console.WriteLine("Введите исходную строку");
            text = Console.ReadLine();
            Console.Out.WriteLine("Введите подстроку");
            pattern = Console.ReadLine();
            Console.Out.WriteLine('\n');

            if (FindSubstring(pattern, text) == -1)
            {
                Console.WriteLine('\n');
                Console.WriteLine("Не нашлось");
            }
            else
            {
                Console.WriteLine('\n');
                Console.WriteLine("Нашлось");
            }
            Console.ReadKey();
        }
    }
}
