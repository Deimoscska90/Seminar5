//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] InitArray()                     // создаем массив этим методом
{
int[] result = new int[12];
Random rnd = new Random();

for (int i = 0; i < result.Length; i++)
{
result[i] = rnd.Next(100,1000);
}

return result;
}

void PrintArray(int[] array)           //распечатываем массив этим методом
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
int[] numbers = InitArray();
PrintArray(numbers);
int count = 0;

for (int i = 0; i < 12; i++)
if (numbers[i] % 2 == 0)
count++;

Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");




