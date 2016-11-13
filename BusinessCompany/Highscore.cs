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
            string address = "Data Source=(D:\\ISEN\\M2\\C#PROJETCLONE\\CLONEBUSINESS\\BUSINESSCOMPANY\\RESULT.MDF)\\v11.0;Initial Catalog=yourDB;Integrated Security=True";
            SqlConnection conn = connectionDatabase(address);
            //try to prepare the command for read all the data from the table score
            SqlCommand cmdRead = prepareCommand("SELECT * FROM Score", conn);
            SqlDataReader reader;

            //read the data
            reader = cmdRead.ExecuteReader();

            //display the data into the textbox
            this.txtScore.Text = reader.ToString();

            //close the connection
            conn.Close();
        }

        public Highscore(Company company,DateTime date)
        {
            InitializeComponent();
            //try to connect to the database, be careful change the address
            string address = "Data Source=(D:\\ISEN\\M2\\C#PROJETCLONE\\CLONEBUSINESS\\BUSINESSCOMPANY\\RESULT.MDF)\\v11.0;Initial Catalog=yourDB;Integrated Security=True";
            SqlConnection conn = connectionDatabase(address);
            //try to prepare the command for read all the data from the table score
            SqlCommand cmdRead = prepareCommand("SELECT * FROM Score",conn);

            //try to prepare the command for read all the data from the table score
            string dateFormat = date.ToString("d MMM yyyy", CultureInfo.CreateSpecificCulture("en-US"));

            SqlCommand cmdAddData = prepareCommand("INSERT INTO Score(NameCompany,LevelCompany,LevelGame,DateEndGame VALUES (company.Name,company.LevelCompany,company.LevelGame,dateFormat)", conn); ;
            SqlDataReader reader;
      
            //read the data
            reader = cmdRead.ExecuteReader();

            //display the data into the textbox
            this.txtScore.Text = reader.ToString();

            //close the connection
            conn.Close();
        }

        private SqlConnection connectionDatabase(string address){
            //try to connect to the database, be careful change the address
            SqlConnection conn = new SqlConnection(address);
            conn.Open();
            return conn;
        }

        private SqlCommand prepareCommand(string commandText, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = commandText;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            return cmd;
        }
    }
}
