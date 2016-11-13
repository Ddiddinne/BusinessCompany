using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Forms;

namespace BusinessCompany
{
    public partial class Game : Form
    {
        private Timer timer1=new Timer();
        private Company company;
        private List<Project> listProjects;
        private DateTime date = new DateTime(2010, 1, 1);
        static int i = 10;
        private int indexStory = 0;
        

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
            lbDate.Text = date.ToString("d MMM yyyy", CultureInfo.CreateSpecificCulture("en-US"));
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

        private void LostGame(DateTime date)
        {
            timer1.Stop();
            LostGame lostGame = new LostGame();
            Highscore highscore = new Highscore(this.company, date);
            lostGame.Show();
            this.Close();
        }
        
        public void timer1_Tick(object sender, EventArgs e)
        {
            date = date.AddDays(1);
            lbDate.Text = date.ToString("d MMM yyyy", CultureInfo.CreateSpecificCulture("en-US"));
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
                   project.Delay -=  unitWork * employee.Level/ employee.ProjectAssigned.Count;
                }
                project.DelayCompetition -= project.Level*unitWork;

            }

            //verification if the projects are ended or not
            List<Project> copyListProject = company.ListProjects;
            for (int j = copyListProject.Count - 1; j >= 0; j--)
            {
                if (copyListProject[j].DelayCompetition <= 0)
                {
                    
                    foreach(Employee employee in copyListProject[j].EmployeeAssigned)
                    {
                        employee.ProjectAssigned.Remove(copyListProject[j]);
                    }
                    company.removeProject(copyListProject[j]);
                    if (projectRemove != null)
                    {
                        projectRemove(this, EventArgs.Empty);
                    }
                }
                else
                {
                    if(copyListProject[j].Delay <= 0)
                    {
                        company.Money += copyListProject[j].Price;
                        
                        foreach(Employee employee in copyListProject[j].EmployeeAssigned)
                        {
                            employee.Experience += 50;
                            employee.removeProject(copyListProject[j]);
                        }
                        company.removeProject(copyListProject[j]);
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
                this.LostGame(this.date);
            }
            if (timeChange != null)
            {
                timeChange(this, EventArgs.Empty);
            }
            if (date.Day == 2)
            {
                timer1.Stop();
                AfficheStory story = new AfficheStory(this, company, timer1, indexStory);
                this.Hide();
                story.Show();
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
