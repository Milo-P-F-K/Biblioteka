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
    public partial class deregisterReaderForm : Form
    {
        Thread th;
        public deregisterReaderForm()
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
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz usunąć autora?", "Pytanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Usun_Czytelnika", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@id_czytelnik", SqlDbType.VarChar).Value = comboBox1.SelectedValue;
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Pomyślnie usunięto czytelnika.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            wyswietl_czytelnikowTableAdapter1.Fill(bibliotekaDataset1.Wyswietl_czytelnikow);
            this.comboBox1.DataSource = this.wyswietlczytelnikowBindingSource;
            comboBox1.Refresh();
        }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void Deregister_Reader_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Wyswietl_czytelnikow' table. You can move, or remove it, as needed.
            this.wyswietl_czytelnikowTableAdapter1.Fill(this.bibliotekaDataset1.Wyswietl_czytelnikow);

        }

    }
}
