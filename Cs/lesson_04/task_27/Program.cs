// Напишите программу, которая принимает на вход число и выдаёт 
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите натуральное число: ");
string userInput = Console.ReadLine();
Console.WriteLine($"{userInput} => {sumNum(userInput)}");

//===========Method=============

int sumNum(string num){
  int res = 0;
  int[] arr = new int[num.Length];
    for (int i = 0; i < num.Length; i++)
    {
      arr[i] = Convert.ToInt32(num.Substring(i, 1));
      res+=arr[i];
    }

  return res;
}




