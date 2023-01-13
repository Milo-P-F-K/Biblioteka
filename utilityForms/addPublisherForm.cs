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
    public partial class addPublisherForm : Form
    {
        Thread th;
        public addPublisherForm()
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
        private void opennewform2(object obj)
        {
            Application.Run(new addBooksForm());
        }
        private void opennewform3(object obj)
        {
            Application.Run(new addCategoryForm());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Należy uzupełnić wszystkie wymagane pola.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zatwierdzić wprowadzone dane wydawnictwa ?", "Pytanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Dodaj_Wydawnictwo", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@nazwa", SqlDbType.VarChar).Value = textBox1.Text;

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Pomyślnie dodano wydawnictwo.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            this.wyswietl_wydawnictwaTableAdapter1.Fill(this.bibliotekaDataset1.Wyswietl_wydawnictwa);
            this.dataGridView1.DataSource = this.wyswietlwydawnictwaBindingSource;
            dataGridView1.Refresh();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }

        private void Add_Publisher_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Wyswietl_wydawnictwa' table. You can move, or remove it, as needed.
            this.wyswietl_wydawnictwaTableAdapter1.Fill(this.bibliotekaDataset1.Wyswietl_wydawnictwa);

        }
    }
}
