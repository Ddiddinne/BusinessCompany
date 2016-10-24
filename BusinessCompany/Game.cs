﻿using System;
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
    public partial class Game : Form
    {
        static Timer timer1 = new Timer();
        public Game()
        {
            InitializeComponent();
        }

        public Game(Company company)
        {
            InitializeComponent();
            companyName.Text = company.Name;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000; //(1 second)
            timer1.Start();
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            int chiffre = int.Parse(CA.Text);

            CA.Text = ((int)chiffre - 1).ToString();

        }
    }
}