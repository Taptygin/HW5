Console.Clear();

//onsole.Write($"Введи количество элементов массива: ");
int numbElem = Convert.ToInt32(4);

int randNum(int elem, int min, int max)
{
    int[] numb = new int[elem];
    int summElem = 0;
    Console.Write("Получившийся массив: ");

    for (int i = 0; i < numb.Length; i++)
    {
        numb[i] = new Random().Next(min, max);

        Console.Write(numb[i] + " ");

        if (i % 2 != 1)
        {
            summElem = summElem + numb[i];
        }
    }
    return summElem;
}

int show = randNum(numbElem, 1, 100);

Console.WriteLine($"\nСумма элементов, стоящих на нечётных позициях: {show}");