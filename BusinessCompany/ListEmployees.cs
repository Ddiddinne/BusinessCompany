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
    public partial class ListEmployees : Form
    {
        Game game = new Game();
        public ListEmployees(Game game)
        {
            this.game = game;
            InitializeComponent();
            foreach (Employee employee in game.company.ListEmployee)
            {
                AfficheEmployee afficheEmployee = new AfficheEmployee(false, employee);
                afficheEmployee.Location = new Point(349, 168);

                afficheEmployee.Name = (String)employee.FirstName + (String)employee.LastName;
                afficheEmployee.TopLevel = false;
                afficheEmployee.Show();
                afficheEmployee.Dock = DockStyle.Fill;
                this.groupBox1.Controls.Add(afficheEmployee);


            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            game.Show();
            
        }
    }
}
