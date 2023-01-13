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
    public partial class addAuthorForm : Form
    {
        Thread th;
        public addAuthorForm()
        {
            InitializeComponent();
        }

        private void opennewform(object obj)
        {
            Application.Run(new mainMenuForm());
        }

        private void opennewform2(object obj)
        {
            Application.Run(new addBooksForm());
        }
        private void opennewform3(object obj)
        {
            Application.Run(new addPublisherForm());
        }
        private void opennewform4(object obj)
        {
            Application.Run(new addCategoryForm());
        }

        private void opennewform5(object obj)
        {
            Application.Run(new addAuthorForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Należy uzupełnić wszystkie wymagane pola.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy napewno chcesz zatwierdzić wprowadzone dane autora?", "Pytanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Dodaj_Autora", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@imie", SqlDbType.VarChar).Value = textBox1.Text;
                            cmd.Parameters.Add("@nazwisko", SqlDbType.VarChar).Value = textBox3.Text;
                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Pomyślnie dodano autora.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    wyswietl_autorowTableAdapter1.Fill(bibliotekaDataset1.Wyswietl_autorow);
                    this.dataGridView1.DataSource = this.wyswietlautorowBindingSource;
                    dataGridView1.Refresh();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }
        private void Add_Author_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Wyswietl_autorow' table. You can move, or remove it, as needed.
            this.wyswietl_autorowTableAdapter1.Fill(this.bibliotekaDataset1.Wyswietl_autorow);

        }
    }
}
