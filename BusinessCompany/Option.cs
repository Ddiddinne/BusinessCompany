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
                Company company = new Company(nameCompany.Text, levelgame);
                label3.Text=company.Name;
                Employee employee = new Employee();
                employee.FirstName="toto";
                employee.LastName = "bibi";
                company.addEmployee(employee);

                Employee employee2 = new Employee();
                employee2.FirstName = "lulu";
                employee2.LastName = "lili";
                company.addEmployee(employee2);

                Employee employee3 = new Employee();
                employee3.FirstName = "lulu";
                employee3.LastName = "lili";
                company.addEmployee(employee3);

                Employee employee4 = new Employee();
                employee4.FirstName = "lulu";
                employee4.LastName = "lili";
                company.addEmployee(employee4);
                this.Hide();
                Game game = new Game(company);
                game.Show();
                
            }




        }


    }
}
