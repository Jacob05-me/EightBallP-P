using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestVars
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void QuitButton_Click(object sender, EventArgs e)
        {
            //This.Obvious
            this.Close();
        }

        private void AskButton_Click(object sender, EventArgs e)
        {
            //Checks to see if debug is active
            if (UserAskTextBox.Text == "Debug") { DebugLabel.Visible = true; }
            else { DebugLabel.Visible = false; }

            //Random Var creation
            Random random = new Random();
            int RandInt = random.Next(8);

            //Random int Debug Check
            if (DebugLabel.Visible == true)
            {
                DebugLabel.Text = ":>" + RandInt;
            }

            //Logic to eight ball
            if (RandInt == 0)
            {
                AnswerLabel.Text = "Ask Again...";
            }
            else if (RandInt == 1)
            {
                AnswerLabel.Text = "Yes";
            }
            else if (RandInt == 2)
            {
                AnswerLabel.Text = "No";
            }
            else if (RandInt == 3)
            {
                AnswerLabel.Text = "Soon";
            }
            else if (RandInt == 4)
            {
                AnswerLabel.Text = "Later";
            }
            else if (RandInt == 5)
            {
                AnswerLabel.Text = "I'm Not Sure";
            }
            else if (RandInt == 6)
            {
                AnswerLabel.Text = "Possibly";
            }
            else { AnswerLabel.Text = "..."; }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
        //Clears all inputs and outputs
        AnswerLabel.Text = "Thinking...";
        UserAskTextBox.Text = "";
        
        }

        private void DebugButton_Click(object sender, EventArgs e)
        {

        }
    }
}

