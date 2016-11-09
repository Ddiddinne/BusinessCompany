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
            name.Text = employee.FirstName.ToString() + " " +employee.LastName.ToString();
            salary.Text = employee.Salary.ToString() + "$";
            specialisation.Text = employee.Specialisation.ToString();
            level.Text = employee.Level.ToString();
            delete.Hide();
            switch (show)
            {
                case 0:
                    add.Show(); delete.Hide(); Assigned.Hide();
                    break;
                case 1:
                    add.Hide(); delete.Show(); Assigned.Hide();
                    break;
                case 2:
                    add.Hide(); delete.Hide(); Assigned.Show();
                    break;
            }
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
            parent.add(employee);
        }

    }
}
