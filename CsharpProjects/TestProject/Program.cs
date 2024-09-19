Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} {roll2} {roll3}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("2 dados iguais! +2 bonus total!!");
    total +=2;
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("3 dados iguais!! + 6 de bonus total!");
    total +=6;
}

if (total >= 15)
{
    Console.WriteLine($"Você Venceu!! seu total:{total}");
}

if (total <15)
{
    Console.Write($"Desculpe, Você perdeu. seu total:{total}");
}
