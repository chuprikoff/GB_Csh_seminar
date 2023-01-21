// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] myArr = randArr();
Console.WriteLine($"[{String.Join(", ", myArr)}] -> {sumOddIndex(myArr)}");

//=================methods================

int[] randArr(){
  int size = new Random().Next(5, 20);
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(-99, 100);
  }
  return res;
}

int sumOddIndex(int[] arr){
  int res = 0;
  for (int i = 1; i < arr.Length; i+=2)
  {
    res+=arr[i];
  }
  return res;
}