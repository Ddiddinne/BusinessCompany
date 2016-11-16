using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessCompany
{
    public class Project
    {
        private static int num = 0;
        private static Random random = new Random();
        public event EventHandler timeDelayChange;

        public Project(int levelCompany)
        {
            this.employeeAssigned = new List<Employee>();
            Delay = random.Next(10, 50);
            DelayCompetition = random.Next(10, 50);
            this.level = random.Next(1,levelCompany+1);
            this.name = (NameProject)num;
            this.price = random.Next(100, 600);
            imageProject(num);
            num = (num + 1) % 6;
        }
        public void imageProject(int idProject)
        {
            switch (idProject)
            {
                case 0:
                    picture = Properties.Resources.nyancat;
                    break;
                case 1:
                    picture = Properties.Resources.SimCity;
                    break;
                case 2:
                    picture = Properties.Resources.stardew;
                    break;
                case 3:
                    picture = Properties.Resources.labyrinth;
                    break;
                case 4:
                    picture = Properties.Resources.Broforce;
                    break;
                case 5:
                    picture = Properties.Resources.donjon;
                    break;
            }
        }
        public enum NameProject
        {
            Catrun, CityBuiler, FarmValley, Labyrinth, Broforce, Hammerwatch
        }

        private NameProject name;

        public NameProject Name
        {
            get { return name; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        private double delay;

        public double Delay
        {
            get { return delay; }
            set { delay = value; }
        }


        private double delayCompetition;

        public double DelayCompetition
        {
            get { return delayCompetition; }
            set { 
                delayCompetition = value;
                if (timeDelayChange != null)
                {
                    timeDelayChange(this, EventArgs.Empty);
                }
            }
        }

        private Image picture;

        public Image Picture
        {
            get { return picture; }
            set { picture = value; }
        }

        private int timeToSelect;

        public int TimeToSelect
        {
            get { return timeToSelect; }
            set { timeToSelect = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        private List<Employee> employeeAssigned;

        public List<Employee> EmployeeAssigned
        {
            get { return employeeAssigned; }
            set { employeeAssigned = value; }
        }

        public void addEmployee(Employee employee)
        {
            this.employeeAssigned.Add(employee);
        }

        public void removeEmployee(Employee employee)
        {
            this.employeeAssigned.Remove(employee);
        }



    }
}
