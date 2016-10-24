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
        public Project() {
            this.employeeAssigned = new List<Employee>();
        }
        private String name;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        //we decide to choose the time as a flaot of mounth
        private double time; 

        public double Time
        {
            get { return time; }
            set { time = value; }
        }

        private double timeCompetition;

        public double TimeCompetition
        {
            get { return timeCompetition; }
            set { timeCompetition = value; }
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
            set { delayCompetition = value; }
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

        private float partMarket;

        public float PartMarcket
        {
            get { return partMarket; }
            set { partMarket = value; }
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
        


    }
}
