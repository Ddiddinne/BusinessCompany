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
        
        Game game;
        private Company company;
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
            this.formationName.Add("Formation Agile");
            this.formationName.Add("Conception Graphique");
            this.formationName.Add("Java avanced");
            this.formationName.Add("Concept objet");
            this.formationName.Add("Data Science");
            this.company = game.Company;
            this.game = game;
            init();
        }
        private void init()
        {
            InitializeComponent();
            this.CA.Text = String.Format("{0}$", this.company.Money);
            DrawListEmployee(this.company.ListEmployee);
            DrawListFormation();
            this.game.timeChange += TimeChange;
        }

        public void DrawListEmployee(List<Employee> listEmployee)
        {
            int i = 0;
            foreach (Employee employee in listEmployee)
            {
                AfficheEmployee afficheEmployee = new AfficheEmployee(1, employee);
                afficheEmployee.TopLevel = false;
                afficheEmployee.Location = new Point(0, i * 100);
                i++;
                afficheEmployee.Show();
                afficheEmployee.Enabled = true;
                Button btnDelete = afficheEmployee.getButtonDelete();
                btnDelete.Click+=new EventHandler(remove);
                Button btnShowFormations = afficheEmployee.getButtonFormation();
                btnShowFormations.Click += new EventHandler(showFormations);
                afficheEmployee.Dock = DockStyle.None;
                this.panelEmployees.Controls.Add(afficheEmployee);
            }
            panelEmployees.Size = new Size(300, 300);
        }

        public void DrawListFormation()
        {
            int j = 0;
            for (int i = 0; i < formationName.Count; i++)
            {
                AfficheFormation afficheFormation = new AfficheFormation(formationName[i], i);
                afficheFormation.TopLevel = false;
                afficheFormation.Location = new Point(0, j * 100);
                j++;
                afficheFormation.Show();
                afficheFormation.Enabled = true;
                Button btnForm = afficheFormation.getBtForm();
                btnForm.Click += new EventHandler(form);
                afficheFormation.Dock = DockStyle.None;
                this.panelFormations.Controls.Add(afficheFormation);
            }
            panelFormations.Size = new Size(300, 300);
            panelFormations.Hide();
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
            while (listPerson.Count + company.ListEmployee.Count < game.Company.LevelCompany * 2)
            {
                listPerson.Add(new Employee());
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
            this.panelEmployees.Controls.Remove(affiche);
            this.refresh();
        }

        private void showFormations(object sender, EventArgs e)
        {
            
            Button buttonSelected = (Button)sender;
            AfficheEmployee afficheEmployeeSelected = (AfficheEmployee)buttonSelected.Parent;
            if(employeeSelected != afficheEmployeeSelected.Employee)
            {
                panelFormations.Show();
                employeeSelected = afficheEmployeeSelected.Employee;
                afficheEmployeeSelected.getLabelName().BackColor = Color.Gray;
            }else
            {
                afficheEmployeeSelected.getLabelName().BackColor = Color.White;
                panelFormations.Hide();
                employeeSelected = null;
            }
            
        }

        private void TimeChange(object sender, EventArgs e)
        {
            this.CA.Text = String.Format("{0}$", this.company.Money);
        }


    }
}
