// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет
//  количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] myArr = randArr();

Console.WriteLine($"[{String.Join(",", myArr)}] -> {myEven(myArr)}");


//=================methods==================

int[] randArr(){
  int size = new Random().Next(5, 20);
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(100, 1000);
  }
  return res;
}


//---------------------------------


int myEven(int[] arr){
  int res = 0;
  foreach (int elem in arr)
  {
    if (elem % 2 == 0)
    {
      res++;
    }
  }
  return res;
}


