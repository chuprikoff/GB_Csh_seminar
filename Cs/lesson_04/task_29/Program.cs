// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. (числа берете любые)

randArr();

//================method====================

void randArr(){
  Random randNum = new Random();
  int[] res = new int[8];
  for (int i = 0; i < res.Length; i++)
  {
    res[i] = randNum.Next(0, 100);
    Console.Write($"{res[i]}, ");
  }
}
