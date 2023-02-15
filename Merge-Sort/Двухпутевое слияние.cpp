﻿#include <stdio.h>
#include <stdlib.h>

// Функция сортировки двухпутевым слиянием
void merge(int* a, int n)
{
    int mid = n / 2; // находим середину сортируемой последовательности
    if (n % 2 == 1)
        mid++;
    int h = 1; // шаг
    // выделяем память под формируемую последовательность
    int* c = (int*)malloc(n * sizeof(int));
    int step;
    while (h < n)
    {
        step = h;
        int i = 0;   // индекс первого пути
        int j = mid; // индекс второго пути
        int k = 0;   // индекс элемента в результирующей последовательности
        while (step <= mid)
        {
            while ((i < step) && (j < n) && (j < (mid + step)))
            { // пока не дошли до конца пути
              // заполняем следующий элемент формируемой последовательности
              // меньшим из двух просматриваемых
                if (a[i] < a[j])
                {
                    c[k] = a[i];
                    i++; k++;
                }
                else {
                    c[k] = a[j];
                    j++; k++;
                }
            }
            while (i < step)
            { // переписываем оставшиеся элементы первого пути (если второй кончился раньше)
                c[k] = a[i];
                i++; k++;
            }
            while ((j < (mid + step)) && (j < n))
            {  // переписываем оставшиеся элементы второго пути (если первый кончился раньше)
                c[k] = a[j];
                j++; k++;
            }
            step = step + h; // переходим к следующему этапу
        }
        h = h * 2;
        // Переносим упорядоченную последовательность (промежуточный вариант) в исходный массив
        for (i = 0; i < n; i++)
            a[i] = c[i];
    }
}
int main()
{
    int a[8];
    // Заполнение массива случайными числами
    for (int i = 0; i < 8; i++)
        a[i] = rand() % 20 - 10;

    // Вывод элементов массива до сортировки
    for (int i = 0; i < 8; i++)
        printf("%d ", a[i]);
    printf("\n");

    merge(a, 8); // вызов функции сортировки

    // Вывод элементов массива после сортировки
    for (int i = 0; i < 8; i++)
        printf("%d ", a[i]);
    printf("\n");

    getchar();
    return 0;
}