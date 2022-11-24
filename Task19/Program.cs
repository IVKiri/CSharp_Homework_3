// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);

if (num.Length != 5) {
    Console.WriteLine("Это не пятизначное число. Попробуйе еще раз.");
}
else {
    if (num[0] == num[4] && num[1] == num [3]) {
        Console.WriteLine("Это палиндром");
    }
    else {
        Console.WriteLine("Число не является палиндромом");
    }
}
