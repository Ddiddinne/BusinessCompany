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
    public partial class AfficheStory : Form
    {
        //indicate in which par of the story we are
        
        private Form parent;
        private Timer timer;
        public AfficheStory(Form parent, Company company, Timer timer, int index)
        {
            InitializeComponent();
            this.parent = parent;
            this.timer = timer;
            switch (index)
            {
                case 0:
                    this.lbStory.Text = "Nice Job!! \n " +
                        "You have created your start-up of IT Development. \n "+
                        "You are now ready to hire some employees, but be careful, the money is not endless.";
                    this.Show();
                    break;
                case 1:
                    this.lbStory.Text = "Your parents gave you 100 000$ to start your company \n " +
                        "Now, they need money, they ask you to give money back. \n " +
                        "They need it for the begining of the next month.";
                    this.Show();
                    break;

                case 2:
                    this.lbStory.Text = "As asked by your parents, you give them back their money but just the half. \n " +
                        "You will give them the rest the next month. \n " +
                        "Your company has less money. \n " +
                        "I hope that it will be ok for the future.";
                    company.Money -= 50000;
                    this.Show();
                    break;

                case 4:
                    this.lbStory.Text = "As asked by your parents, you give them back the rest of the money. \n " +
                        "Now you just have to earn more!!!! \n ";
                    company.Money -= 50000;
                    this.Show();
                    break;

                default:
                    parent.Show();
                    timer.Start();
                    this.Hide();
                    break;
            }
        }
        
        private void ok_Click(object sender, EventArgs e)
        {
            parent.Show();
            timer.Start();
            this.Hide();
        }
    }
}
