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
        
        public AfficheEmployee(Boolean show,Employee employee, ListAddEmployee parent = null)
        {
            this.parent = parent;
            this.employee = employee;
            InitializeComponent();
            this.BackColor = System.Drawing.Color.BlueViolet;
            name.Text = employee.FirstName.ToString() + " " +employee.LastName.ToString();
            salary.Text = employee.Salary.ToString() + "$";
            specialisation.Text = employee.Specialisation.ToString();
            level.Text = employee.Level.ToString();
            delete.Hide();
            if (show) { add.Hide(); delete.Show(); }
        }

        public Button getButtonDelete()
        {
            return this.delete;
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            Button btnAdd = (Button)sender;
            AfficheEmployee affiche = (AfficheEmployee)btnAdd.Parent;
            Employee employee = affiche.employee;

            MessageBox.Show(this.employee.LastName.ToString());
            parent.add(employee);
        }

    }
}
