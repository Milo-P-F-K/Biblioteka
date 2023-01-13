
namespace Biblioteka
{
    partial class viewAuthorsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewAuthorsForm));
            this.button1 = new System.Windows.Forms.Button();
            this.books = new System.Windows.Forms.DataGridView();
            this.identyfikatorAutoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imięINazwiskoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wyswietlautorowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataset1 = new Biblioteka.BibliotekaDataset();
            this.wyswietl_autorowTableAdapter = new Biblioteka.BibliotekaDatasetTableAdapters.Wyswietl_autorowTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyswietlautorowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset1)).BeginInit();
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
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.identyfikatorAutoraDataGridViewTextBoxColumn,
            this.imięINazwiskoDataGridViewTextBoxColumn});
            this.books.DataSource = this.wyswietlautorowBindingSource;
            this.books.EnableHeadersVisualStyles = false;
            this.books.Location = new System.Drawing.Point(6, 20);
            this.books.Name = "books";
            this.books.ReadOnly = true;
            this.books.RowHeadersVisible = false;
            this.books.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.books.Size = new System.Drawing.Size(291, 336);
            this.books.TabIndex = 25;
            // 
            // identyfikatorAutoraDataGridViewTextBoxColumn
            // 
            this.identyfikatorAutoraDataGridViewTextBoxColumn.DataPropertyName = "Identyfikator autora";
            this.identyfikatorAutoraDataGridViewTextBoxColumn.HeaderText = "Identyfikator autora";
            this.identyfikatorAutoraDataGridViewTextBoxColumn.Name = "identyfikatorAutoraDataGridViewTextBoxColumn";
            this.identyfikatorAutoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.identyfikatorAutoraDataGridViewTextBoxColumn.Width = 141;
            // 
            // imięINazwiskoDataGridViewTextBoxColumn
            // 
            this.imięINazwiskoDataGridViewTextBoxColumn.DataPropertyName = "Imię i nazwisko";
            this.imięINazwiskoDataGridViewTextBoxColumn.HeaderText = "Imię i nazwisko";
            this.imięINazwiskoDataGridViewTextBoxColumn.Name = "imięINazwiskoDataGridViewTextBoxColumn";
            this.imięINazwiskoDataGridViewTextBoxColumn.ReadOnly = true;
            this.imięINazwiskoDataGridViewTextBoxColumn.Width = 114;
            // 
            // wyswietlautorowBindingSource
            // 
            this.wyswietlautorowBindingSource.DataMember = "Wyswietl_autorow";
            this.wyswietlautorowBindingSource.DataSource = this.bibliotekaDataset1;
            // 
            // bibliotekaDataset1
            // 
            this.bibliotekaDataset1.DataSetName = "BibliotekaDataset";
            this.bibliotekaDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wyswietl_autorowTableAdapter
            // 
            this.wyswietl_autorowTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.books);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 363);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Autorów : ";
            // 
            // viewAuthorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(330, 428);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "viewAuthorsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Biblioteczny - Lista Autorów";
            this.Load += new System.EventHandler(this.View_Authors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyswietlautorowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView books;
        private BibliotekaDataset bibliotekaDataset1;
        private System.Windows.Forms.BindingSource wyswietlautorowBindingSource;
        private BibliotekaDatasetTableAdapters.Wyswietl_autorowTableAdapter wyswietl_autorowTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn identyfikatorAutoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imięINazwiskoDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}