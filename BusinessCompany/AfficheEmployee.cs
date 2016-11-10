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
    public partial class AfficheEmployee : Form
    {
        ListAddEmployee parent;
        private Employee employee;

        public Employee Employee
        {
            get { return employee; }
            set { employee = value; }
        }
        
        public AfficheEmployee(int show,Employee employee, ListAddEmployee parent = null)
        {
            this.parent = parent;
            this.employee = employee;
            InitializeComponent();
            name.Text = String.Format("{0} {1} ", employee.FirstName, employee.LastName);
            salary.Text = String.Format("{0}$ /month", employee.Salary);
            specialisation.Text = employee.Specialisation.ToString();
            level.Text = employee.Level.ToString();
            xp.Text = String.Format("{0} xp /100", employee.Experience);
            delete.Hide();
            switch (show)
            {
                case 0:
                    add.Show(); delete.Hide(); assigned.Hide(); btFormations.Hide();
                    break;
                case 1:
                    add.Hide(); delete.Show(); assigned.Hide(); btFormations.Show();
                    break;
                case 2:
                    add.Hide(); delete.Hide(); assigned.Show(); btFormations.Hide();
                    break;
            }
            this.employee.employeeUpdate += EmployeeUpdate;
        }

        public Button getButtonDelete()
        {
            return this.delete;
        }

        public CheckBox getButtonSelect()
        {
            return this.assigned; ;
        }

        public Button getButtonFormation()
        {
            return this.btFormations;
        }

        public Label getLabelName()
        {
            return this.name;
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            Button btnAdd = (Button)sender;
            AfficheEmployee affiche = (AfficheEmployee)btnAdd.Parent;
            Employee employee = affiche.employee;
            parent.add(employee);
        }

        private void EmployeeUpdate(object sender, EventArgs e)
        {
            level.Text = employee.Level.ToString();
            xp.Text = String.Format("{0} xp /100", employee.Experience);
        }

    }
}
