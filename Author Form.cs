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
    public partial class Author_Form : Form
    {

        string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Semester 2\CMPG 223\CMPG223_Assignment\CMPG223_Assignment\Books.mdf;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataSet dSet;
        SqlCommand com;
        SqlDataAdapter reader;

        public Author_Form()
        {
            InitializeComponent();
        }

        public static int authorId;

        //populate combobox from SQL Table
        private void Populate()
        {
            
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();



                string sql = "SELECT Author_ID FROM AUTHOR ";
                com = new SqlCommand(sql, con);
                SqlDataReader reader = com.ExecuteReader();


                while (reader.Read())
                {
                    cbAuthorId.Items.Add(reader.GetValue(0));
                    cbSelect.Items.Add(reader.GetValue(0));

                }

               
                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Load datagrid View
        public void LoadDGW()
        {
            try
            {
               

                //con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql = @"SELECT * FROM AUTHOR";

                com = new SqlCommand(sql, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "AUTHOR");


                DGWAuthor.DataSource = dSet;
                DGWAuthor.DataMember = "AUTHOR";

                con.Close();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }

        }

        //open Access form 
        private void btnBack_Click(object sender, EventArgs e)
        {
            AccessForm f1 = new AccessForm();
            f1.Show();
        }


        //remove author form dgw 
        private void btnRemove_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {
                con.Open();

                string sql = "DELETE FROM AUTHOR WHERE Author_ID = @id";

                com = new SqlCommand(sql, con);
                com.Parameters.AddWithValue("@id", cbAuthorId.SelectedItem);
                com.ExecuteNonQuery();


                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                string sql2 = @"SELECT * FROM AUTHOR";

                com = new SqlCommand(sql2, con);

                adapt.SelectCommand = com;
                adapt.Fill(dSet, "AUTHOR");


                DGWAuthor.DataSource = dSet;
                DGWAuthor.DataMember = "AUTHOR";

                //Display Message 
                MessageBox.Show("Author Deleted ");
                con.Close();

                LoadDGW();
                cbAuthorId.Items.Clear();
                cbSelect.Items.Clear();
                Populate();

                


            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Load form Load 
        private void Author_Form_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);

            Populate();
            LoadDGW();
            

        }

        //Search Author via Id or Name
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
            con = new SqlConnection(conString);
          
            try
            {
                con.Open();
                adapt = new SqlDataAdapter();
                dSet = new DataSet();

                if (txtSearch.Text != "")
                {
                    string sql = @"SELECT * FROM AUTHOR WHERE Author_ID LIKE '%" + txtSearch.Text + "%'";

                    com = new SqlCommand(sql, con);

                    adapt.SelectCommand = com;
                    adapt.Fill(dSet, "tblAuthor");

                    string sql2 = @"SELECT * FROM AUTHOR WHERE First_Name LIKE '%" + txtSearch.Text + "%'";

                    com = new SqlCommand(sql2, con);

                    adapt.SelectCommand = com;
                    adapt.Fill(dSet, "AUTHOR");


                    DGWAuthor.DataSource = dSet;
                    DGWAuthor.DataMember = "AUTHOR";

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

        //Insert new Author
        private void btnInsertAuthor_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {
                con.Open();



                string sql = @"INSERT INTO AUTHOR(First_Name, Last_Name) VALUES(@name,@surname)";

                com = new SqlCommand(sql, con);

           
                com.Parameters.AddWithValue("@name", txtEnterAuthorname.Text);
                com.Parameters.AddWithValue("@surname", txtEnterAuthorSurname.Text);
               
                com.ExecuteNonQuery();



                MessageBox.Show("Author Inserted");

                LoadDGW();

                con.Close();
                cbAuthorId.Items.Clear();
                cbSelect.Items.Clear();
                Populate();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Update Author in dgw
        private void btnUpdateAuthor_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conString);
            try
            {

                con.Open();


                string sql = @"UPDATE AUTHOR set First_Name = @name,Last_Name = @surname  WHERE Author_ID = @id";

                com = new SqlCommand(sql, con);

                com.Parameters.AddWithValue("@name", txtEnterAuthorname.Text);
                com.Parameters.AddWithValue("@surname", txtEnterAuthorSurname.Text);
                com.Parameters.AddWithValue("@id", txtEnterAuthorId.Text);
             

                com.ExecuteNonQuery();


                //Display Message
                MessageBox.Show("Author Updated");

                LoadDGW();

                con.Close();
                cbAuthorId.Items.Clear();
                cbSelect.Items.Clear();
                Populate();

            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        //Open order Form 
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OrderForm f1 = new OrderForm();
            f1.ShowDialog();

        }

        //Set variable to combobox selected item 
        private void cbAuthorId_SelectedIndexChanged(object sender, EventArgs e)
        {
            authorId = (int)(cbAuthorId.SelectedItem);
        }
    }
}
