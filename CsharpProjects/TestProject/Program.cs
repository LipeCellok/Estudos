﻿Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} {roll2} {roll3}");

if (total > 14)
{
    Console.WriteLine("Você Venceu!!");
}

if (total <15)
{
    Console.Write("Desculpe, Você perdeu.");
}
