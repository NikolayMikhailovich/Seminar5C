// Задача 1: Напишите программу замены элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreatnumbersArray()
{
  int[] array = new int[10];
  Random rnd = new Random();
  for (int i = 0; i < array.Length; i++)
  {
    array[i] = rnd.Next(-10, 11);
  }
  return array;
}

void PrintArray(int[] array, string message)
{
  Console.WriteLine(message);
  for (int i = 0; i < array.Length; i++)
  {
    Console.Write(array[i] + " ");
  }
  System.Console.WriteLine();
}


int[] Inventer(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
   array[i] *= -1;
  }
  return array;
}


int[] numsArray = CreatnumbersArray();
PrintArray(numsArray, "Базовый массив: ");
int[] invertedArray = Inventer(numsArray);
PrintArray(invertedArray, "Инвертированный массив: ");