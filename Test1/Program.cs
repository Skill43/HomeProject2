// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


System.Console.WriteLine("Введите палиндром: ");
string N = Convert.ToString(System.Console.ReadLine());
char[] s = N.ToCharArray();
Array.Reverse(s);
string P = new string(s);
N = N == P ? N + " является палиндромом" : N + " НЕ является палиндромом";
System.Console.WriteLine(N);
