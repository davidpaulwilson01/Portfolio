/* NumberGuesser, a Number-Guessing Game
 * by David Wilson
 * Created 05/22/23
 * 
 * This program is the first of a series I will use to teach myself C#. It is a simple number guessing game. In its 
 * initial version, it will simply pick a random number and give the user three tries to guess it. Each guess returns
 * either a victory message, a loss message, or a hint as to the correct number by suggesting it is either higher
 * or lower relative to the guess. In the future, I may expand on this program to add customization options.
 */
main();
static void main()
{
    /* Variable Declarations
     * String welcome: Holds the initial message welcoming the player to the game.
     * Random ran: Random object used to generate the random number.
     * Int target: Holds the target number to be guessed.
     * String guessString: Holds the player's current guess input from the console in a String.
     * Int guessNum: Holds the player's current guess as an integer.
     * Int turns: Holds the player's current turn. Starts at 1, ends at 4.
     */
    String welcome;
    Random ran;
    int target;
    String guessString;
    int guessNum;
    int turns;

    // Variable Initialization
    turns = 1;

    welcome = "Welcome to NumberGuesser v1.0, a number-guessing game by David Wilson.\n" +
        "The rules are simple: I will pick a number between 0 and 100. You have three tries to guess it.\n" +
        "After each incorrect guess, I will tell if you if the correct number is lower or higher.\n" +
        "Let's play!\n";
    ran = new Random();
    target = ran.Next(0, 100);
    guessNum = 0;

    // Welcome the player.
    Console.WriteLine(welcome);

    /* The process of taking guesses is handled with a for loop that takes turns up to the maximum number.
     * On each loop, the program tells the player which turn they are on, then asks them for a number.
     * It then compares the number to the target value to determine if it is a match. Cases are as follows:
     *    1. Guess < Target: Program tells the player to guess higher.
     *    2. Guess == Target: Program prints the victory message.
     *    3. Guess > Target: Program tells the player to guess lower.
     * If the player runs out of turns before they guess correctly, the program prints the loss message.
     */
    for (turns = 1; turns < 4; turns++)
    {
        // Print the prompt.
        Console.WriteLine($"Turn {turns}");
        Console.WriteLine("Guess a number from 0 to 100.");
        // Take the player's input.
        guessString = Console.ReadLine();
        guessNum = Convert.ToInt32(guessString);
        // Check if the guess matches the target.
        if (guessNum == target)
        {
            Console.WriteLine($"You guessed correctly! Great work! It took you {turns} tries!");
            return;
        }
        else if (guessNum < target)
        {
            Console.WriteLine("Incorrect! Try guessing higher!");
        }
        else
        {
            Console.WriteLine("Incorrect! Try guessing lower!");
        }
    }
    // If the program reaches this line, the number of turns exceeded the maximum value.
    Console.WriteLine($"Game over! The correct number was {target}.");
}
