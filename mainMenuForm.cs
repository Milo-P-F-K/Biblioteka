using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Biblioteka.utilityForms;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteka
{
    public partial class mainMenuForm : Form
    {
        Thread th;
        public mainMenuForm()
        {
            InitializeComponent();
        }

        private void opennewform1 (object obj)
        {
            Application.Run(new viewBooksForm());
        }

        private void opennewform2(object obj)
        {
            Application.Run(new viewReadersForm());
        }

        private void opennewform3(object obj)
        {
            Application.Run(new viewBorrowedBooksForm());
        }

        private void opennewform4(object obj)
        {
            Application.Run(new viewEmployeesForm());
        }

        private void opennewform5(object obj)
        {
            Application.Run(new viewAuthorsForm());
        }

        private void opennewform6(object obj)
        {
            Application.Run(new addBooksForm());
        }

        private void opennewform7(object obj)
        {
            Application.Run(new addJobForm());
        }

        private void opennewform8(object obj)
        {
            Application.Run(new addPublisherForm());
        }

        private void opennewform9(object obj)
        {
            Application.Run(new addCategoryForm());
        }

        private void opennewform10(object obj)
        {
            Application.Run(new registerEmployeeForm());
        }

        private void opennewform11(object obj)
        {
            Application.Run(new registerReaderForm());
        }

        private void opennewform12(object obj)
        {
            Application.Run(new extendLeaseForm());
        }

        private void opennewform13(object obj)
        {
            Application.Run(new removeBookForm());
        }

        private void opennewform14(object obj)
        {
            Application.Run(new removeJobForm());
        }

        private void opennewform15(object obj)
        {
            Application.Run(new removeEmployeeForm());
        }

        private void opennewform16(object obj)
        {
            Application.Run(new borrowBookForm());
        }

        private void opennewform17(object obj)
        {
            Application.Run(new deregisterReaderForm());
        }

        private void opennewform18(object obj)
        {
            Application.Run(new Return_Book());
        }

        private void opennewform19(object obj)
        {
            Application.Run(new addAuthorForm());
        }

        private void opennewform20(object obj)
        {
            Application.Run(new assignAuthorForm());
        }

        private void opennewform21(object obj)
        {
            Application.Run(new removeAuthorForm());
        }
        private void opennewform22(object obj)
        {
            Application.Run(new unassignAuthorForm());
        }

        private void opennewform23(object obj)
        {
            Application.Run(new switchEmployeeJobForm());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform2);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform3);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform4);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform5);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy autor książki którą chcesz dodać jest już obecny na liście autorów w bazie ?", "Pytanie", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DialogResult dialogResult2 = MessageBox.Show("Czy wydawnictwo książki którą chcesz dodać jest już obecne na liście wydawnictw w bazie ?", "Pytanie", MessageBoxButtons.YesNo);
                if (dialogResult2 == DialogResult.Yes)
                {
                    DialogResult dialogResult3 = MessageBox.Show("Czy kategoria książki którą chcesz dodać jest już obecna na liście kategorii w bazie ?", "Pytanie", MessageBoxButtons.YesNo);
                    if (dialogResult3 == DialogResult.Yes)
                    {
                        this.Close();
                        th = new Thread(opennewform6);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                    else if (dialogResult3 == DialogResult.No)
                    {
                        this.Close();
                        th = new Thread(opennewform9);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                    }
                }
                else if (dialogResult2 == DialogResult.No)
                {
                    this.Close();
                    th = new Thread(opennewform8);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
                th = new Thread(opennewform19);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform7);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform8);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform9);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform10);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform11);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform12);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform13);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform14);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform15);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform16);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform17);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform18);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform20);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform21);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform22);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform19);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void button23_Click_1(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(opennewform23);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
    }
}
