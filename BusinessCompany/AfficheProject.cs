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
    public partial class AfficheProject : Form
    {
        ListAddProject parent;
        private Project project;
        

        public Project Project
        {
            get { return project; }
            set { project = value; }
        }
        public AfficheProject(Boolean take, Project project, ListAddProject parent = null)
        {
            InitializeComponent();
            this.project = project;
            this.parent = parent;

            //Initialize the labels
            this.lbProjectName.Text = project.Name.ToString();
            this.lbTimeProject.Text = String.Format("{0} days", project.Delay);
            this.lbTimeConcurent.Text = String.Format("{0} days", project.DelayCompetition); 
            this.lbLevel.Text = this.project.Level.ToString();
            this.lbMoney.Text = String.Format("{0} $", this.project.Price);
            this.picture.BackgroundImage = project.Picture;

            //Event if the time Change
            this.project.timeDelayChange += TimeDelayChange;

            //If we take the project we show the "delete" and "employees" button
            if (take) { btAdd.Hide(); btDelete.Show(); btEmployees.Show(); }
        }

        public Button getButtonDelete()
        {
            return this.btDelete;
        }

        public Label getNameProject()
        {
            return this.lbProjectName;
        }

        private void add_Click(object sender, EventArgs e)
        {
            //we take the project from the parent of the button, to add it in our list of projects
            Button btnAdd = (Button)sender;
            AfficheProject affiche = (AfficheProject)btnAdd.Parent;
            Project project = affiche.project;
            parent.add(project);
        }

        public Button getButtonAssignedEmployee()
        {
            return this.btEmployees;
        }
        private void TimeDelayChange(object sender, EventArgs e)
        {
            try
            {
                if (this != null)
                {
                    // we update the Delay of the project each day
                    if (this.lbTimeConcurent != null && this.project != null && this.lbTimeProject != null)
                    {
                        this.lbTimeConcurent.Text = String.Format("{0} days", this.project.DelayCompetition);
                        this.lbTimeProject.Text = String.Format("{0} days", this.project.Delay);
                    }
                }
            }
            catch (ObjectDisposedException exception)
            {
                var test1=exception.ObjectName;
            }

        }

    }
}
