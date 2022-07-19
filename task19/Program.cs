﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int length = number.Length;

if(number.Length < 5 || number.Length > 5){
    Console.WriteLine("Введено не пятизначное число! ");
}
else{
    if(number[0] == number[4] && number[1] == number[3]){
        Console.WriteLine("Число является палиндромом");
    }
    else{
        Console.WriteLine("Число не является палиндромом");
    }
}