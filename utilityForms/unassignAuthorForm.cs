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
    public partial class unassignAuthorForm : Form
    {
        Thread th;
        int a;
        public unassignAuthorForm()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void opennewform(object obj)
        {
            Application.Run(new mainMenuForm());
        }

        private void Unassign_Author_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Lista_Ksiazek' table. You can move, or remove it, as needed.
            this.lista_KsiazekTableAdapter1.Fill(this.bibliotekaDataset1.Lista_Ksiazek);
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Wyswietl_autorow' table. You can move, or remove it, as needed.
            this.wyswietl_autorowTableAdapter1.Fill(this.bibliotekaDataset1.Wyswietl_autorow);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
            // Create an instance of the SqlConnection class, and pass the connection string as a parameter
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Open the connection

                // Create an instance of the SqlCommand class
                using (SqlCommand cmd = new SqlCommand())
                {
                    try
                    {
                        conn.Open();
                        SqlDataAdapter sqlData = new SqlDataAdapter("EXEC ksiazki_autorstwa @id_autor =" + comboBox1.SelectedValue, conn);
                        // Must specify 'SelectCommand' when using get queries
                        sqlData.SelectCommand.CommandType = CommandType.Text;
                        DataTable table = new DataTable();

                        // Store data in table
                        sqlData.Fill(table);



                        comboBox2.ValueMember = "id_ksiazka";
                        comboBox2.DisplayMember = "tytul";
                        comboBox2.DataSource = table;


                        // Close connection
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            comboBox2.Refresh();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz odpisać autora od książki ?", "Pytanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Odpisz_Autora", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_autor", SqlDbType.Int).Value = comboBox1.SelectedValue;
                    cmd.Parameters.Add("@id_ksiazka", SqlDbType.Int).Value = comboBox2.SelectedValue;
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Pomyślnie odpisano autora od książki.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            lista_KsiazekTableAdapter1.Fill(bibliotekaDataset1.Lista_Ksiazek);
            this.dataGridView1.DataSource = this.listaKsiazekBindingSource;
            dataGridView1.Refresh();
        }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
