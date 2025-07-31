Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int totalScore = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {totalScore}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 points added to total score.");
    totalScore += 2;
}
if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 points added to total score.");
    totalScore += 6;
}
if (totalScore >= 15)
{
    Console.WriteLine("Congratulations! You win!");
}

if (totalScore < 15)
{
    Console.WriteLine("Sorry, you lose.");
}



// Testing how Boolean Expressions work
// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);
// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }