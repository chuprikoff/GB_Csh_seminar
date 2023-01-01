// Задача 1: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел
// больше/меньше 3-х знаков


Console.Write("Введите з-х значное число: ");
int UserNum=System.Convert.ToInt32(Console.ReadLine());;


Console.WriteLine(myFunc(UserNum));
string myFunc(int a){
  while (((UserNum/100)<1)||((UserNum/100)>=10))
  {
    Console.WriteLine("Вы ввели некорректное значение!!!");
    Console.Write("Введите з-х значное число: ");
    UserNum = System.Convert.ToInt32(Console.ReadLine());
    myFunc(UserNum);
  }

  int res=(UserNum/10)%10;
  string myFuncStr=($"{UserNum} -> {res}");
  return myFuncStr;
}

