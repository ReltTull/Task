// Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
//Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int[] CreateArray(int lenght, int leftBound, int rightBound)
{
    int[] array = new int[lenght];
    Random random = new Random();
    for(int index = 0; index < lenght; index++)
    {
        array[index] = random.Next(leftBound, rightBound);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        Console.Write(array[index] + " ");
    }
}

int GetQuantityOfEvenNumbers(int[] array)
{
    int quantity = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index] % 2 == 0)
        {
            quantity++;
        }
    }
    return quantity;
}
int[] array = CreateArray(5, -4, 10);
int resultArrayLenght = GetQuantityOfEvenNumbers(array);

int[] GetEvenNumbersArray(int[] array, int lenght)
{
    int index1 = 0;
    int[] resultArray = new int[lenght];
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index] % 2 == 0)
        {
            resultArray[index1] = array[index];
            index1++;
        }
    }
    return resultArray;
}
int[] result = GetEvenNumbersArray(array, resultArrayLenght);

PrintArray(array);
Console.WriteLine();
PrintArray(result);
