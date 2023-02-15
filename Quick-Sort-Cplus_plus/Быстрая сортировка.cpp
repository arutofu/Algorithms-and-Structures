#include <stdio.h>
#include <stdlib.h>
#define SIZE 10

void qsortRecursive(int* mas, int size) {
    //Указатели на начало и конец массива
    int i = 0;
    int j = size - 1;
    //Центральный элемент
    int mid = mas[size / 2];
    //Делим массив
    do {
        //Пробегаем элементы, ищем те, которые нужно перекинуть в другую часть
        //В левой части оставляем на месте элементы меньше центрального
        while (mas[i] < mid) {
            i++;
        }
        //В правой части пропускаем элементы больше центрального
        while (mas[j] > mid) {
            j--;
        }
        //Меняем элементы местами
        if (i <= j) {
            int tmp = mas[i];
            mas[i] = mas[j];
            mas[j] = tmp;

            i++;
            j--;
        }
    } while (i <= j);
    //Рекурсивные вызовы, если осталось, что сортировать
    if (j > 0) {
        //"Левый кусок"
        qsortRecursive(mas, j + 1);
    }
    if (i < size) {
        //"Правый кусок"
        qsortRecursive(&mas[i], size - i);
    }
}

int main()
{
    int a[SIZE];
    // Заполнение случайными числами
    for (int i = 0; i < SIZE; i++)
        a[i] = rand() % 201 - 100;

    // Вывод элементов до сортировки
    for (int i = 0; i < SIZE; i++)
        printf("%4d ", a[i]);
    printf("\n");

    qsortRecursive(a, SIZE); // вызов сортировки
              // Вывод элементов после сортировки
    for (int i = 0; i < SIZE; i++)
        printf("%4d ", a[i]);
    printf("\n");
    getchar();
    return 0;
}