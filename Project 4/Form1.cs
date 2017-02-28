using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class randomNumGame : Form
    {   //gloabal variable used by Form1_Load and userGuess_btn_Click to access random number generated
        private int correctGuess;
        private int count = 1;

        public randomNumGame()
        {
            InitializeComponent();
        }

        //Load event to generate random number
        private void Form1_Load(object sender, EventArgs e)
        {
            //generate random number. Passing an argument here creates seed value for creation of random number. If left blank will use system time.
            Random rand = new Random();
            //assign random to variable. This controls the range of the random number
            correctGuess = rand.Next(100) + 1;
            showRandomLabel.Text = correctGuess.ToString(); //added this for instructor to see number
        }
        //User guess click event
        private void userGuess_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int userGuess;

                //assign user's Guess to variable
                userGuess = int.Parse(userInputTextBox.Text);


                //determine if the user's guess is correct on guess button click
                if (userGuess == correctGuess)
                {
                    //guess was correct
                    guessMessageLabel.Text = "You guessed correctly after " + count + " times.";
                    resultPictureBox.Visible = true;
                    choiceListBox.Items.Clear();
                    userInputTextBox.Text = "";

                    //reload a new random number. I have a feeling I could have made this a class
                    //and called it into this function.
                    //generate random number. Passing an argument here creates seed value for creation of random number. If left blank will use system time.
                    Random rand = new Random();
                    //assign random to variable. This controls the range of the random number
                    correctGuess = rand.Next(100) + 1;
                    showRandomLabel.Text = correctGuess.ToString(); //added this for instructor to see number

                }
                else if (userGuess < correctGuess)
                {
                    //guess was too low
                    choiceListBox.Items.Add(userGuess.ToString());
                    guessMessageLabel.Text = "Too low, try again.";
                    userInputTextBox.Text = "";
                    count = count + 1;
                }
                else
                {
                    //guess was too high
                    choiceListBox.Items.Add(userGuess.ToString());
                    guessMessageLabel.Text = "Too high, try again.";
                    userInputTextBox.Text = "";
                    count = count + 1;
                }
            }
            catch (Exception ex)
            {
                //Display the default error message.
                MessageBox.Show(ex.Message);
            }
        }

       private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }    
    }
}
