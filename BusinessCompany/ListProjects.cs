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
    public partial class ListProjects : Form
    {

        public ListProjects(Game game)
        {
            this.listProject = game.ListProjects;
            this.company = game.Company;
            this.game = game;
            init();
        }

        Company company;
        Game game;
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
            DrawListEmployee(this.company.ListProjects);
        }

        public void DrawListEmployee(List<Project> listProjects)
        {
            int i = 0;
            foreach (Project project in listProjects)
            {
                AfficheProject afficheProject = new AfficheProject(true, project);
                afficheProject.TopLevel = false;
                afficheProject.Location = new Point(0, i * 155);
                i++;
                afficheProject.Show();
                afficheProject.Enabled = true;
                Button btnDelete = afficheProject.getButtonDelete();
                btnDelete.Click += new EventHandler(remove);
                Button btnEmployee = afficheProject.getButtonAssignedEmployee();
                btnEmployee.Click += new EventHandler(showEmployees);
                afficheProject.Dock = DockStyle.None;
                this.list.Controls.Add(afficheProject);
            }
            list.Size = new Size(300, 300);
        }

        private void remove(object sender, EventArgs e)
        {
            projectSelected = null;
            Button btnAdd = (Button)sender;
            AfficheProject affiche = (AfficheProject)btnAdd.Parent;
            Project project = affiche.Project;
            this.company.ListProjects.Remove(project);
            affiche.Hide();
            this.list.Controls.Remove(affiche);
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
            foreach(AfficheProject afficheProject in this.list.Controls)
            {
                afficheProject.getNameProject().BackColor = Color.White;
            }
            listEmployees.Controls.Clear();

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
                    afficheEmployee.Enabled = true;
                    Button btnDelete = afficheEmployee.getButtonDelete();
                    btnDelete.Click += new EventHandler(remove);
                    afficheEmployee.Dock = DockStyle.None;
                    if (projectSelected.EmployeeAssigned.Contains(employee))
                    {
                        afficheEmployee.getButtonSelect().Checked = true;
                    }
                    this.listEmployees.Controls.Add(afficheEmployee);
                }
                listEmployees.Size = new Size(300, 300);
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
                projectSelected.addEmployee(afficheEmployee.Employee);
                afficheEmployee.Employee.addProject(projectSelected);
            }
            else
            {
                projectSelected.removeEmployee(afficheEmployee.Employee);
                afficheEmployee.Employee.removeProject(projectSelected);
            }
        }
    }
}
