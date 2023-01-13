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
    public partial class assignAuthorForm : Form
    {
        Thread th;
        public assignAuthorForm()
        {
            InitializeComponent();
        }

        private void opennewform(object obj)
        {
            Application.Run(new mainMenuForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Assign_Author_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Wyswietl_autorow' table. You can move, or remove it, as needed.
            this.wyswietl_autorowTableAdapter.Fill(this.bibliotekaDataset1.Wyswietl_autorow);
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Lista_Ksiazek' table. You can move, or remove it, as needed.
            this.lista_KsiazekTableAdapter.Fill(this.bibliotekaDataset1.Lista_Ksiazek);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz dopisać autora ?", "Pytanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Dopisz_Autora", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@id_autor", SqlDbType.VarChar).Value = comboBox1.SelectedValue;
                        cmd.Parameters.Add("@id_ksiazka", SqlDbType.VarChar).Value = comboBox2.SelectedValue;
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Pomyślnie dopisano autora.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                this.lista_KsiazekTableAdapter.Fill(this.bibliotekaDataset1.Lista_Ksiazek);
                this.dataGridView1.DataSource = this.listaKsiazekBindingSource;
                dataGridView1.Refresh();
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
