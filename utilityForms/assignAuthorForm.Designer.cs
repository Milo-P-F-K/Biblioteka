
namespace Biblioteka
{
    partial class assignAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(assignAuthorForm));
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tytułKsiążkiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorstwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaKsiazekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataset1 = new Biblioteka.BibliotekaDataset();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.wyswietlautorowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lista_KsiazekTableAdapter = new Biblioteka.BibliotekaDatasetTableAdapters.Lista_KsiazekTableAdapter();
            this.wyswietl_autorowTableAdapter = new Biblioteka.BibliotekaDatasetTableAdapters.Wyswietl_autorowTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaKsiazekBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyswietlautorowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteka.Properties.Resources.ReturnButton;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(328, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 237);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista książek i ich autorzy : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tytułKsiążkiDataGridViewTextBoxColumn,
            this.autorstwaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listaKsiazekBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(578, 205);
            this.dataGridView1.TabIndex = 21;
            // 
            // tytułKsiążkiDataGridViewTextBoxColumn
            // 
            this.tytułKsiążkiDataGridViewTextBoxColumn.DataPropertyName = "Tytuł książki";
            this.tytułKsiążkiDataGridViewTextBoxColumn.HeaderText = "Tytuł książki";
            this.tytułKsiążkiDataGridViewTextBoxColumn.Name = "tytułKsiążkiDataGridViewTextBoxColumn";
            this.tytułKsiążkiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tytułKsiążkiDataGridViewTextBoxColumn.Width = 105;
            // 
            // autorstwaDataGridViewTextBoxColumn
            // 
            this.autorstwaDataGridViewTextBoxColumn.DataPropertyName = "Autorstwa";
            this.autorstwaDataGridViewTextBoxColumn.HeaderText = "Autorstwa";
            this.autorstwaDataGridViewTextBoxColumn.Name = "autorstwaDataGridViewTextBoxColumn";
            this.autorstwaDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorstwaDataGridViewTextBoxColumn.Width = 95;
            // 
            // listaKsiazekBindingSource
            // 
            this.listaKsiazekBindingSource.DataMember = "Lista_Ksiazek";
            this.listaKsiazekBindingSource.DataSource = this.bibliotekaDataset1;
            // 
            // bibliotekaDataset1
            // 
            this.bibliotekaDataset1.DataSetName = "BibliotekaDataset";
            this.bibliotekaDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.wyswietlautorowBindingSource;
            this.comboBox1.DisplayMember = "Imię i nazwisko";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 99);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 25);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.ValueMember = "Identyfikator autora";
            // 
            // wyswietlautorowBindingSource
            // 
            this.wyswietlautorowBindingSource.DataMember = "Wyswietl_autorow";
            this.wyswietlautorowBindingSource.DataSource = this.bibliotekaDataset1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Autor : ";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Biblioteka.Properties.Resources.assign_author_icon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(81, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 68);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.listaKsiazekBindingSource;
            this.comboBox2.DisplayMember = "Tytuł książki";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(81, 138);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(241, 25);
            this.comboBox2.TabIndex = 29;
            this.comboBox2.ValueMember = "Identyfikator książki";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Książka : ";
            // 
            // lista_KsiazekTableAdapter
            // 
            this.lista_KsiazekTableAdapter.ClearBeforeFill = true;
            // 
            // wyswietl_autorowTableAdapter
            // 
            this.wyswietl_autorowTableAdapter.ClearBeforeFill = true;
            // 
            // assignAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(934, 310);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "assignAuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Biblioteczny - Panel Dopisywania Autora";
            this.Load += new System.EventHandler(this.Assign_Author_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaKsiazekBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyswietlautorowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private BibliotekaDataset bibliotekaDataset1;
        private System.Windows.Forms.BindingSource listaKsiazekBindingSource;
        private BibliotekaDatasetTableAdapters.Lista_KsiazekTableAdapter lista_KsiazekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tytułKsiążkiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorstwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource wyswietlautorowBindingSource;
        private BibliotekaDatasetTableAdapters.Wyswietl_autorowTableAdapter wyswietl_autorowTableAdapter;
    }
}