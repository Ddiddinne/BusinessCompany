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
        
        Game game;
        private Company company;

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }


        private List<Employee> listPerson = new List<Employee>();

        public List<Employee> ListPerson
        {
            get { return listPerson; }
            set { listPerson = value; }
        }

        public ListEmployees(Game game)
        {
            this.company = game.Company;
            this.game = game;
            init();
        }
        private void init()
        {
            InitializeComponent();
            DrawListEmployee(this.company.ListEmployee);
        }

        public void DrawListEmployee(List<Employee> listEmployee)
        {
            int i = 0;
            foreach (Employee employee in company.ListEmployee)
            {
                AfficheEmployee afficheEmployee = new AfficheEmployee(true, employee);
                afficheEmployee.TopLevel = false;
                afficheEmployee.Location = new Point(0, i * 100);
                i++;
                afficheEmployee.Show();
                afficheEmployee.Enabled = true;
                Button btnDelete = afficheEmployee.getButtonDelete();
                btnDelete.Click+=new EventHandler(remove);
                afficheEmployee.Dock = DockStyle.None;
                this.list.Controls.Add(afficheEmployee);
            }
            list.Size = new Size(300, 300);
        }

        private void back_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Close(); 
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            while (listPerson.Count + company.ListEmployee.Count < game.Company.LevelCompany * 2)
            {
                listPerson.Add(new Employee());
            }
            ListAddEmployee listAddEmployee = new ListAddEmployee(this);
            this.Hide();
            listAddEmployee.Show();
        }

        public void refresh()
        {
            this.Controls.Clear();
            this.init();
        }

        private void remove(object sender, EventArgs e)
        {
            Button btnAdd = (Button)sender;
            AfficheEmployee affiche = (AfficheEmployee)btnAdd.Parent;
            Employee employee = affiche.Employee;
            MessageBox.Show(employee.LastName.ToString());
            this.company.ListEmployee.Remove(employee);
            affiche.Hide();
            this.list.Controls.Remove(affiche);
            this.refresh();
        }

  
    }
}
