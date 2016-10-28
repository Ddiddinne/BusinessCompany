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

        private List<Employee> listPerson = new List<Employee>();

        public List<Employee> ListPerson
        {
            get { return listPerson; }
            set { listPerson = value; }
        }

        public ListEmployees(Game game)
        {
            this.game = game;
            InitializeComponent();
            int i = 0;
            foreach (Employee employee in game.company.ListEmployee)
            {
                
                AfficheEmployee afficheEmployee = new AfficheEmployee(true, employee);
                afficheEmployee.Name = employee.FirstName.ToString() + " " + employee.LastName.ToString();
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

        private void addEmployee_Click(object sender, EventArgs e)
        {
            while (listPerson.Count != game.company.LevelCompany * 2)
            {
                listPerson.Add(new Employee());
            }
            ListAddEmployee listAddEmployee = new ListAddEmployee(this);
            this.Hide();
            listAddEmployee.Show();
        }
    }
}
