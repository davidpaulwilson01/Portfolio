/* NumberGuesserWinForm v2.0 by David Wilson
 * ---
 * This is a number-guessing game. The object is to guess a randomly selected number
 * between 0 and 100. The game takes your guess and outputs the following results:
 *      Correct Guess: The game congratulates you and tells you how many turns it took.
 *      Incorrect Guess: The game tells you whether you guessed too low or too high.
 */
namespace NumberGuesserWinForm
{
    public partial class Form1 : Form
    {
        /* Class Variables
         * int target: Target number for the user to guess.
         * int guess: User's current guess.
         * string guessStr: Text input from the GuessIntake text box.
         * int turn: Reflects the user's current turn.
         */
        int target;
        int guess;
        string guessStr;
        int turn;

        /* Method: Form1()
         * Input: None
         * Output: None
         * Purpose: Default constructor. 
         *  Initializes turn count at 1 and randomizes target number.
         */
        public Form1()
        {
            InitializeComponent();
            // Randomize the target number with a Random object.
            Random ran = new Random();
            this.target = ran.Next(0, 100);
            // Initialize the turn count.
            this.turn = 1;
        }

        /* Method: Form1_Load)
         * Input: None
         * Output: None
         * Purpose: Default event handler generated for WinForm.
        */
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* Method: btnEnterGuess_Click
         * Input: No unique inputs
         * Output: None
         * Purpose: When the user clicks the "Enter Guess" button on the form, this method
         *  is called to process and validate their guess, then determine the results.
        */
        private void btnEnterGuess_Click(object sender, EventArgs e)
        {
            /* Method Variables:
             * bool validGuess: Used to validate guess via Int32.TryParse.
             */
            bool validGuess;

            /* Load the user's guess and attempt to convert it to an integer via Int32.TryParse.
             * This method returns a boolean, setting the bool "validGuess" to "true" if the parsing was
             *  successful and "false" if it was not successful.
             * If the conversion is successful, the numerical value of the guess is placed into the
             *  int variable named "guess." Otherwise, "guess" is set to the value 0.
             */
            this.guessStr = txtGuessIntake.Text;
            validGuess = Int32.TryParse(guessStr, out guess);

            /* Validate the user's guess in two ways:
             *  1. Check if the guess was successfully parsed as an integer by verifying (bool) validGuess.
             *  2. Check if the guess falls into the established range by verifying (int) guess.
             * If either of these checks fail, the guess Print an error message and return.
             * This does not increment the turn tracker.
             */
            if (!validGuess || guess < 0 || guess > 100)
            {
                lblMainReadout.Text = "ERROR: Please enter a valid whole number from 0 to 100";
                return;
            }

            /* Check the guess against the target and announce the results.
             * 
             * First case: Thes guess matches the target.
             * Outcome: Inform the user that they have won and tell them the number of turns it took.
            */
            if (this.guess == this.target)
            {
                lblMainReadout.Text = "That's correct! Great work! That took " + this.turn + " turns!";
            }
            /* Second case: The guess is lower than the target.
             * Outcome: Advise the user that their guess was too low and increment the turn count.
             *  Display the new turn count on the form.
             */
            else if (this.guess < this.target)
            {
                lblMainReadout.Text = "That guess is too low.";
                this.turn++;
                lblTurnCounter.Text = Convert.ToString(this.turn);
            }
            /* Third case: The guess is higher than the target. This is the only possible case left.
             * Outcome: Advise the user that their guess was too high and increment the turn count.
             *  Display the new turn count on the form.
             */
            else
            {
                lblMainReadout.Text = "That guess is too high.";
                this.turn++;
                lblTurnCounter.Text = Convert.ToString(this.turn);
            }
        } // end btnEnterGuess_Click()
    } // end Form1 class
}