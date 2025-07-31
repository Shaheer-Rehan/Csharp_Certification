Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int totalScore = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {totalScore}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 points added to total score.");
        totalScore += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 points added to total score.");
        totalScore += 2;
    }
    Console.WriteLine($"Your total score including the bonus is {totalScore}");
}
if (totalScore >= 16)
{
    Console.WriteLine("Congratulations! You just won a new car!");
}
else if (totalScore >= 10)
{
    Console.WriteLine("Congratulations! You just won a new laptop!");
}
else if (totalScore == 7)
{
    Console.WriteLine("Congratulations! You just won a trip to Italy!");
}
else
{
    Console.WriteLine("Here's a kitten as a consolation prize. Meow!");
}


// Testing how Boolean Expressions work
// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);
// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }