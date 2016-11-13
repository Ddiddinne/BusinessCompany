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
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void valid_Click(object sender, EventArgs e)
        {
            int levelgame=0;

            if (radioButton1.Checked)
            {
                levelgame = 1;
            }
            if (radioButton2.Checked)
            {
                levelgame=2;
            }
            if (radioButton3.Checked)
            {
                levelgame=3;
            }

            if (!nameCompany.Text.Equals("") && levelgame != 0)
            {
                Tuto tuto = new Tuto(nameCompany.Text, levelgame);
                tuto.Show();
                this.Hide();
                
            }




        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
