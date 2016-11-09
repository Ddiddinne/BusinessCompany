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
            InitializeComponent();
            int i = 0;


            foreach (Employee employee in listEmployees.ListPerson)
            {

                AfficheEmployee afficheEmployee = new AfficheEmployee(false, employee, this);
                afficheEmployee.TopLevel = false;
                afficheEmployee.Location = new Point(0, i * 100);
                i++;
                afficheEmployee.Dock = DockStyle.None;
                afficheEmployee.Enabled = true;
                afficheEmployee.Show();
                this.list.Controls.Add(afficheEmployee);
            }
            list.Size = new Size(300, 300);

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

    }
}
