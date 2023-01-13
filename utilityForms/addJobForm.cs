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
    public partial class addJobForm : Form
    {
        Thread th;
        public addJobForm()
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

        private void Add_Task_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter1.Fill(this.bibliotekaDataset1.Role);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Należy uzupełnić wszystkie wymagane pola.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zatwierdzić wprowadzone dane stanowiska ?", "Pytanie", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Dodaj_Role", con))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.Add("@nazwa", SqlDbType.VarChar).Value = textBox1.Text;

                            try
                            {
                                con.Open();
                                cmd.ExecuteNonQuery();
                                con.Close();
                                MessageBox.Show("Pomyślnie dodano stanowisko.");
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                        }
                    }
                    roleTableAdapter1.Fill(bibliotekaDataset1.Role);
                    this.dataGridView1.DataSource = this.roleBindingSource;
                    dataGridView1.Refresh();
                }
                else if (dialogResult == DialogResult.No)
                {
                }
            }
        }
    }
}
