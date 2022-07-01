// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string message){
    Console.Write (message);
    int a = int.Parse (Console.ReadLine());
    return a;
}

int n = Prompt("Введите трехзначное число N >");
while (Math.Abs(n) > 1000)
{
n = n / 10;
}
if (n>99){
   System.Console.WriteLine(n%10); 
}
else System.Console.WriteLine("Третьей цифры нет");
