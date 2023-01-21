//  Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и 
//  последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3

// [6 7 3 6] -> 36 21

int[] myArr = randArr();

Console.WriteLine($"[{String.Join(", ", myArr)}] -> [{String.Join(", ", multiplyElem(myArr))}]");

//=================methods================


int[] randArr(){
  int size = new Random().Next(3, 25);
  int[] res = new int[size];
  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(1, 20);
  }
  return res;
}

int[] multiplyElem(int[] arr){

  int size = arr.Length / 2 + arr.Length % 2;
  int[] res = new int[size];


  for (int j = 0; j < arr.Length / 2; j++)
  {
    res[j] = arr[j] * arr[arr.Length - 1 - j];
  }

  if(res[res.Length - 1] == 0){
    res[res.Length - 1] = arr[arr.Length / 2];
  }

  return res;
}


