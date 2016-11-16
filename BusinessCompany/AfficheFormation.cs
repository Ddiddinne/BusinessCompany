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
    public partial class AfficheFormation : Form
    {
        private int price;
        private int xp;

        public int Xp
        {
            get { return xp; }
            set { xp = value; }
        }


        public int Price
        {
            get { return price; }
        }

        public AfficheFormation(String name, int indice)
        {
            InitializeComponent();
            indice++;

            //Initialize the parameters of the formation
            price = indice * 1000;
            xp = indice * 10;

            //Initialize the labels
            nameFormation.Text = name;
            lbPrice.Text = String.Format("Price: {0}$", price);
            lbXpEarn.Text = String.Format("+{0}xp", xp);
        }

        public Button getBtForm()
        {
            return this.btForm;
        }
    }
}
