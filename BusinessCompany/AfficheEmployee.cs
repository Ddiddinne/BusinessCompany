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
        public AfficheEmployee(Boolean show,Employee employee)
        {
            InitializeComponent();
            name.Text = (String)employee.FirstName + " " +(String)employee.LastName;
            salary.Text = employee.Salary.ToString() + "$";
            if (!show) { addEmployee.Hide(); }
        }
    }
}
