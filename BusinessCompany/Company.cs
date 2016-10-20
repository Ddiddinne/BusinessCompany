using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BusinessCompany
{
    class Company
    {
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

        private int level;

        public int Level
        {
            get { return level; }
            set { level = value; }
        }

        private Image picture;

        public Image Picture
        {
            get { return picture; }
            set { picture = value; }
        }



    }
}
