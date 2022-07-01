// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int Rnd(int min,int max){
    Random rnd = new Random();
    return rnd.Next(min, max+1);
}

int num = Rnd (100,999);
int num1 = num / 100;
int num3 = num % 10;
int result = num1 * 10 + num3;
Console.WriteLine(num + " -> " + result);