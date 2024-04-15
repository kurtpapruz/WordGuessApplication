using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class Form1 : Form
    {
        private string wordToGuess = "Information";
        private List<string> wrongGuesses = new List<string>();
        public Form1()
        {
            InitializeComponent();
            label1.Text = " ";
            InitializedGuessingWord();

        }
        private void InitializedGuessingWord()
        {
            StringBuilder wordToGuess = new StringBuilder();
            wordToGuess.Append(this.wordToGuess[0]);
            for (int i = 1; i < this.wordToGuess.Length - 1; i++)
            {
                wordToGuess.Append('?');
            }
            wordToGuess.Append(this.wordToGuess[this.wordToGuess.Length - 1]);
            label1.Text += wordToGuess.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string guessedWord = textBox1.Text.ToLower();

            if (guessedWord == wordToGuess)
            {
                label1.Text = "Correct Guess!!!";


            }
            else
            {
                wrongGuesses.Add(guessedWord);
                UpdateWrongGuessList_SelectedIndexChanged();
                MessageBox.Show("Wrong Guess");

            }
            MessageBox.Show("Correct Answer: " + wordToGuess);
        }


        private void UpdateWrongGuessList_SelectedIndexChanged()
        {
            StringBuilder sBuilder = new StringBuilder();
            foreach (string wrongGuess in wrongGuesses)
            {
                sBuilder.Append(wrongGuess);
                sBuilder.Append(Environment.NewLine);
            }
            label3.Text = sBuilder.ToString();
        }


    }
}
