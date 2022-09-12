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

        //Load data Grid view
        public void LoadDGW()
        {
            try
            {
                con = new SqlConnection(conString);

                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql = @"SELECT * FROM GENRE";

                com = new SqlCommand(sql, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "GENRE");


                DGWGenre.DataSource = dSet;
                DGWGenre.DataMember = "GENRE";

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        //load Load Form 
        private void Genre_Form_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            Populate();
            LoadDGW();
        }





        //Search genre via ID or Name
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            con = new SqlConnection(conString);

            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                //Only search if string detected
                if (txtSearch.Text != "")
                {
                    string sql = @"SELECT * FROM GENRE WHERE Genre_ID LIKE '%" + txtSearch.Text + "%'";

                    com = new SqlCommand(sql, con);

                    adapt.SelectCommand = com;
                    adapt.Fill(dSet, "GENRE");

                    DGWGenre.DataSource = dSet;
                    DGWGenre.DataMember = "GENRE";

                    string sql2 = @"SELECT * FROM GENRE WHERE Genre_Name LIKE '%" + txtSearch.Text + "%'";

                    com = new SqlCommand(sql2, con);

                    adapt.SelectCommand = com;
                    adapt.Fill(dSet, "GENRE");


                    DGWGenre.DataSource = dSet;
                    DGWGenre.DataMember = "GENRE";
                }
                else
                {
                    LoadDGW();
                }

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Open Book form 
        private void btnSelect_Click(object sender, EventArgs e)
        {

            BookForm b = new BookForm();
            b.Show();
        }

        //Set variable to combobox selected item 
        private void cbGenreId_SelectedIndexChanged(object sender, EventArgs e)
        {
            genreId = (int)(cbGenreId.SelectedItem);
        }

        //Open access Form 
        private void btnBack_Click(object sender, EventArgs e)
        {
            AccessForm f1 = new AccessForm();
            f1.Show();
        }

        //remove Genre from DGW
        private void btnRemove_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(conString);
            try
            {
                con.Open();

                string sql = "Delete FROM GENRE WHERE Genre_ID = @id";

                com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", cbGenreId.SelectedItem);
                com.ExecuteNonQuery();


                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql2 = @"SELECT * FROM GENRE";

                com = new SqlCommand(sql2, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "GENRE");



                DGWGenre.DataSource = dSet;
                DGWGenre.DataMember = "GENRE";

                //Display message 
                MessageBox.Show("Genre Deleted ");
                con.Close();

                LoadDGW();
                cbSelect.Items.Clear();
                cbGenreId.Items.Clear();
                Populate();




            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Set variable to combobox selected item 
        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            genreId = (int)(cbSelect.SelectedItem);
        }

        //Insert Genre into DGW
        private void btnInsertGenre_Click(object sender, EventArgs e)
        {

            con = new SqlConnection(conString);
            try
            {
                con.Open();



                string sql = @"INSERT INTO GENRE(Genre_Name) VALUES(@name)";

                com = new SqlCommand(sql, con);


                com.Parameters.AddWithValue("@name", txtEnterGenreName.Text);


                com.ExecuteNonQuery();


                //Display message 
                MessageBox.Show("Genre Inserted");

                LoadDGW();

                con.Close();
                cbSelect.Items.Clear();
                cbGenreId.Items.Clear();
                Populate();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Update Genre in DGW
        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {

                con.Open();

                string sql = @"UPDATE GENRE set Genre_Name = @name  WHERE Genre_ID = @id";

                com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@name", txtEnterGenreName.Text);
                com.Parameters.AddWithValue("@id", txtEnterGenreId.Text);


                com.ExecuteNonQuery();


                //Display message 
                MessageBox.Show("Genre Updated");

                LoadDGW();

                con.Close();
                cbSelect.Items.Clear();
                cbGenreId.Items.Clear();
                Populate();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}