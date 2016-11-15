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
    public partial class AfficheProject : Form
    {
        ListAddProject parent;
        private Project project;
        

        public Project Project
        {
            get { return project; }
            set { project = value; }
        }
        public AfficheProject(Boolean show, Project project, ListAddProject parent = null)
        {
            InitializeComponent();
            this.project = project;
            this.parent = parent;
            projectName.Text = project.Name.ToString();
            timeProject.Text = String.Format("{0} days", project.Delay);
            timeConcurent.Text = String.Format("{0} days", project.DelayCompetition); 
            this.project.timeDelayChange+=TimeDelayChange;
            this.lbLevel.Text = this.project.Level.ToString();
            this.lbMoney.Text = String.Format("{0} $", this.project.Price);
            this.picture.BackgroundImage = project.Picture;
            if (show) { add.Hide(); delete.Show(); Employees.Show(); }
        }

        public Button getButtonDelete()
        {
            return this.delete;
        }

        public Label getNameProject()
        {
            return this.projectName;
        }

        private void add_Click(object sender, EventArgs e)
        {
            Button btnAdd = (Button)sender;
            AfficheProject affiche = (AfficheProject)btnAdd.Parent;
            Project project = affiche.project;
            parent.add(project);
        }

        public Button getButtonAssignedEmployee()
        {
            return this.Employees;
        }
        private void TimeDelayChange(object sender, EventArgs e)
        {
            
            timeProject.Text = String.Format("{0} days", project.Delay);

            if (timeConcurent != null && project !=null)
            {
                timeConcurent.Text = String.Format("{0} days", project.DelayCompetition);
            }
        }

    }
}
