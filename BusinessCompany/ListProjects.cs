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
    public partial class ListProjects : Form
    {

        public ListProjects(Game game)
        {
            this.listProject = game.ListProjects;
            this.company = game.Company;
            this.game = game;
            this.game.timeChange += TimeChange;
            this.game.projectRemove += ProjectRemove;
            this.game.storyGoOn += storyShow;
            this.game.loseGame += loseGame;
            init();
        }

        public Company company;
        public Game game;
        private Project projectSelected;
        private List<Project> listProject = new List<Project>();
        public List<Project> ListProject
        {
            get { return listProject; }
            set { listProject = value; }
        }

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }

        private void init()
        {
            InitializeComponent();
            this.BackgroundImage = company.Picture;
            this.lbCA.Text = String.Format("{0}$", this.company.Money);
            DrawListProjects(this.company.ListProjects);
            
        }

        public void DrawListProjects(List<Project> listProjects)
        {
            if (listProjects.Count() != 0)
            {
                int i = 0;
                //draw the list of projects
                foreach (Project project in listProjects)
                {
                    AfficheProject afficheProject = new AfficheProject(true, project);
                    afficheProject.TopLevel = false;
                    afficheProject.Location = new Point(0, i * 155);
                    i++;
                    afficheProject.Show();
                    Button btnDelete = afficheProject.getButtonDelete();
                    btnDelete.Click += new EventHandler(remove);
                    Button btnEmployee = afficheProject.getButtonAssignedEmployee();
                    btnEmployee.Click += new EventHandler(showEmployees);
                    this.pnlList.Controls.Add(afficheProject);
                }
                pnlList.Size = new Size(315, 300);
            }
        }

        private void remove(object sender, EventArgs e)
        {
            projectSelected = null;
            Button btnAdd = (Button)sender;
            AfficheProject affiche = (AfficheProject)btnAdd.Parent;
            Project project = affiche.Project;
            foreach(Employee employee in project.EmployeeAssigned)
            {
                employee.removeProject(project);
            }
            this.company.ListProjects.Remove(project);
            affiche.Hide();
            this.pnlList.Controls.Remove(affiche);
            this.refresh();
        }

        private void showEmployees(object sender, EventArgs e)
        {
            Button buttonClicked = (Button)sender;
            AfficheProject afficheProjectSelected = (AfficheProject)buttonClicked.Parent;
            Boolean isAlreadySelected=false;
            projectSelected = null;

            //To know is the project has already selected or not
            if(afficheProjectSelected.getNameProject().BackColor == Color.Gray)
            {
                isAlreadySelected = true;
            }
            //We deselect all the project and so clear ListEmployees to visually have any project selected
            foreach(AfficheProject afficheProject in this.pnlList.Controls)
            {
                afficheProject.getNameProject().BackColor = Color.White;
            }
            pnlListEmployees.Controls.Clear();

            //If the project has never selected, we create the employees in the ListEmployees
            if (!isAlreadySelected) {
                afficheProjectSelected.getNameProject().BackColor = Color.Gray;
                projectSelected = afficheProjectSelected.Project;
                int i = 0;
                foreach (Employee employee in company.ListEmployee)
                {
                    AfficheEmployee afficheEmployee = new AfficheEmployee(2, employee);
                    afficheEmployee.getButtonSelect().Click += new EventHandler(select);
                    afficheEmployee.TopLevel = false;
                    afficheEmployee.Location = new Point(0, i * 100);
                    i++;
                    afficheEmployee.Show();
                    Button btnDelete = afficheEmployee.getButtonDelete();
                    btnDelete.Click += new EventHandler(remove);
                    if (projectSelected.EmployeeAssigned.Contains(employee))
                    {
                        afficheEmployee.getButtonSelect().Checked = true;
                    }
                    this.pnlListEmployees.Controls.Add(afficheEmployee);
                }
                pnlListEmployees.Size = new Size(300, 300);
            }
            
        }

        public void refresh()
        {
            this.Controls.Clear();
            this.init();
        }

        private void addProject_Click(object sender, EventArgs e)
        {

            ListAddProject listAddEmployee = new ListAddProject(this);
            this.Hide();
            listAddEmployee.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Close();
        }

        private void select(object sender, EventArgs e)
        {
            CheckBox checkAssigned = (CheckBox)sender;
            AfficheEmployee afficheEmployee = (AfficheEmployee)checkAssigned.Parent;

            if (checkAssigned.Checked)
            {
                if (projectSelected.Level <= afficheEmployee.Employee.Level)
                {
                    projectSelected.addEmployee(afficheEmployee.Employee);
                    afficheEmployee.Employee.addProject(projectSelected);
                }
                else {
                    afficheEmployee.getButtonSelect().Checked = false;
                    afficheEmployee.getButtonSelect().Text = "level insufficient";
                }
            }
            else
            {
                projectSelected.removeEmployee(afficheEmployee.Employee);
                afficheEmployee.Employee.removeProject(projectSelected);
            }
        }
        private void TimeChange(object sender, EventArgs e)
        {
            this.lbCA.Text = String.Format("{0}$", this.company.Money);
        }

        private void ProjectRemove(object sender, EventArgs e)
        {
            refresh();
        }

        private void storyShow(object sender, EventArgs e)
        {
            //If we are in this form, we hide it, and show the story
            if (this.Visible)
            {
                game.timer1.Stop();
                this.Hide();
                AfficheStory story = new AfficheStory(this, company, game.timer1, this.game.IndexStory);
                this.game.IndexStory++;
            }
        }

        private void loseGame(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
