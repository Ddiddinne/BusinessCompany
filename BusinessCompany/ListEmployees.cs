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
            int i = 0;
            foreach (Employee employee in game.company.ListEmployee)
            {
                
                AfficheEmployee afficheEmployee = new AfficheEmployee(false, employee);
                afficheEmployee.Name = (String)employee.FirstName + (String)employee.LastName;
                afficheEmployee.TopLevel = false;
                afficheEmployee.Location = new Point(0, i * 100);
                i++;
                afficheEmployee.Show();
                afficheEmployee.Dock = DockStyle.None;
                this.list.Controls.Add(afficheEmployee);

            }
            list.Size = new Size(94*(i+1), 300);
        }

        private void back_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Close();
            
        }
    }
}
