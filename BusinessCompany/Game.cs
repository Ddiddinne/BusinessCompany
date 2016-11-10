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
        private Timer timer1=new Timer();
        private Company company;
        private List<Project> listProjects;
        static int i = 10;

        public event EventHandler timeChange;
        public event EventHandler projectRemove;

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
                expense += employee.Salary / 30;
            }
            this.company.Money -= expense;
            this.CA.Text = String.Format("{0}$", this.company.Money);

            double unitWork = 1;
            unitWork = Math.Round(unitWork, 0);

            
            foreach (Project project in company.ListProjects)
            {
                foreach(Employee employee in project.EmployeeAssigned)
                {
                   project.Delay -=  unitWork/ employee.ProjectAssigned.Count;
                }
                project.DelayCompetition -= project.Level*unitWork;

            }

            //verification if the projects are ended or not
            List<Project> copyListProject = company.ListProjects;
            for (int i = copyListProject.Count - 1; i >= 0; i--)
            {
                if (copyListProject[i].DelayCompetition <= 0)
                {
                    
                    foreach(Employee employee in copyListProject[i].EmployeeAssigned)
                    {
                        employee.ProjectAssigned.Remove(copyListProject[i]);
                    }
                    company.removeProject(copyListProject[i]);
                    if (projectRemove != null)
                    {
                        projectRemove(this, EventArgs.Empty);
                    }
                }
                else
                {
                    if(copyListProject[i].Delay <= 0)
                    {
                        company.Money += copyListProject[i].Price;
                        
                        foreach(Employee employee in copyListProject[i].EmployeeAssigned)
                        {
                            employee.Experience += 50;
                            employee.ProjectAssigned.Remove(copyListProject[i]);
                        }
                        company.removeProject(copyListProject[i]);
                        if (projectRemove != null)
                        {
                            projectRemove(this, EventArgs.Empty);
                        }
                    }
                }
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
            if (timeChange != null)
            {
                timeChange(this, EventArgs.Empty);
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
