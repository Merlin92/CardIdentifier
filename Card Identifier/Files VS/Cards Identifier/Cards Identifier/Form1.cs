/* Student Name: Merlin Bierekofen
 * Student ID: 14101805
 * Date: 21.09.2016
 * Assignment: 1
 * Task: Create a program which displays cards. When you click on them a 
 * label positioned below will show the name of the card. Program should 
 * include an exit button, be renamed and include a label with the name 
 * of the programmer */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards_Identifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ThreeClubsPictureBox_Click(object sender, EventArgs e)
        {
            // This method will show 3 clubs in the OutputLabel, when card 3 clubs is clicked
            OutputLabel.Text = "3 Clubs";
        }

        private void SixDiamondsPictureBox_Click(object sender, EventArgs e)
        {
            // This method will show 6 diamonds in the OutputLabel, when card 6 diamonds is clicked
            OutputLabel.Text = "6 Diamonds";
        }

        private void SevenClubsPictureBox_Click(object sender, EventArgs e)
        {
            //This method will show 7 clubs in the OutputLabel, when card 7 clubs is clicked 
            OutputLabel.Text = "7 Clubs";
        }

        private void QueenSpadesPictureBox_Click(object sender, EventArgs e)
        {
            //This method will show queen spades in the OutputLabel, when card queen spades is clicked
            OutputLabel.Text = "Queen Spades";
        }

        private void AceHeartsPictureBox_Click(object sender, EventArgs e)
        {
            //This method will show ace hearts in the OutputLabel, when card ace heats is clicked
            OutputLabel.Text = "Ace Hearts";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //This method closes the program when ExitButton is clicked
            this.Close();
        }

        private void InstructionsLabel_Click(object sender, EventArgs e)
        {

        }

        private void OutputLabel_Click(object sender, EventArgs e)
        {

        }

        private void ProgrammerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
