// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.WriteLine("Сколько чисел будем вводить?");
int count = Convert.ToInt32(Console.ReadLine());
int a;
int j=0;

for(int i=0; i<count; i++)
{
    Console.WriteLine("введите число");
    a=Convert.ToInt32(Console.ReadLine());
    if(a>0)
    {
        j++;
    }
}
Console.WriteLine("Положительных было:");
Console.WriteLine(j);