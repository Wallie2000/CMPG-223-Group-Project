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
    namespace CMPG223_Assignment
    {
        public partial class AccessForm : Form
        {

            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Semester 2\CMPG 223\CMPG223_Assignment\CMPG223_Assignment\Books.mdf;Integrated Security=True";
            SqlConnection con;
            SqlDataAdapter adapt;
            DataSet dSet;
            SqlCommand com;
            SqlDataAdapter reader;

            public AccessForm : Form
            {
                InitializeComponent();
            }

            //Open Order Form
            private void button1_Click(object sender, EventArgs e)
            {
                OrderForm f1 = new OrderForm();
                f1.ShowDialog();
                this.Close();
            }

            //Open Assisstant Form
            private void btnAssistant_Click(object sender, EventArgs e)
            {
                ClientForm f1 = new ClientForm();
                f1.ShowDialog();
                this.Close();
            }

            //Open Book Form
            private void selectBookToolStripMenuItem_Click(object sender, EventArgs e)
            {
                BookForm f1 = new BookForm();
                f1.ShowDialog();
                this.Close();
            }

            //Open Client Form
            private void selectClientToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ClientForm f1 = new ClientForm();
                f1.ShowDialog();
                this.Close();
            }

            //Open Order Form
            private void placeOrderToolStripMenuItem_Click(object sender, EventArgs e)
            {
                OrderForm f1 = new OrderForm();
                f1.ShowDialog();
                this.Close();
            }

            //Open Client Form
            private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
            {
                ClientForm f1 = new ClientForm();
                f1.ShowDialog();
                this.Close();
            }

            //Open Author Form
            private void manageAuthorToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Author_Form f1 = new Author_Form();
                f1.ShowDialog();
                this.Close();
            }

            //Open Genre Form
            private void manageGenreToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Genre_Form f1 = new Genre_Form();
                f1.ShowDialog();
                this.Close();
            }

            //Close program
            private void btnBack_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        
    }

}
