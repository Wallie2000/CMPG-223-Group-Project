using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CMPG223_Assignment
{
    public partial class Genre_Form : Form
    {

        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Semester 2\CMPG 223\CMPG223_Assignment\CMPG223_Assignment\Books.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataSet dSet;
        SqlCommand com;
        SqlDataAdapter reader;
        public static int genreId;

        public Genre_Form()
        {
            InitializeComponent();
        }


        //Populate combox from SQL Table 
        private void Populate()
        {
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();



                string sql = "SELECT Genre_ID FROM GENRE ";
                com = new SqlCommand(sql, con);
                SqlDataReader reader = com.ExecuteReader();


                while (reader.Read())
                {
                    cbGenreId.Items.Add(reader.GetValue(0));
                    cbSelect.Items.Add(reader.GetValue(0));

                }

                LoadDGW();

                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

      