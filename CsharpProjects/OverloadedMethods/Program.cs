Random dice = new Random();

int roll1 = dice.Next(); // this version of the method does not set an upper or lower limit 
int roll2 = dice.Next(101); // this overloaded version sets an upper limit for the Random number. Notice how if there is only one argument, it defaults as the upper limit
int roll3 = dice.Next(50, 101); // this version sets a lower and upper limit for the number

Console.WriteLine($"Roll 1: {roll1}\nRoll 2: {roll2}\nRoll 3: {roll3}");