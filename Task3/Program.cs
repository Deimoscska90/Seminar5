//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] InitArray()                     
{
int[] result = new int[4];
Random rnd = new Random();

for (int i = 0; i < result.Length; i++)
{
result[i] = rnd.Next(1,100);
}

return result;
}

void PrintArray(int[] array)           
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

int [] massive = InitArray();         
PrintArray (massive);   
int[] array = InitArray();

int min = array[0];
int max = array[0];


for (int i = 0; i < array.Length; i++)
{
    
    if (array[i] > max)
        {
            max = array[i];
        }
    if (array[i] < min)
        {
            min = array[i];
        }
}

Console.WriteLine($"всего {array.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");