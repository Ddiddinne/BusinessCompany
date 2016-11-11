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
    public partial class ModifyLevelCompany : Form
    {
        private Game game;
        
        public Game Game
        {
            get { return game; }
            set { game = value; }
        }
        
        public ModifyLevelCompany(Game game)
        {
            InitializeComponent();
            this.game = game;
            int price = this.game.Company.LevelCompany * 5000;
            int levelMax = this.game.Company.LevelCompany + 1;;
            String upgrade = String.Format("You will upgrade to level {0} and you need to pay {1}", levelMax, price);
            this.lbLevel.Text = upgrade;
            this.BackgroundImage = this.game.BackgroundImage;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.returnGame();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            int price = this.game.Company.LevelCompany * 5000;
            int level = this.game.Company.LevelCompany;
            if (this.game.Company.Money>=price)
            {
                this.game.Company.LevelCompany += 1;
                this.game.Company.Money = this.game.Company.Money - price;
                String alert = String.Format("You have succeed to upgrade to the level {0} and you have paid {1}", this.game.Company.LevelCompany, price);
                MessageBox.Show(alert);
                this.returnGame();
            }
            else{
                String alert = String.Format("You need {0} and you have only {1}", price, this.game.Company.Money);
                MessageBox.Show(alert);
            }
        }

        private void returnGame()
        {
            this.game.BackgroundImage = this.game.Company.Picture;
            this.game.Show();
            this.game.timer1.Start();
            this.Close();
        }

    }
}
