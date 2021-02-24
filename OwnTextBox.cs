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
    public partial class OwnTextBox : Form
    {
        public OwnTextBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When user press the accept button: 
        /// Assigns the input to stringIcon in Form1 for further action
        /// Closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void acceptTextBoxBtn_Click(object sender, EventArgs e)
        {
            Form1.stringIcon = textBox1.Text;
            Close();
        }

        /// <summary>
        /// First checks for dublicate characters.
        /// Then checks if there are 8 characters, if so,
        /// enable the button to accept the choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //HashSets can't contain dublicates which 
            //will be used to check for them
            HashSet<char> hashset = new HashSet<char>();

            foreach (char previousChars in textBox1.Text.ToList())
            {
                //True if there's a duplicate
                if(!hashset.Add(previousChars))
                {
                    //Removes the last input from the textBox
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);

                    //Puts the cursor at the end of the text
                    textBox1.SelectionStart = textBox1.Text.Length;
                    return;
                }
            }

            //If 8 characters are entered enable the button
            //Otherwise disable it
            if (textBox1.Text.Length == 8)
            {
                acceptTextBoxBtn.Enabled = true;
            }
            else
            {
                acceptTextBoxBtn.Enabled = false;
            }
        }
    }
}
