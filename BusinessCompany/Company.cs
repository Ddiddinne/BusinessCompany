using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessCompany
{
    public class Company
    {

        //constructor company

        public Company()
        {

        }
        public Company(String name, int level)
        {
            this.levelGame = level;
            this.Name = name;
            this.money = 100000 - (level - 1) * 1000;
            LevelCompany = 1;
            this.listEmployee = new List<Employee>();
            this.listProjects = new List<Project>();
        }


        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Employee> listEmployee;

        public List<Employee> ListEmployee
        {
            get { return listEmployee; }
            set { listEmployee = value; }
        }

        private Int64 money;

        public Int64 Money
        {
            get { return money; }
            set { money = value; }
        }

        private List<Project> listProjects;

        public List<Project> ListProjects
        {
            get { return listProjects; }
            set { listProjects = value; }
        }

        private int levelGame;

        public int LevelGame
        {
            get { return levelGame; }
            set { levelGame = value; }
        }

        private int levelCompany;

        public int LevelCompany
        {
            get { return levelCompany; }
            set { levelCompany = value;
                switch (value){
                    case 1:
                        this.picture = Properties.Resources.garage;
                        break;
                    case 2:
                        this.picture = Properties.Resources.maisonMoyenne2;
                        break;
                    default:
                        this.picture = Properties.Resources.immeuble2;
                        break;
                }
            }
        }

       
        //image de fond
        private Image picture;

        public Image Picture
        {
            get { return picture; }
        }

        

        public void addEmployee(Employee employee){
            this.listEmployee.Add(employee);
        }

        public void addProjet(Project project)
        {
            this.listProjects.Add(project);
        }


    }
}
