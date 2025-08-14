/*
This code converts a message into an array of characters,
then it reverses the order of the array, and counts the 
occurrence of a particular character. Then, it converts
the reversed array back into a string, and it prints the
reversed message and the count of the target character.
*/
string message = "The quick brown fox jumps over the lazy dog.";

char[] messageCharacters = message.ToCharArray();
Array.Reverse(messageCharacters);

int count = 0;

foreach (char i in messageCharacters)
{
    if (i == 'o')
    {
        count++;
    }
}

string newMessage = new String(messageCharacters);

Console.WriteLine($"{newMessage}\n'o' appears {count} times in the message.");