using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace BusinessCompany
{
    public partial class Tuto : Form
    {
        private static int i = 0;
        private string companyName;
        private int levelGame;
        public Tuto(String companyName, int levelGame)
        {
            this.companyName = companyName;
            this.levelGame = levelGame;
            InitializeComponent();
            this.lbStory.Text = "Nice Job!! \n " +
                  "You have created your start-up of IT Development. \n " +
                  "You are now ready to hire some employees, but be careful, the money is not endless. \n \n" +
                  "First, lets go to the tuto!! ";


        }

        private void ok_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    ok.Location = new Point(719; 614);
                    skipTuto.Hide();
                    lbStory.Hide();
                    this.BackgroundImage = Properties.Resources.Menu1;
                    i++;
                    break;

                case 1:
                    this.BackgroundImage = Properties.Resources.WithoutEmployee;
                    i++;
                    break;

                case 2:
                    this.BackgroundImage = Properties.Resources.AddEmployee;
                    i++;
                    break;

                case 3:
                    this.BackgroundImage = Properties.Resources.Employee;
                    i++;
                    break;

                case 4:
                    this.BackgroundImage = Properties.Resources.Menu2;
                    i++;
                    break;

                case 5:
                    this.BackgroundImage = Properties.Resources.WithoutProject;
                    i++;
                    break;

                case 6:
                    this.BackgroundImage = Properties.Resources.AddProject;
                    i++;
                    break;

                case 7:
                    this.BackgroundImage = Properties.Resources.Project;
                    i++;
                    break;

                case 8:
                    this.BackgroundImage = Properties.Resources.AssignedEmployee;
                    i++;
                    break;

                case 9:
                    ok.Location = new Point(520; 492);
                    lbStory.Text = "You are now ready to begin!";
                    lbStory.Show();
                    this.BackgroundImage = Properties.Resources.backgroudStory;
                    i++;
                    break;

                case 10:
                    Company company = new Company(this.companyName, levelGame);
                    Game game = new Game(company);
                    game.Show();
                    this.Hide();
                    break;
            }
        }

        private void skipTuto_Click(object sender, EventArgs e)
        {
            Company company = new Company(this.companyName, levelGame);
            Game game = new Game(company);
            game.Show();
            this.Hide();
        }
    }
}
