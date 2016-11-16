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

            //Initialize the text in the labels
            this.lbName.Text = String.Format("{0} {1} ", employee.FirstName, employee.LastName);
            this.lbSalary.Text = String.Format("{0}$ /month", employee.Salary);
            this.lbLevel.Text = employee.Level.ToString();
            this.lbXp.Text = String.Format("{0} xp /1000", employee.Experience);
            this.picture.BackgroundImage = employee.Portrait;

            //Initialize the buttons
            switch (show)
            {
                //cas0: the person is not an employee yet, we show only the button "Add"
                case 0:
                    btAdd.Show(); btFire.Hide(); chkAssigned.Hide(); btForm.Hide();
                    break;
                //cas1: the person is an employee, you can fire him or form him, so we show "Fire" and "Form" button
                case 1:
                    btAdd.Hide(); btFire.Show(); chkAssigned.Hide(); btForm.Show();
                    break;
                //cas2: the person is an employee, you can assigne him to a project, we show the "assigned" check
                case 2:
                    btAdd.Hide(); btFire.Hide(); chkAssigned.Show(); btForm.Hide();
                    break;
            }

            //event if the employee has his level updated
            this.employee.employeeUpdate += EmployeeUpdate;
        }

        public Button getButtonDelete()
        {
            return this.btFire;
        }

        public CheckBox getButtonSelect()
        {
            return this.chkAssigned; ;
        }

        public Button getButtonFormation()
        {
            return this.btForm;
        }

        public Label getLabelName()
        {
            return this.lbName;
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
            lbLevel.Text = employee.Level.ToString();
            lbXp.Text = String.Format("{0} xp /1000", employee.Experience);
        }

    }
}
