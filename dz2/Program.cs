// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
using static System.Console;
Write("Введите число ");
String n = ReadLine();
int sim =n.Length;
if (sim==2){
    WriteLine("третьей цифры нет");
}
else WriteLine(n[2].ToString());