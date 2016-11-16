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
    public partial class ListAddEmployee : Form
    {
        ListEmployees listEmployees;
        public ListAddEmployee(ListEmployees listEmployees)
        {
            this.listEmployees = listEmployees;
            this.listEmployees.game.storyGoOn += storyShow;
            listEmployees.game.loseGame += loseGame;
            InitializeComponent();
            this.BackgroundImage = listEmployees.BackgroundImage;
            int i = 0;

            //Draw the list of the candidates
            foreach (Employee employee in listEmployees.ListPerson)
            {

                AfficheEmployee afficheEmployee = new AfficheEmployee(0, employee, this);
                afficheEmployee.TopLevel = false;
                afficheEmployee.Location = new Point(0, i * 100);
                i++;
                afficheEmployee.Show();
                this.pnlList.Controls.Add(afficheEmployee);
            }
            pnlList.Size = new Size(300, 300);

        }

        private void annuler_Click(object sender, EventArgs e)
        {
            listEmployees.Show();
            this.Close();
        }

        public void add(Employee employee)
        {

            listEmployees.Company.addEmployee(employee);
            listEmployees.ListPerson.Remove(employee);
            listEmployees.Show();
            listEmployees.refresh();
            this.Close();
        }

        private void storyShow(object sender, EventArgs e)
        {
            //If we are in this form, we hide it, and show the story
            if (this.Visible)
            {
                this.listEmployees.game.timer1.Stop();
                this.Hide();
                AfficheStory story = new AfficheStory(this, this.listEmployees.company, this.listEmployees.game.timer1, this.listEmployees.game.IndexStory);
                this.listEmployees.game.IndexStory++;
            }
        }

        private void loseGame(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
