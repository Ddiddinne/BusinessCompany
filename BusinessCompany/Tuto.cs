using System;
using System.IO;
using System.Reflection;
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
                    var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);

                    var logoimage = Path.Combine(outPutDirectory, "Tuto\\Menu.png");
                    string relLogo = new Uri(logoimage).LocalPath;
                    this.BackgroundImage = (Bitmap)Image.FromFile(new LinkedResource(relLogo));
                    i++;
                    break;

                case 1:
                    i++;
                    break;

                case 2:
                    i++;
                    break;

                case 3:
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
