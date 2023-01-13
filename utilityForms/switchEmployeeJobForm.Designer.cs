namespace Biblioteka.utilityForms
{
    partial class switchEmployeeJobForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(switchEmployeeJobForm));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listaPracownikowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataset = new Biblioteka.BibliotekaDataset();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lista_PracownikowTableAdapter = new Biblioteka.BibliotekaDatasetTableAdapters.Lista_PracownikowTableAdapter();
            this.roleTableAdapter = new Biblioteka.BibliotekaDatasetTableAdapters.RoleTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imieINazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stanowiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pracownicyistanowiskaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pracownicy_i_stanowiskaTableAdapter = new Biblioteka.BibliotekaDatasetTableAdapters.Pracownicy_i_stanowiskaTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaPracownikowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyistanowiskaBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteka.Properties.Resources.ReturnButton;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.listaPracownikowBindingSource;
            this.comboBox1.DisplayMember = "Imie i nazwisko";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 25);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "ID Pracownika";
            // 
            // listaPracownikowBindingSource
            // 
            this.listaPracownikowBindingSource.DataMember = "Lista_Pracownikow";
            this.listaPracownikowBindingSource.DataSource = this.bibliotekaDataset;
            // 
            // bibliotekaDataset
            // 
            this.bibliotekaDataset.DataSetName = "BibliotekaDataset";
            this.bibliotekaDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.roleBindingSource;
            this.comboBox2.DisplayMember = "nazwa";
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(106, 88);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 25);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.ValueMember = "id_rola";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataMember = "Role";
            this.roleBindingSource.DataSource = this.bibliotekaDataset;
            // 
            // lista_PracownikowTableAdapter
            // 
            this.lista_PracownikowTableAdapter.ClearBeforeFill = true;
            // 
            // roleTableAdapter
            // 
            this.roleTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pracownik : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stanowisko : ";
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
            this.imieINazwiskoDataGridViewTextBoxColumn,
            this.stanowiskoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pracownicyistanowiskaBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(8, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(251, 322);
            this.dataGridView1.TabIndex = 5;
            // 
            // imieINazwiskoDataGridViewTextBoxColumn
            // 
            this.imieINazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Imie i nazwisko";
            this.imieINazwiskoDataGridViewTextBoxColumn.HeaderText = "Imie i nazwisko";
            this.imieINazwiskoDataGridViewTextBoxColumn.Name = "imieINazwiskoDataGridViewTextBoxColumn";
            this.imieINazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            this.imieINazwiskoDataGridViewTextBoxColumn.Width = 124;
            // 
            // stanowiskoDataGridViewTextBoxColumn
            // 
            this.stanowiskoDataGridViewTextBoxColumn.DataPropertyName = "Stanowisko";
            this.stanowiskoDataGridViewTextBoxColumn.HeaderText = "Stanowisko";
            this.stanowiskoDataGridViewTextBoxColumn.Name = "stanowiskoDataGridViewTextBoxColumn";
            this.stanowiskoDataGridViewTextBoxColumn.ReadOnly = true;
            this.stanowiskoDataGridViewTextBoxColumn.Width = 101;
            // 
            // pracownicyistanowiskaBindingSource
            // 
            this.pracownicyistanowiskaBindingSource.DataMember = "Pracownicy_i_stanowiska";
            this.pracownicyistanowiskaBindingSource.DataSource = this.bibliotekaDataset;
            // 
            // pracownicy_i_stanowiskaTableAdapter
            // 
            this.pracownicy_i_stanowiskaTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(6, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 349);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista pracowników i ich stanowiska : ";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Biblioteka.Properties.Resources.switch_employee_job_icon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(15, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(253, 67);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // switchEmployeeJobForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(282, 548);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "switchEmployeeJobForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Biblioteczny - Panel Zmiany Stanowiska";
            this.Load += new System.EventHandler(this.switchEmployeeJobForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaPracownikowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pracownicyistanowiskaBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private BibliotekaDataset bibliotekaDataset;
        private System.Windows.Forms.BindingSource listaPracownikowBindingSource;
        private BibliotekaDatasetTableAdapters.Lista_PracownikowTableAdapter lista_PracownikowTableAdapter;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private BibliotekaDatasetTableAdapters.RoleTableAdapter roleTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pracownicyistanowiskaBindingSource;
        private BibliotekaDatasetTableAdapters.Pracownicy_i_stanowiskaTableAdapter pracownicy_i_stanowiskaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn imieINazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stanowiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
    }
}