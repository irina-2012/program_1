﻿Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("УРА! Это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}