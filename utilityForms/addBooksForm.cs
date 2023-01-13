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
    public partial class addBooksForm : Form
    {
        Thread th;
        public addBooksForm()
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

        private void Add_Book_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Lista_Ksiazek' table. You can move, or remove it, as needed.
            this.lista_KsiazekTableAdapter2.Fill(this.bibliotekaDataset1.Lista_Ksiazek);
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Wyswietl_autorow' table. You can move, or remove it, as needed.
            this.wyswietl_autorowTableAdapter1.Fill(this.bibliotekaDataset1.Wyswietl_autorow);
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Wydawnictwa' table. You can move, or remove it, as needed.
            this.wydawnictwaTableAdapter2.Fill(this.bibliotekaDataset1.Wydawnictwa);
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Kategorie' table. You can move, or remove it, as needed.
            this.kategorieTableAdapter2.Fill(this.bibliotekaDataset1.Kategorie);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Należy uzupełnić wszystkie wymagane pola.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zatwierdzić wprowadzone dane książki?", "Pytanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Dodaj_Ksiazke", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@isbn", SqlDbType.VarChar).Value = textBox1.Text;
                            cmd.Parameters.Add("@id_kategoria", SqlDbType.Int).Value = comboBox1.SelectedValue;
                            cmd.Parameters.Add("@tytul", SqlDbType.VarChar).Value = textBox2.Text;
                            cmd.Parameters.Add("@opis", SqlDbType.VarChar).Value = textBox3.Text;
                            cmd.Parameters.Add("@id_wydawnictwo", SqlDbType.Int).Value = comboBox2.SelectedValue;
                            cmd.Parameters.Add("@rok_wydania", SqlDbType.Int).Value = textBox4.Text;
                            cmd.Parameters.Add("@ilosc", SqlDbType.Int).Value = numericUpDown1.Value;

                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Pomyślnie dodano książkę.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);

                            }
                        }
                    }
                    using (SqlConnection con2 = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd2 = new SqlCommand("Przypisz_Autora", con2))
                        {
                            cmd2.CommandType = CommandType.StoredProcedure;
                            cmd2.Parameters.Add("@id_autor", SqlDbType.Int).Value = comboBox3.SelectedValue;
                            try
                            {
                                con2.Open();
                                cmd2.ExecuteNonQuery();
                                con2.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    this.lista_KsiazekTableAdapter2.Fill(this.bibliotekaDataset1.Lista_Ksiazek);
                    this.dataGridView1.DataSource = this.listaKsiazekBindingSource;
                    comboBox1.Refresh();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
                }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}