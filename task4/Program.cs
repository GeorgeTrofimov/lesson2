// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int Prompt(string message){
    Console.Write (message);
    int a = int.Parse (Console.ReadLine());
    return a;
}

int day = Prompt("Введите цифру обоздачающий день недели ");
if (day< 1 || day> 7)
{
    Console.WriteLine("Введены некорретные числа");
}
else if (day == 6 || day == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
    Console.WriteLine("Рабочий день");
}