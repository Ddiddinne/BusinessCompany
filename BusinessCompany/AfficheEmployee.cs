﻿using System;
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
            name.Text = employee.FirstName.ToString() + " " +employee.LastName.ToString();
            salary.Text = employee.Salary.ToString() + "$";
            specialisation.Text = employee.Specialisation.ToString();
            level.Text = employee.Level.ToString();
            if (show) { addEmployee.Hide(); }
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In Affiche");
        }

        private void AfficheEmployee_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click Affiche");
        }
    }
}