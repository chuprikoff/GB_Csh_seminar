// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день 
// выходным. Обязательна проверка на ввод числа <1 и >7

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int userInput=System.Convert.ToInt32(Console.ReadLine());


Console.WriteLine(myFunc(userInput));
string myFunc(int a){
  string res ="нет";
  while (((userInput<1)||(userInput>7)))
  {
    Console.WriteLine("Вы ввели некорректное значение!!!");
    Console.Write("Введите цифру, обозначающую день недели: ");
    userInput = System.Convert.ToInt32(Console.ReadLine());
    myFunc(userInput);
  }
  if(userInput>5){
    res="да";
  }

  string myFuncStr=($"{userInput} -> {res}");
  return myFuncStr;
} 