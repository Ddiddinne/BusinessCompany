using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessCompany
{
    public class Employee
    {
        
        public Employee()
        {
            Level = 1;
            Random random = new Random();
            Salary = random.Next(3, 9) * 10;
            Motivation = random.Next(1, 100);
            Specialisation = (Speciality)num;
            firstName = (FirstNames)numName;
            lastName = (LastNames)numName;
            numName = (numName + 1) % 14;
            num = (num + 1) % 2;
        }

        private static int num = 0;
        private static int numName = 0;

        public enum FirstNames
        {
            Camille, Clara, Sacha, Eva, Harry, Jérémy, Mathilde, Anne, Thomas, Raphaël, Gaspar, Sandrine, Marion, Sébastien
        }

        public enum LastNames
        {
            Onette, Puce, Touille, Luation, Covert, Jambon, Dufour, Tameire, Durand, Lannister, Delrue, Balleuil, Belfort, Toto 
        }

        private LastNames lastName;

        public LastNames LastName
        {
            get { return lastName; }
        }

        private FirstNames firstName;

        public FirstNames FirstName
        {
            get { return firstName; }
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

        public enum Speciality
            {
                designer, developper
            };

        private Speciality specialisation;

        public Speciality Specialisation
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

        private List<Project> projectAssigned = new List<Project>();

        public List<Project> ProjectAssigned
        {
            get { return projectAssigned; }
            set { projectAssigned = value; }
        }

        public void addProject(Project project)
        {
            this.projectAssigned.Add(project);
        }


    }
}
