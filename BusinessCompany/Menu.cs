using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessCompany
{
    public partial class Menu : Form
    {
        public Menu(Boolean lost = false)
        {
            InitializeComponent();
            if (lost)
            {
                lbTitle.Text = "You have lost. \n Would you like to retry?";
            }
        }

        private void valid_Click(object sender, EventArgs e)
        {
            //We check the level of the game selected by the player
            int levelgame=0;

            if (rdBtLevel1.Checked)
            {
                levelgame = 1;
            }
            if (rdBtLevel2.Checked)
            {
                levelgame=2;
            }
            if (rdBtLevel3.Checked)
            {
                levelgame=3;
            }

            //If there is a name for the company and a level, we can begin
            if (!inpNameCompany.Text.Equals("") && levelgame != 0)
            {
                Tuto tuto = new Tuto(inpNameCompany.Text, levelgame);
                tuto.Show();
                this.Hide();
                
            }
            else
            {
                Button button = (Button)sender;
                button.Text = "Name of company?";
            }




        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
