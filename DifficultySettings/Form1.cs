using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    public partial class Form1 : Form
    {
        String Username;
        
        public Form1()
        {
            InitializeComponent();
          
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void MageButton_Click(object sender, EventArgs e)
        {
            easyButton.BackColor = Color.Blue;
            difficultButton.BackColor = Color.Black;
            impossibleButton.BackColor = Color.Black;

            Username = usernameInput.Text;

            welcomeLabel.Text = $" If your gonna play this game at least make it a challenging";
            
            
        }

        private void DifficultButton_Click(object sender, EventArgs e)
        {
            difficultButton.BackColor = Color.Yellow;
            easyButton.BackColor = Color.Black;
            impossibleButton.BackColor = Color.Black;

            Username = usernameInput.Text;

            welcomeLabel.Text = $" Welcome to the fight private {Username}";
        }

        private void ImpossibleButton_Click(object sender, EventArgs e)
        {
            difficultButton.BackColor = Color.Black;
            easyButton.BackColor = Color.Black;
            impossibleButton.BackColor = Color.Red;

            Username = usernameInput.Text;
            welcomeLabel.Text = $" May your life be long and your death be swift {Username}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
