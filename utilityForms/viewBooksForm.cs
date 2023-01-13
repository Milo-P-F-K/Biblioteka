using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading;

namespace Biblioteka
{
    public partial class viewBooksForm : Form
    {
        Thread th;
        public viewBooksForm()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
            // Create an instance of the SqlConnection class, and pass the connection string as a parameter
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Open the connection

                // Create an instance of the SqlCommand class
                using (SqlCommand cmd = new SqlCommand())
                {
                    using (SqlCommand rdr = new SqlCommand("EXEC [dbo].[Lista_Ksiazek]", conn))
                    {
                        try
                        {
                            conn.Open();
                            rdr.CommandType = CommandType.Text;
                            DataTable dt = new DataTable();
                            dt.Load(rdr.ExecuteReader());
                            books.DataSource = dt;
                            conn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void opennewform(object obj)
        {
            Application.Run(new mainMenuForm());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Lista_Ksiazek' table. You can move, or remove it, as needed.
            this.lista_KsiazekTableAdapter1.Fill(this.bibliotekaDataset1.Lista_Ksiazek);

        }

    }
}
