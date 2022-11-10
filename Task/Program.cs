    string[] array;
    Console.WriteLine("Введите массив строк через запятую");
    string array1 = Console.ReadLine();
    array = array1.Split(',');
    string[] array2 = new string[array.Length];

void SortArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array2[count] = array[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SortArray(array, array2);
PrintArray(array2);