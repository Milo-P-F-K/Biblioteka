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
    public partial class registerEmployeeForm : Form
    {
        Thread th;
        public registerEmployeeForm()
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
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz dodać tego pracownika ?", "Pytanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || comboBox1.Text == "")
                {
                    MessageBox.Show("Należy uzupełnić wszystkie wymagane pola.");
                }
                else
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Rejestruj_Pracownika", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@imie", SqlDbType.VarChar).Value = textBox1.Text;
                            cmd.Parameters.Add("@nazwisko", SqlDbType.VarChar).Value = textBox2.Text;
                            cmd.Parameters.Add("@id_rola", SqlDbType.Int).Value = comboBox1.SelectedValue;
                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Pomyślnie zarejestrowano pracownika.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    this.pracownicy_i_stanowiskaTableAdapter2.Fill(bibliotekaDataset1.Pracownicy_i_stanowiska);
                    this.dataGridView1.DataSource = this.pracownicyistanowiskaBindingSource;
                    dataGridView1.Refresh();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void Register_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter2.Fill(this.bibliotekaDataset1.Role);
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Pracownicy_i_stanowiska' table. You can move, or remove it, as needed.
            this.pracownicy_i_stanowiskaTableAdapter2.Fill(this.bibliotekaDataset1.Pracownicy_i_stanowiska);
        }
    }
}
