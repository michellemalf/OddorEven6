//Michelle Malfabon
//Aug 15 2022

//-----------MINI 6-----EVEN OR ODD------------//

//reviewed by Saul
//Works great! You're just missing the data validation. Other tha that it looks good.

//Description: I declared the variable (result). The user will input a number and function will define if number is odd or even with if statement using the modulus. 

int result;
int playAgain;

void PlayGame()
{
Console.WriteLine("Enter a number: ");
result = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("The result is " + result);

if (result % 2 == 0)
{
    Console.WriteLine(result + " is even!");
}
else
{
    Console.WriteLine(result + " is odd!");
}
Console.WriteLine("Enter 0 to play again.");
playAgain= Convert.ToInt32(Console.ReadLine());
if (playAgain == 0)
{
    PlayGame();
}
else{
    Console.WriteLine("Goodbye.");
}
}
PlayGame();


