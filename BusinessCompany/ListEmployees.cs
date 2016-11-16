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
    public partial class ListEmployees : Form
    {

        public Game game;
        public Company company;
        private List<String> formationName = new List<String>();
        private Employee employeeSelected;

        public Company Company
        {
            get { return company; }
            set { company = value; }
        }


        private List<Employee> listPerson = new List<Employee>();

        public List<Employee> ListPerson
        {
            get { return listPerson; }
            set { listPerson = value; }
        }

        public ListEmployees(Game game)
        {
            //Initialize the list of the formations' name
            this.formationName.Add("Formation Agile");
            this.formationName.Add("Conception Graphique");
            this.formationName.Add("Java avanced");
            this.formationName.Add("Concept objet");
            this.formationName.Add("Data Science");
            this.company = game.Company;
            this.game = game;
            game.loseGame += loseGame;
            init();
        }
        private void init()
        {
            InitializeComponent();
            this.BackgroundImage = company.Picture;
            this.lbCA.Text = String.Format("{0}$", this.company.Money);
            //Show the employees and draw the formations but hided (it will be shown if the player click on "Form")
            DrawListEmployee(this.company.ListEmployee);
            DrawListFormation();
            this.game.timeChange += TimeChange;
            this.game.storyGoOn += storyShow;
        }

        public void DrawListEmployee(List<Employee> listEmployee)
        {
            int i = 0;
            //Show the employees
            foreach (Employee employee in listEmployee)
            {
                AfficheEmployee afficheEmployee = new AfficheEmployee(1, employee);
                afficheEmployee.TopLevel = false;
                afficheEmployee.Location = new Point(0, i * 100);
                i++;
                afficheEmployee.Show();
                Button btnDelete = afficheEmployee.getButtonDelete();
                btnDelete.Click += new EventHandler(remove);
                Button btnShowFormations = afficheEmployee.getButtonFormation();
                btnShowFormations.Click += new EventHandler(showFormations);
                this.pnlEmployees.Controls.Add(afficheEmployee);
            }
            pnlEmployees.Size = new Size(300, 300);
        }

        public void DrawListFormation()
        {
            int j = 0;
            //Draw the list of the formations
            for (int i = 0; i < formationName.Count; i++)
            {
                AfficheFormation afficheFormation = new AfficheFormation(formationName[i], i);
                afficheFormation.TopLevel = false;
                afficheFormation.Location = new Point(0, j * 100);
                j++;
                afficheFormation.Show();
                Button btnForm = afficheFormation.getBtForm();
                btnForm.Click += new EventHandler(form);
                this.pnlFormations.Controls.Add(afficheFormation);
            }
            pnlFormations.Size = new Size(300, 300);
            //It is hidding but it will be shown if the player click on "Form"
            pnlFormations.Hide();
        }

        private void back_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Close();
        }

        private void form(object sender, EventArgs e)
        {
            Button btForm = (Button)sender;
            AfficheFormation formation = (AfficheFormation)btForm.Parent;
            if (company.Money > formation.Price)
            {
                company.Money -= formation.Price;
                employeeSelected.Experience += formation.Xp;
            }
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            int k = 0;
            while ((listPerson.Count + company.ListEmployee.Count < game.Company.LevelCompany * 2)&&(k<=13))
            {

                Employee person = new Employee();
                bool alreadyKnown = false;
                //Verification if the person is already a candidate (we have just 13 persons)
                foreach(Employee employee in listPerson)
                {
                    if ((person.FirstName == employee.FirstName) && (person.LastName == employee.LastName)){
                        alreadyKnown = true;
                    }
                }

                //Verification if the person is already an employee
                foreach (Employee employee in company.ListEmployee)
                {
                    if ((person.FirstName == employee.FirstName) && (person.LastName == employee.LastName))
                    {
                        alreadyKnown = true;
                    }
                }
                //If he is not already known, we can add him in our list
                if (!alreadyKnown)
                {
                    listPerson.Add(person);
                }
              k++;
            }
            ListAddEmployee listAddEmployee = new ListAddEmployee(this);
            this.Hide();
            listAddEmployee.Show();
        }

        public void refresh()
        {
            this.Controls.Clear();
            this.init();
        }

        private void remove(object sender, EventArgs e)
        {
            Button btnAdd = (Button)sender;
            AfficheEmployee affiche = (AfficheEmployee)btnAdd.Parent;
            Employee employee = affiche.Employee;
            foreach (Project project in employee.ProjectAssigned)
            {
                project.removeEmployee(employee);
            }
            this.company.ListEmployee.Remove(employee);
            affiche.Hide();
            this.pnlEmployees.Controls.Remove(affiche);
            this.refresh();
        }

        private void showFormations(object sender, EventArgs e)
        {

            Button buttonSelected = (Button)sender;
            AfficheEmployee afficheEmployeeSelected = (AfficheEmployee)buttonSelected.Parent;
            if (employeeSelected != afficheEmployeeSelected.Employee)
            {
                pnlFormations.Show();
                employeeSelected = afficheEmployeeSelected.Employee;
                afficheEmployeeSelected.getLabelName().BackColor = Color.Gray;
            }
            else
            {
                afficheEmployeeSelected.getLabelName().BackColor = Color.White;
                pnlFormations.Hide();
                employeeSelected = null;
            }

        }

        private void TimeChange(object sender, EventArgs e)
        {
            this.lbCA.Text = String.Format("{0}$", this.company.Money);
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
