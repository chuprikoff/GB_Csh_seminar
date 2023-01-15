//  Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B. 
//  (Задачи, решенные через Math.Pow, будут отправлены на переделку, 
//  так как задача стоит в том, чтобы написать цикл)

//  3, 5 -> 243 (3⁵)

//  2, 4 -> 16

Console.Write("Введите число: ");
double userNum = System.Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральную степень предыдущего числа: ");
int userExpon = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{userNum}; {userExpon} -> {myPow(userNum, userExpon)}");



// ================Методы====================
double myPow(double num, int expon){
  double res = 1;
  for (int i = 0; i < expon; i++)
  {
    res=res*num;
  }
  return res;
}