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
                afficheEmployee.Dock = DockStyle.None;
                afficheEmployee.Enabled = true;
                afficheEmployee.Show();
            }
            
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            listEmployees.Show();
            this.Close();
        }

        private void ListAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
