// Задача 43: Написать программу, которая на вход принимает массив из любого 
// количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит 
// этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).
int[] myArr = randArr();
Console.WriteLine($"{String.Join(", ", myArr)} ->");
myFunc(myArr);
Console.WriteLine($"{String.Join(", ", myArr)}");

//=====================methods===================

int[] randArr(){
  int size = new Random().Next(6, 20);
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(0, 101);
  }
  return res;
}

void myFunc(int[] arr){
  for (int i = 0; i < arr.Length; i++)
  {
    for (int j = 0; j < arr.Length - 1; j++)
    {
      if (arr[j] > arr[j + 1])
      {
        int temp = arr[j];
        arr[j] = arr[j + 1];
        arr[j + 1] = temp;
      }
    }
  }
}