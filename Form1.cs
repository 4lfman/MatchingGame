using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        //This is used to generate random icons for the squares
        Random random = new Random();

        //A list over interesting characters 
        //in the Webdings font.
        //Each character appears twice to make it a memory
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };

        //Stores the first and second label that the player clicks on
        Label firstClicked = null;
        Label secondClicked = null;

        public Form1()
        {
            InitializeComponent();
            
            ChooseIcons();
            AssignIconsToSquares();
        }

        private void ChooseIcons()
        {
            OwnTextBox iconInputPopup = new OwnTextBox();
            iconInputPopup.ShowDialog();
        }

        /// <summary>
        /// Assign the icons to random squares
        /// </summary>
        private void AssignIconsToSquares()
        {
            //For each of the 16 labels there will be an icon assigned
            //to it and as an icon is used it is deleted from the list
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor; //Hides the icons from the player by making the the same color as the background
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        //Eventhandler
        private void label_Click(object sender, EventArgs e)
        {
            //If the board hasn't reset, return
            if (timer1.Enabled == true)
            {
                return;
            }

            Label clickedLabel = sender as Label;

            //The game has net reset, return
            if (secondClicked != null)
            {
                return;
            }

            if (clickedLabel != null)
            {
                //If true the label has already been selected
                if (clickedLabel.ForeColor == Color.Black)
                {
                    return;
                }

                //If true, it is the first icon the player has clicked
                //(Since the last "reset"
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;

                    return;
                }

                //If the loop has come this far,
                //the board is reset and firstClicked
                //isn't null which means clickedLabel
                //is the second labed clicked
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;

                //Check to see if the player won
                CheckForWinner();

                //If they match, they sould not disappear
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                //Since two icons are chosen, the timer 
                //for resetting should be started
                timer1.Start();
            }
        }
        
        /// <summary>
        ///The timer is started as the player starts the second 
        ///icon if there is no match
        ///It then counts to 750 ms until it stops the timer
        ///and hides the icons and resets first- and secondclicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Stop the timer
            timer1.Stop();

            //Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            //Reset firstClicked and secondClicked so that
            //the program knows to expect a new first click
            firstClicked = null;
            secondClicked = null;
        }

        /// <summary>
        /// Checks if all icons are matched by comparing the
        /// foregroud color and backgroundcolor of all the icons
        /// </summary>
        private void CheckForWinner()
        {

            //Go through all the labels in TabelLayoutPanel,
            //checking each one to se if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                    {
                        return;
                    }
                }
            }

            //If the loop didn't return all icons are matched
            //This means the user won. Show att congratulatory message
            //and close the form
            MessageBox.Show("You matched all the icons!", "Congratulations");
            Close();
        }
    }
}
