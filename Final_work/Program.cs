int InputSize(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray1(string[] array1)
{
    for(int i = 0; i < array1.Length; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array1[i] = Console.ReadLine();
    }
}

void PrintArray(string[] array)
{
    Console.WriteLine(String.Join(", ", array));
}

int FindArray2Size(string[] array1)
{
    int size2 = 0;

    for(int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3) 
        {
            size2++;
        }
    }
    return size2;
}

void FillArray2(string[] array1, string[] array2)
{
        int i = 0;

        for(int j = 0; j < array1.Length; j++)
        {
            if(array1[j].Length <= 3)
            {
                array2[i] = array1[j];
                i++;
            }
        }
}

int size1 = InputSize("Введите размер массива: ");

string[] array1 = new string[size1];

FillArray1(array1);

PrintArray(array1);

int size2 = FindArray2Size(array1);

string[] array2 = new string[size2];

FillArray2(array1, array2);

PrintArray(array2);



