//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] InitArray()                     
{
int[] result = new int[4];
Random rnd = new Random();

for (int i = 0; i < result.Length; i++)
{
result[i] = rnd.Next(-10,10);
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

int[] array = InitArray();



int [] massive = InitArray();         
PrintArray (massive);        

int sum = 0;
for (int i = 1; i < array.Length; i++)
    if (array[i] % 2 == 1) 
      sum = sum + array[i];
    Console.WriteLine($"Сумма элементов на нечётных позициях = {sum}");

         