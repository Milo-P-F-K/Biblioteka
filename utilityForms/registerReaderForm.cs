using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class registerReaderForm : Form
    {
        Thread th;
        public registerReaderForm()
        {
            InitializeComponent();
        }

        private static Regex email_validation()
        {
            string pattern = @"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|"
                + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)"
                + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$";

            return new Regex(pattern, RegexOptions.IgnoreCase);
        }
        static Regex validate_emailaddress = email_validation();

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

        private void Register_Reader_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bibliotekaDataset1.Czytelnicy' table. You can move, or remove it, as needed.
            this.czytelnicyTableAdapter1.Fill(this.bibliotekaDataset1.Czytelnicy);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zarejestrować tego czytelnika ?", "Pytanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (textBox4.Text != "" && validate_emailaddress.IsMatch(textBox4.Text) != true)
            {
                MessageBox.Show("Nieprawidłowy format adresu email!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox4.Focus();
                return;
            }
            else if(textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Należy uzupełnić wszystkie wymagane pola.");
            }
            else
            {
                    string connectionString = ConfigurationManager.ConnectionStrings["Biblioteka.Properties.Settings.db_a8b501_bibliotekaConnectionString"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Rejestruj_Czytelnika", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.Add("@imie", SqlDbType.VarChar).Value = textBox1.Text;
                        cmd.Parameters.Add("@nazwisko", SqlDbType.VarChar).Value = textBox2.Text;
                        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = textBox3.Text;
                        cmd.Parameters.Add("@telefon", SqlDbType.VarChar).Value = textBox4.Text;
                        cmd.Parameters.Add("@data_urodzenia", SqlDbType.DateTime).Value = dateTimePicker1.Value;
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("Pomyślnie zarejestrowano czytelnika.");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            czytelnicyTableAdapter1.Fill(bibliotekaDataset1.Czytelnicy);
            this.dataGridView1.DataSource = this.czytelnicyBindingSource;
            dataGridView1.Refresh();
        }
            else if (dialogResult == DialogResult.No)
            {
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
