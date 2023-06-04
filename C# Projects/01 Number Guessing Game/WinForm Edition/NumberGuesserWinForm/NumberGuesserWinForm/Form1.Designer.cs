namespace NumberGuesserWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            lblMainReadout = new Label();
            lblTurnCounterLead = new Label();
            lblTurnCounter = new Label();
            lblGuessIntake = new Label();
            txtGuessIntake = new TextBox();
            btnEnterGuess = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(470, 29);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Number Guesser Winform Edition v1.0";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMainReadout
            // 
            lblMainReadout.BackColor = SystemColors.Window;
            lblMainReadout.BorderStyle = BorderStyle.FixedSingle;
            lblMainReadout.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblMainReadout.Location = new Point(12, 49);
            lblMainReadout.MinimumSize = new Size(700, 200);
            lblMainReadout.Name = "lblMainReadout";
            lblMainReadout.Size = new Size(776, 200);
            lblMainReadout.TabIndex = 1;
            lblMainReadout.Text = resources.GetString("lblMainReadout.Text");
            // 
            // lblTurnCounterLead
            // 
            lblTurnCounterLead.AutoSize = true;
            lblTurnCounterLead.Font = new Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTurnCounterLead.Location = new Point(12, 426);
            lblTurnCounterLead.Name = "lblTurnCounterLead";
            lblTurnCounterLead.Size = new Size(119, 19);
            lblTurnCounterLead.TabIndex = 2;
            lblTurnCounterLead.Text = "Current Turn:";
            // 
            // lblTurnCounter
            // 
            lblTurnCounter.AutoSize = true;
            lblTurnCounter.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTurnCounter.Location = new Point(137, 426);
            lblTurnCounter.Name = "lblTurnCounter";
            lblTurnCounter.Size = new Size(18, 19);
            lblTurnCounter.TabIndex = 3;
            lblTurnCounter.Text = "0";
            // 
            // lblGuessIntake
            // 
            lblGuessIntake.AutoSize = true;
            lblGuessIntake.Font = new Font("Rockwell", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGuessIntake.Location = new Point(282, 299);
            lblGuessIntake.Name = "lblGuessIntake";
            lblGuessIntake.Size = new Size(126, 23);
            lblGuessIntake.TabIndex = 4;
            lblGuessIntake.Text = "Your Guess:";
            // 
            // txtGuessIntake
            // 
            txtGuessIntake.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtGuessIntake.Location = new Point(406, 298);
            txtGuessIntake.MaxLength = 3;
            txtGuessIntake.Name = "txtGuessIntake";
            txtGuessIntake.Size = new Size(63, 29);
            txtGuessIntake.TabIndex = 5;
            // 
            // btnEnterGuess
            // 
            btnEnterGuess.Font = new Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnEnterGuess.Location = new Point(574, 274);
            btnEnterGuess.Name = "btnEnterGuess";
            btnEnterGuess.Size = new Size(171, 69);
            btnEnterGuess.TabIndex = 6;
            btnEnterGuess.Text = "Enter Guess";
            btnEnterGuess.UseVisualStyleBackColor = true;
            btnEnterGuess.Click += btnEnterGuess_Click;
            // 
            // Form1
            // 
            AcceptButton = btnEnterGuess;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnterGuess);
            Controls.Add(txtGuessIntake);
            Controls.Add(lblGuessIntake);
            Controls.Add(lblTurnCounter);
            Controls.Add(lblTurnCounterLead);
            Controls.Add(lblMainReadout);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Number Guesser Winform v1.0";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblMainReadout;
        private Label lblTurnCounterLead;
        private Label lblTurnCounter;
        private Label lblGuessIntake;
        private TextBox txtGuessIntake;
        private Button btnEnterGuess;
    }
}