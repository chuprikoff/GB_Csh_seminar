// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// Проверка на пятизначность обязательна

bool is_Polyndrom(string str){
  char[] reverse_arr = str.ToCharArray();
  Array.Reverse(reverse_arr);
  string reverse_str = new string(reverse_arr);
  bool result = (str == reverse_str);
  return result;
}

Console.WriteLine("Введите пятизначное число: ");
string userInput = Console.ReadLine();
string res = "нет";
Console.WriteLine(myFunc(userInput));

string myFunc(string str){
  while (userInput.Length != 5)
  {
    Console.WriteLine("Вы ввели некорректное значение!!!");
    Console.Write("Введите пятизначное число: ");
    userInput = Console.ReadLine();
    myFunc(userInput);
  }

  if(is_Polyndrom(userInput)){
    res = "да";
  }
  string myFuncStr=($"{userInput} -> {res}");
  return myFuncStr;
}

