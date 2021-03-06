﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessCompany
{
    public class Employee
    {

        private static Random random = new Random();

        public event EventHandler employeeUpdate;
        public Employee()
        {

            //Initialize the parameters
            this.level = 1;
            this.salary = random.Next(3, 9) * 10;
            this.experience = 0;
            this.firstName = (FirstNames)numName;
            this.lastName = (LastNames)numName;
            this.setPortrait(numName);
            numName = (numName + 1) % 13;
        }
        
        private static int numName = 0;

        public enum FirstNames
        {
            Camille, Clara, Sacha, Eva, Harry, Jérémy, Mathilde, Félix, Thomas, Raphaël, Gaspar, Sandrine, Marie
        }
        
        public enum LastNames
        {
            Onette, Puce, Touille, Luation, Covert, Jambon, Dufour, Tameire, Durand, Lannister, Delrue, Belfort, Toto 
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

        private int experience;

        public int Experience
        {
            get { return experience; }
            //We increment the level of the employee depending on his experience
            set { experience = value;
                if (experience >= 1000)
                {
                    experience -= 1000;
                    level += 1;
                }
                if (employeeUpdate != null)
                {
                    employeeUpdate(this, EventArgs.Empty);
                }
            }
        }

        private int salary;

        public int Salary
        {
            get { return salary; }
        }

        private Image portrait;

        public Image Portrait
        {
            get { return portrait; }
        }

        private int level;

        public int Level
        {
            get { return level; }
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

        public void removeProject(Project project)
        {
            this.projectAssigned.Remove(project);
        }

        public void setPortrait(int idPerso)
        {
            switch (idPerso)
            { 
                case 0:
                    portrait = Properties.Resources.persoF;
                    break;
                case 1:
                    portrait = Properties.Resources.persoG;
                    break;
                case 2:
                    portrait = Properties.Resources.persoC;
                    break;
                case 3:
                    portrait = Properties.Resources.persoD;
                    break;
                case 4:
                    portrait = Properties.Resources.persoB;
                    break;
                case 5:
                    portrait = Properties.Resources.persoH;
                    break;
                case 6:
                    portrait = Properties.Resources.persoE;
                    break;
                case 7:
                    portrait = Properties.Resources.persoA;
                    break;
                case 8:
                    portrait = Properties.Resources.persoI;
                    break;
                case 9:
                    portrait = Properties.Resources.persoJ;
                    break;
                case 10:
                    portrait = Properties.Resources.persoK;
                    break;
                case 11:
                    portrait = Properties.Resources.persoL;
                    break;
                case 12:
                    portrait = Properties.Resources.persoM;
                    break;
            }
        }
    }
}
