using System;
using System.Text;
using System.Windows.Forms;

namespace game
{
    public partial class Form1 : Form
    {
        private string wordToGuess = "computer"; // the word to guess
        private StringBuilder maskedWord;

        public Form1()
        {
            InitializeComponents();
            InitializeGame();
        }

        
        private void InitializeGame()
        {
            maskedWord = new StringBuilder(new string('?', wordToGuess.Length));
            maskedWord[0] = wordToGuess[0];  
            maskedWord[maskedWord.Length - 1] = wordToGuess[wordToGuess.Length - 1]; 
            if (lblWordToGuess != null)
            {
                lblWordToGuess.Text = maskedWord.ToString();
            }
        }

        
        private void btnGuess_Click(object sender, EventArgs e)
        {
            string guess = txtGuess.Text.ToLower();  // read the user input

            if (guess == wordToGuess)
            {
                MessageBox.Show("Correct guess!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (lblWordToGuess != null)
                {
                    lblWordToGuess.Text = wordToGuess;  
                }
            }
            else
            {
                MessageBox.Show("Wrong guess! Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (lstWrongGuesses != null)
                {
                    lstWrongGuesses.Items.Add(guess);  
                }
            }

            txtGuess.Clear();  
        }

        private void InitializeComponents()
        {
            this.lblWordToGuess = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.lstWrongGuesses = new System.Windows.Forms.ListBox();
            this.lblWordToGuesses = new System.Windows.Forms.Label();

            
            lblWordToGuess.Text = "";
            lstWrongGuesses.Items.Clear();

            this.SuspendLayout();
           
            this.lblWordToGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblWordToGuess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblWordToGuess.Location = new System.Drawing.Point(126, 116);
            this.lblWordToGuess.ForeColor = System.Drawing.Color.White;
            this.lblWordToGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWordToGuess.Name = "lblWordToGuess";
            this.lblWordToGuess.Size = new System.Drawing.Size(348, 113);
            this.lblWordToGuess.TabIndex = 0;
            
            this.txtGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.txtGuess.Location = new System.Drawing.Point(177, 241);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.TextAlign = HorizontalAlignment.Center;
            this.txtGuess.Size = new System.Drawing.Size(249, 25);
            this.txtGuess.TabIndex = 3;
            
            this.btnGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnGuess.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Location = new System.Drawing.Point(231, 276);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(137, 34);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.ForeColor = System.Drawing.Color.White;
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            
            this.lblWordToGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblWordToGuesses.Location = new System.Drawing.Point(481, 116);
            this.lblWordToGuesses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWordToGuesses.Name = "lblWordToGuesses";
            this.lblWordToGuesses.ForeColor = System.Drawing.Color.White;
            this.lblWordToGuesses.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblWordToGuesses.Text = "Word Guesses";
            this.lblWordToGuesses.Size = new System.Drawing.Size(174, 31);
            this.lblWordToGuesses.TabIndex = 0;
            
            this.lstWrongGuesses.Location = new System.Drawing.Point(481, 150);
            this.lstWrongGuesses.Name = "lstWrongGuesses";
            this.lstWrongGuesses.Size = new System.Drawing.Size(174, 160);
            this.lstWrongGuesses.TabIndex = 3;
            this.lstWrongGuesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstWrongGuesses);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblWordToGuess);
            this.Controls.Add(this.lblWordToGuesses);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}