// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] arrNumb = new int[5];
for (int i = 0; i < arrNumb.Length; i++)
{
    arrNumb[i] = new Random().Next(1, 100);
    Console.Write(arrNumb[i] + " ");
}

int maxN = arrNumb[0];
int minM = arrNumb[0];

for (int i = 1; i < arrNumb.Length; i++)
{
    if (maxN < arrNumb[i])
    {
        maxN = arrNumb[i];
    }
    if (minM > arrNumb[i])
    {
        minM = arrNumb[i];
    }
}

int volum = maxN - minM;

Console.WriteLine($"\nразница между между максимальным ({maxN}) и минимальным({minM}) элементами: {volum}");