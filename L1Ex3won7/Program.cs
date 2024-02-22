/*Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
tastaura*/

int num;
Console.WriteLine("Introduce un numar: ");
num = Convert.ToInt32(Console.ReadLine());

int ln = num % 10;

Console.WriteLine("Ultima cifra a unui numar intreg este: " +  ln);

Console.ReadLine();
