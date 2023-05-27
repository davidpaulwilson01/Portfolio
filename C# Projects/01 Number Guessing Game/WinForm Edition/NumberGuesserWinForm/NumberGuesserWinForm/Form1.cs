/* NumberGuesserWinForm v1.0 by David Wilson
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
         * target: Target number for the user to guess.
         * guess: User's current guess.
         * guessStr: Text input from the GuessIntake text box.
         * turn: User's current turn.
         */
        int target;
        int guess;
        string guessStr;
        int turn;
        public Form1()
        {
            InitializeComponent();
            // Initailize variables.
            Random ran = new Random();
            this.target = ran.Next(0, 100);
            this.turn = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnterGuess_Click(object sender, EventArgs e)
        {
            // Load the user's guess and convert it to an integer.
            this.guessStr = txtGuessIntake.Text;
            this.guess = Convert.ToInt32(this.guessStr);

            // Check the guess against the target and announce the results.
            if (this.guess == this.target)
            {
                lblMainReadout.Text = "That's correct! Great work! That took " + this.turn + " turns!";
            }
            else if (this.guess < this.target)
            {
                lblMainReadout.Text = "That guess is too low.";
                this.turn++;
                lblTurnCounter.Text = Convert.ToString(this.turn);
            }
            else
            {
                lblMainReadout.Text = "That guess is too high.";
                this.turn++;
                lblTurnCounter.Text = Convert.ToString(this.turn);
            }
        }
    }
}