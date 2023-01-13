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

namespace Biblioteka.utilityForms
{
    public partial class switchEmployeeJobForm : Form
    {
        Thread th;
        public switchEmployeeJobForm()
        {
            InitializeComponent();
        }

        private void switchEmployeeJobForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset.Pracownicy_i_stanowiska' table. You can move, or remove it, as needed.
            this.pracownicy_i_stanowiskaTableAdapter.Fill(this.bibliotekaDataset.Pracownicy_i_stanowiska);
            // TODO: This line of code loads data into the 'bibliotekaDataset.Role' table. You can move, or remove it, as needed.
            this.roleTableAdapter.Fill(this.bibliotekaDataset.Role);
            // TODO: This line of code loads data into the 'bibliotekaDataset.Lista_Pracownikow' table. You can move, or remove it, as needed.
            this.lista_PracownikowTableAdapter.Fill(this.bibliotekaDataset.Lista_Pracownikow);
            // TODO: This line of code loads data into the 'bibliotekaDataset.Pracownicy_i_stanowiska' table. You can move, or remove it, as needed.
            this.pracownicy_i_stanowiskaTableAdapter.Fill(this.bibliotekaDataset.Pracownicy_i_stanowiska);

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
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zmienić stanowisko pracownika ?", "Pytanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("switchJob", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@employeeId", SqlDbType.Int).Value = comboBox1.SelectedValue;
                    cmd.Parameters.Add("@jobId", SqlDbType.Int).Value = comboBox2.SelectedValue;
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Pomyślnie zmieniono stanowisko pracownika.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            this.pracownicy_i_stanowiskaTableAdapter.Fill(this.bibliotekaDataset.Pracownicy_i_stanowiska);
            this.dataGridView1.DataSource = this.pracownicyistanowiskaBindingSource;
            dataGridView1.Refresh();
        }
            else if (dialogResult == DialogResult.No)
            {
            }
        }
    }
}
