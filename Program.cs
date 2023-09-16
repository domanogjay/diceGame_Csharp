Random dice = new Random();

int rnd1 = dice.Next(1, 7);
int rnd2 = dice.Next(1, 7);
int rnd3 = dice.Next(1, 7);
int newTotal = 0;
int total = rnd1 + rnd2 + rnd3;

Console.WriteLine($"Your numbers are: {rnd1} + {rnd2} + {rnd3} = {total}");
if (rnd1 == rnd2 || rnd2 == rnd3! || rnd1 == rnd3)
{
    if (rnd1 == rnd2 && rnd2 == rnd3)
    {
        Console.WriteLine("You've got extra 6 points for having 3 paired dices!!");
        newTotal = total + 6;
    }
    else
    {
        Console.WriteLine("You got extra 2 points for having 2 paired dices!!");
        newTotal = total + 2;
    }
    Console.WriteLine($"Your new total: {newTotal}");
    total = newTotal;
}


if (total > 15)
    Console.WriteLine("Congratulations!! You've won a brand new car.");
else if (total > 10)
    Console.WriteLine("You've won a laptop!");
else if (total == 7)
    Console.WriteLine("You win a trip for 2!");
else
    Console.WriteLine("You win a Kitten!");


