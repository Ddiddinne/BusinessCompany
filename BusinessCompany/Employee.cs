using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessCompany
{
    class Employee
    {
        //test comment2
        private String lastName;

        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private String firstName;

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private int motivation;

        public int Motivation
        {
            get { return motivation; }
            set { motivation = value; }
        }

        private int experience;

        public int Experience
        {
            get { return experience; }
            set { experience = value; }
        }

        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public enum Specialty
            {
                designer, developper
            };

        private Specialty specialisation;

        public Specialty Specialisation
        {
            get { return specialisation; }
            set { specialisation = value; }
        }

        private Image portrait;

        public Image Portrait
        {
            get { return portrait; }
            set { portrait = value; }
        }

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        private List<Project> projectAssigned;

        public List<Project> ProjectAssigned
        {
            get { return projectAssigned; }
            set { projectAssigned = value; }
        }


    }
}
