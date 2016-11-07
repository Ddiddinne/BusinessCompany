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

        private static List<int> ListPrice = new List<int>(){10000,50000};
        public Game Game
        {
            get { return game; }
            set { game = value; }
        }

        
        public ModifyLevelCompany()
        {
            InitializeComponent();
        }

        public ModifyLevelCompany(Game game)
        {
            InitializeComponent();
            this.game = game;
            if(game.Company.LevelCompany==3){
                this.lbDefault.Text = "You are already at the maximun level";
                this.lbLevel.Hide();
                this.btnApprove.Hide();
                this.btnCancel.Text = "Cancel";
            }
            else
            {
                int levelMax = this.game.Company.LevelCompany + 1;
                int price = ListPrice.ElementAt(this.game.Company.LevelCompany - 1);
                String upgrade = String.Format("You will upgrade to level {0} and you need to pay {1}", levelMax, price);
                this.lbLevel.Text = upgrade;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.returnGame();
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            int price = ListPrice.ElementAt(this.game.Company.LevelCompany - 1);
            int level = this.game.Company.LevelCompany;
            if ((this.game.Company.LevelCompany < 3)&&(this.game.Company.Money>=price))
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
            this.game.Show();
            this.Close();
        }

    }
}
