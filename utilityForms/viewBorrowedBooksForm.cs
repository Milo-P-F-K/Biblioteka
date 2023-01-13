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
    public partial class viewBorrowedBooksForm : Form
    {
        Thread th;
        public viewBorrowedBooksForm()
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
                    using (SqlCommand rdr = new SqlCommand("EXEC [dbo].[Lista_wypozyczen]", conn))
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

        private void View_Leased_Books_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset.Lista_wypozyczen' table. You can move, or remove it, as needed.
            this.lista_wypozyczenTableAdapter4.Fill(this.bibliotekaDataset.Lista_wypozyczen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć dokonane zwroty z bazy ?", "Pytanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                using (SqlConnection con2 = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd2 = new SqlCommand("Czysc_Zwroty", con2))
                {
                    try
                    {
                        cmd2.CommandType = CommandType.StoredProcedure;
                        con2.Open();
                        cmd2.ExecuteNonQuery();
                        con2.Close();
                        MessageBox.Show("Pomyślnie wyczyszczono zapisane zwroty.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            this.lista_wypozyczenTableAdapter4.Fill(this.bibliotekaDataset.Lista_wypozyczen);
            this.books.DataSource = this.listawypozyczenBindingSource;
            books.Refresh();
        }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
