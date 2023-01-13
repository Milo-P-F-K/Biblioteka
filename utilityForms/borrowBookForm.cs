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
    public partial class borrowBookForm : Form
    {
        Thread th;
        public borrowBookForm()
        {
            InitializeComponent();
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

        private void Lease_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Lista_wypozyczen' table. You can move, or remove it, as needed.
            this.lista_wypozyczenTableAdapter2.Fill(this.bibliotekaDataset1.Lista_wypozyczen);
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Lista_wypozyczen' table. You can move, or remove it, as needed.
            this.lista_wypozyczenTableAdapter2.Fill(this.bibliotekaDataset1.Lista_wypozyczen);
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Lista_Pracownikow' table. You can move, or remove it, as needed.
            this.lista_PracownikowTableAdapter2.Fill(this.bibliotekaDataset1.Lista_Pracownikow);
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Ksiazki' table. You can move, or remove it, as needed.
            this.ksiazkiTableAdapter2.Fill(this.bibliotekaDataset1.Ksiazki);
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Wyswietl_czytelnikow' table. You can move, or remove it, as needed.
            this.wyswietl_czytelnikowTableAdapter2.Fill(this.bibliotekaDataset1.Wyswietl_czytelnikow);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zaksięgować to wypożyczenie ?", "Pytanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Wypozyczenie", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@id_czytelnik", SqlDbType.Int).Value = comboBox1.SelectedValue;
                    cmd.Parameters.Add("@id_ksiazka", SqlDbType.Int).Value = comboBox2.SelectedValue;
                    cmd.Parameters.Add("@id_pracownik", SqlDbType.Int).Value = comboBox3.SelectedValue;
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Pomyślnie zaksięgowano wypożyczenie.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            lista_wypozyczenTableAdapter2.Fill(bibliotekaDataset1.Lista_wypozyczen);
            this.books.DataSource = this.listawypozyczenBindingSource;
            books.Refresh();
        }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
