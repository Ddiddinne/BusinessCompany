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
    public partial class LostGame : Form
    {
        public LostGame()
        {
            InitializeComponent();
        }

        private void btNewGame_Click(object sender, EventArgs e)
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
            if (!this.txbNameCompany.Text.Equals("") && levelgame != 0)
            {
                Company company = new Company(this.txbNameCompany.Text, levelgame);
                this.Close();
                Game game = new Game(company);
                game.Show();
            }
            else
            {
                Button button = (Button)sender;
                button.Text = "Name of company?";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Option option = new Option();
            option.Show();
        }

        private void LostGame_Load(object sender, EventArgs e)
        {
            Form.ActiveForm.Close();
        }
    }
}
