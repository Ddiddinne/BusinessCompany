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
    public partial class Game : Form
    {
        private Timer timer1=new Timer();
        private Company company;
        private List<Project> listProjects;
        static int i = 10;

        public List<Project> ListProjects
        {
            get { return listProjects; }
            set { listProjects = value; }
        }
        public Company Company
        {
            get { return company; }
            set { company = value; }
        }
        
        public Game(Company company)
        {
            this.listProjects = new List<Project>();
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

        private void LostGame()
        {
            timer1.Stop();
            LostGame lostGame = new LostGame();
            lostGame.Show();
            this.Close();
        }
        
        public void timer1_Tick(object sender, EventArgs e)
        {
            int expense = this.company.LevelCompany * 10;
            foreach(Employee employee in company.ListEmployee)
            {
                expense += employee.Salary / 15;
            }
            this.company.Money -= expense;
            this.CA.Text = (this.company.Money).ToString();

            double unitWork = 0.2 * 100 / 30;
            unitWork = Math.Round(unitWork, 0);

            foreach (Project project in company.ListProjects)
            {
                foreach(Employee employee in project.EmployeeAssigned)
                {
                   project.Delay -=  unitWork/ employee.ProjectAssigned.Count;
                }
                project.DelayCompetition -= project.Level*unitWork;
                //lvlProjet*unitWork
            }

            if (i == 10)
            {
                i = 0;
                listProjects.Add(new Project(this.company.LevelCompany));
            }else
            {
                i++;
            }
            
            if (this.company.Money <= 0)
            {
                this.LostGame();
            }
        }

        private void employees_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListEmployees listEmployee = new ListEmployees(this);
            listEmployee.Show();

        }

        private void projects_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListProjects listProjects = new ListProjects(this);
            listProjects.Show();
        }

        private void btnModifyLevel_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModifyLevelCompany modifyLevelCompany = new ModifyLevelCompany(this);
            modifyLevelCompany.Show();
        }
    }
}
