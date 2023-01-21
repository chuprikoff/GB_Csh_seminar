// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

// Для строки можно использовать данный метод 
// string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
// (пользователь вводит в консоли числа через пробел и они формируют строку)


Console.WriteLine("Введите числа через пробел.");
Console.WriteLine("Закончив ввод нажмите Enter.");
string userInput = Console.ReadLine();
Console.WriteLine($"{userInput} -> {myFunc(userInput)}");

//========================methods====================

int myFunc(string str){
  string[] strArr = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
  int res = 0;
  for (int i = 0; i < strArr.Length; i++)
  {
    if (System.Convert.ToInt32(strArr[i]) > 0) res++;
  }
  return res;
}