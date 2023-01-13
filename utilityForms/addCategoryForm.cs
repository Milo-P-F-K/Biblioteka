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
    public partial class addCategoryForm : Form
    {
        Thread th;
        public addCategoryForm()
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Należy uzupełnić wszystkie wymagane pola.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zatwierdzić wprowadzone dane kategorii ?", "Pytanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Dodaj_Kategorie", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@nazwa", SqlDbType.VarChar).Value = textBox1.Text;

                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Pomyślnie dodano kategorię.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    this.wyswietl_kategorieTableAdapter2.Fill(this.bibliotekaDataset1.Wyswietl_kategorie);
                    this.dataGridView1.DataSource = this.wyswietlkategorieBindingSource;
                    dataGridView1.Refresh();
                }

                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }
            private void Add_Category_Load(object sender, EventArgs e)
            {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Wyswietl_kategorie' table. You can move, or remove it, as needed.
            this.wyswietl_kategorieTableAdapter2.Fill(this.bibliotekaDataset1.Wyswietl_kategorie);

            }

    }
}
