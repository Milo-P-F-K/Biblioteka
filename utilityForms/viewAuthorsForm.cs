using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class viewAuthorsForm : Form
    {
        Thread th;
        public viewAuthorsForm()
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
                    using (SqlCommand rdr = new SqlCommand("EXEC [dbo].[Wyswietl_autorow]", conn))
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


        private void View_Authors_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Wyswietl_autorow' table. You can move, or remove it, as needed.
            this.wyswietl_autorowTableAdapter.Fill(this.bibliotekaDataset1.Wyswietl_autorow);

        }
    }
}
