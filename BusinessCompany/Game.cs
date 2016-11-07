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
    public partial class Game : Form
    {
        static Timer timer1 = new Timer();

        public Company company = new Company();
        public Game()
        {
            InitializeComponent();
            
        }

        public Game(Company company)
        {
            this.company = company;
            InitializeComponent();
            this.BackgroundImage = company.Picture;
            CA.Text = company.Money.ToString();
            companyName.Text = company.Name;
            companyName.Location = new Point(
                this.Width / 2 - companyName.Width / 2,
                companyName.Location.Y);
            foreach(Control c in this.Controls)
            {
                if(c is Button)
                {
                    c.Location = new Point(
                        this.Width / 2 - c.Width / 2,
                        c.Location.Y);
                }
            }
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; //(1 second)
            timer1.Start();
        }
        
        public void timer1_Tick(object sender, EventArgs e)
        {
            int expense = company.LevelCompany * 10;
            foreach(Employee employee in company.ListEmployee)
            {
                expense += employee.Salary / 15;
            }
            company.Money -= expense;
            CA.Text = (company.Money).ToString();

            double unitWork = 0.2 * 100 / 30;
            unitWork = Math.Round(unitWork, 2);

            foreach (Project project in company.ListProjects)
            {
                foreach(Employee employee in project.EmployeeAssigned)
                {
                    project.Time +=  unitWork/ employee.ProjectAssigned.Count;
                }
            }

        }

        private void employees_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListEmployees listEmployee = new ListEmployees(this);
            listEmployee.Show();

        }
    }
}
