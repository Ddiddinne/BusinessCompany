using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*The connection to the database doesn't work. I don't know why
Maybe we have also to put company.Name for example into a variable for the insert works
I don't know
 */
namespace BusinessCompany
{
    public partial class Highscore : Form
    {
        public Highscore()
        {
            InitializeComponent();
            //try to connect to the database, be careful change the address
            string address ="Data Source=(D:\\ISEN\\M2\\C#PROJETCLONE\\CLONEBUSINESS\\BUSINESSCOMPANY\\RESULT.MDF)\\v11.0;Initial Catalog=yourDB;Integrated Security=True"; 
            SqlConnection conn = new SqlConnection(address);
            SqlCommand cmd=new SqlCommand();
            SqlDataReader reader;

            //try to prepare the command for read all the data from the table score
            cmd.CommandText="SELECT * FROM Score";
            cmd.CommandType=CommandType.Text;
            cmd.Connection=conn;

            //open the connection
            conn.Open();//Error->don't know the server

            //read the data
            reader=cmd.ExecuteReader();
            
            //display the data into the textbox
            this.txtScore.Text=reader.ToString();

            //close the connection
            conn.Close();
        }

        public Highscore(Company company,DateTime date)
        {
            InitializeComponent();
            //try to connect to the database, be careful change the address
            string address = "Data Source=(D:\\ISEN\\M2\\C#PROJETCLONE\\CLONEBUSINESS\\BUSINESSCOMPANY\\RESULT.MDF)\\v11.0;Initial Catalog=yourDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(address);
            SqlCommand cmdRead = new SqlCommand();
            SqlCommand cmdAddData = new SqlCommand();
            SqlDataReader reader;
      
            //try to prepare the command for read all the data from the table score
            cmdRead.CommandText = "SELECT * FROM Score";
            cmdRead.CommandType = CommandType.Text;
            cmdRead.Connection = conn;


            //try to prepare the command for read all the data from the table score
            string dateFormat=date.ToString("d MMM yyyy", CultureInfo.CreateSpecificCulture("en-US"));
            cmdAddData.CommandText = "INSERT INTO Score(NameCompany,LevelCompany,LevelGame,DateEndGame VALUES (company.Name,company.LevelCompany,company.LevelGame,dateFormat)";
            cmdAddData.CommandType = CommandType.Text;
            cmdAddData.Connection = conn;
            //open the connection
            conn.Open();//Error->don't know the server

            //read the data
            reader = cmdRead.ExecuteReader();

            //display the data into the textbox
            this.txtScore.Text = reader.ToString();

            //close the connection
            conn.Close();
        }

        private void connectionDatabase(){

        }
    }
}
