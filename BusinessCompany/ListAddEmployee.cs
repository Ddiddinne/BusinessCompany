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
            this.IsMdiContainer = true;
            int i = 0;

            foreach (Employee employee in listEmployees.ListPerson)
            {

                AfficheEmployee afficheEmployee = new AfficheEmployee(false, employee);
                afficheEmployee.Name = employee.FirstName.ToString() + " " + employee.LastName.ToString();
                afficheEmployee.MdiParent = this;
                afficheEmployee.Location = new Point(200, i * 100);
                i++;

                afficheEmployee.Show();
                afficheEmployee.Dock = DockStyle.None;

            }
            foreach(Control c in this.Controls)
            {
                if (c is MdiClient)

                {

                    MdiClient mdiclient = (MdiClient)c;
                    mdiclient.Click += new EventHandler(affiche_Click);

                }


            }
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            listEmployees.Show();
            this.Close();
        }

        private void affiche_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In");
        }
    }
}
