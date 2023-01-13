
namespace Biblioteka
{
    partial class borrowBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(borrowBookForm));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.wyswietlczytelnikowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataset1 = new Biblioteka.BibliotekaDataset();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ksiazkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.listaPracownikowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.books = new System.Windows.Forms.DataGridView();
            this.wyswietl_czytelnikowTableAdapter2 = new Biblioteka.BibliotekaDatasetTableAdapters.Wyswietl_czytelnikowTableAdapter();
            this.ksiazkiTableAdapter2 = new Biblioteka.BibliotekaDatasetTableAdapters.KsiazkiTableAdapter();
            this.lista_PracownikowTableAdapter2 = new Biblioteka.BibliotekaDatasetTableAdapters.Lista_PracownikowTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listawypozyczenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_wypozyczenTableAdapter2 = new Biblioteka.BibliotekaDatasetTableAdapters.Lista_wypozyczenTableAdapter();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownikKsięgującyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.wyswietlczytelnikowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPracownikowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.books)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listawypozyczenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteka.Properties.Resources.ReturnButton;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.wyswietlczytelnikowBindingSource;
            this.comboBox1.DisplayMember = "Imię i nazwisko";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(245, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 25);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.ValueMember = "Identyfikator czytelnika";
            // 
            // wyswietlczytelnikowBindingSource
            // 
            this.wyswietlczytelnikowBindingSource.DataMember = "Wyswietl_czytelnikow";
            this.wyswietlczytelnikowBindingSource.DataSource = this.bibliotekaDataset1;
            // 
            // bibliotekaDataset1
            // 
            this.bibliotekaDataset1.DataSetName = "BibliotekaDataset";
            this.bibliotekaDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.ksiazkiBindingSource;
            this.comboBox2.DisplayMember = "tytul";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(245, 87);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(232, 25);
            this.comboBox2.TabIndex = 14;
            this.comboBox2.ValueMember = "id_ksiazka";
            // 
            // ksiazkiBindingSource
            // 
            this.ksiazkiBindingSource.DataMember = "Ksiazki";
            this.ksiazkiBindingSource.DataSource = this.bibliotekaDataset1;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.listaPracownikowBindingSource;
            this.comboBox3.DisplayMember = "Imie i nazwisko";
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(245, 114);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(232, 25);
            this.comboBox3.TabIndex = 15;
            this.comboBox3.ValueMember = "ID Pracownika";
            // 
            // listaPracownikowBindingSource
            // 
            this.listaPracownikowBindingSource.DataMember = "Lista_Pracownikow";
            this.listaPracownikowBindingSource.DataSource = this.bibliotekaDataset1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Czytelnik : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Książka : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Pracownik księgujący wypożyczenie: ";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Biblioteka.Properties.Resources.lend_book_icon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(245, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 67);
            this.button2.TabIndex = 19;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // books
            // 
            this.books.AllowUserToAddRows = false;
            this.books.AllowUserToDeleteRows = false;
            this.books.AllowUserToResizeColumns = false;
            this.books.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            this.books.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.books.AutoGenerateColumns = false;
            this.books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.books.BackgroundColor = System.Drawing.Color.White;
            this.books.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.books.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.books.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.books.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewCheckBoxColumn2,
            this.dataGridViewTextBoxColumn14,
            this.pracownikKsięgującyDataGridViewTextBoxColumn});
            this.books.DataSource = this.listawypozyczenBindingSource;
            this.books.EnableHeadersVisualStyles = false;
            this.books.Location = new System.Drawing.Point(6, 19);
            this.books.Name = "books";
            this.books.ReadOnly = true;
            this.books.RowHeadersVisible = false;
            this.books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.books.Size = new System.Drawing.Size(1180, 548);
            this.books.TabIndex = 24;
            // 
            // wyswietl_czytelnikowTableAdapter2
            // 
            this.wyswietl_czytelnikowTableAdapter2.ClearBeforeFill = true;
            // 
            // ksiazkiTableAdapter2
            // 
            this.ksiazkiTableAdapter2.ClearBeforeFill = true;
            // 
            // lista_PracownikowTableAdapter2
            // 
            this.lista_PracownikowTableAdapter2.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.books);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1194, 482);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Wypożyczeń : ";
            // 
            // listawypozyczenBindingSource
            // 
            this.listawypozyczenBindingSource.DataMember = "Lista_wypozyczen";
            this.listawypozyczenBindingSource.DataSource = this.bibliotekaDataset1;
            // 
            // lista_wypozyczenTableAdapter2
            // 
            this.lista_wypozyczenTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Imie i nazwisko";
            this.dataGridViewTextBoxColumn8.HeaderText = "Imie i nazwisko";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 124;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Identyfikator czytelnika";
            this.dataGridViewTextBoxColumn9.HeaderText = "Identyfikator czytelnika";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 158;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Tytuł książki";
            this.dataGridViewTextBoxColumn10.HeaderText = "Tytuł książki";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 96;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Identyfikator książki";
            this.dataGridViewTextBoxColumn11.HeaderText = "Identyfikator książki";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 140;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Data wypożyczenia";
            this.dataGridViewTextBoxColumn12.HeaderText = "Data wypożyczenia";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 134;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Data zwrotu";
            this.dataGridViewTextBoxColumn13.HeaderText = "Data zwrotu";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 97;
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Status zwrotu";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Status zwrotu";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            this.dataGridViewCheckBoxColumn2.ReadOnly = true;
            this.dataGridViewCheckBoxColumn2.Width = 87;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Termin oddania";
            this.dataGridViewTextBoxColumn14.HeaderText = "Termin oddania";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 115;
            // 
            // pracownikKsięgującyDataGridViewTextBoxColumn
            // 
            this.pracownikKsięgującyDataGridViewTextBoxColumn.DataPropertyName = "Pracownik księgujący";
            this.pracownikKsięgującyDataGridViewTextBoxColumn.HeaderText = "Pracownik księgujący";
            this.pracownikKsięgującyDataGridViewTextBoxColumn.Name = "pracownikKsięgującyDataGridViewTextBoxColumn";
            this.pracownikKsięgującyDataGridViewTextBoxColumn.ReadOnly = true;
            this.pracownikKsięgującyDataGridViewTextBoxColumn.Width = 146;
            // 
            // borrowBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1214, 707);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "borrowBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Biblioteczny - Panel Wypożyczania Książki";
            this.Load += new System.EventHandler(this.Lease_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wyswietlczytelnikowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPracownikowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.books)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listawypozyczenBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView books;
        private BibliotekaDataset bibliotekaDataset1;
        private BibliotekaDatasetTableAdapters.Lista_wypozyczenTableAdapter lista_wypozyczenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieINazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorCzytelnikaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytułKsiążkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorKsiążkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataWypożyczeniaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataZwrotuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusZwrotuDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn terminOddaniaDataGridViewTextBoxColumn;
        private BibliotekaDatasetTableAdapters.Wyswietl_czytelnikowTableAdapter wyswietl_czytelnikowTableAdapter;
        private BibliotekaDatasetTableAdapters.KsiazkiTableAdapter ksiazkiTableAdapter;
        private BibliotekaDatasetTableAdapters.Lista_PracownikowTableAdapter lista_PracownikowTableAdapter;
        private BibliotekaDatasetTableAdapters.Wyswietl_czytelnikowTableAdapter wyswietl_czytelnikowTableAdapter1;
        private BibliotekaDatasetTableAdapters.KsiazkiTableAdapter ksiazkiTableAdapter1;
        private BibliotekaDatasetTableAdapters.Lista_PracownikowTableAdapter lista_PracownikowTableAdapter1;
        private BibliotekaDatasetTableAdapters.Lista_wypozyczenTableAdapter lista_wypozyczenTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource wyswietlczytelnikowBindingSource;
        private BibliotekaDatasetTableAdapters.Wyswietl_czytelnikowTableAdapter wyswietl_czytelnikowTableAdapter2;
        private System.Windows.Forms.BindingSource ksiazkiBindingSource;
        private BibliotekaDatasetTableAdapters.KsiazkiTableAdapter ksiazkiTableAdapter2;
        private System.Windows.Forms.BindingSource listaPracownikowBindingSource;
        private BibliotekaDatasetTableAdapters.Lista_PracownikowTableAdapter lista_PracownikowTableAdapter2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource listawypozyczenBindingSource;
        private BibliotekaDatasetTableAdapters.Lista_wypozyczenTableAdapter lista_wypozyczenTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn pracownikKsięgującyDataGridViewTextBoxColumn;
    }
}