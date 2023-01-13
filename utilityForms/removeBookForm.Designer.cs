
namespace Biblioteka
{
    partial class removeBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(removeBookForm));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ksiazkiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataset1 = new Biblioteka.BibliotekaDataset();
            this.button2 = new System.Windows.Forms.Button();
            this.ksiazkiTableAdapter1 = new Biblioteka.BibliotekaDatasetTableAdapters.KsiazkiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteka.Properties.Resources.ReturnButton;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ksiazkiBindingSource;
            this.comboBox1.DisplayMember = "tytul";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(215, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(218, 25);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "id_ksiazka";
            // 
            // ksiazkiBindingSource
            // 
            this.ksiazkiBindingSource.DataMember = "Ksiazki";
            this.ksiazkiBindingSource.DataSource = this.bibliotekaDataset1;
            // 
            // bibliotekaDataset1
            // 
            this.bibliotekaDataset1.DataSetName = "BibliotekaDataset";
            this.bibliotekaDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Biblioteka.Properties.Resources.remove_books_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(215, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(218, 63);
            this.button2.TabIndex = 17;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ksiazkiTableAdapter1
            // 
            this.ksiazkiTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Wybierz Książkę do Usunięcia : ";
            // 
            // removeBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(443, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "removeBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Biblioteczny - Panel Usuwania Książki";
            this.Load += new System.EventHandler(this.Remove_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ksiazkiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private BibliotekaDataset bibliotekaDataset1;
        private BibliotekaDatasetTableAdapters.KsiazkiTableAdapter ksiazkiTableAdapter;
        private System.Windows.Forms.BindingSource ksiazkiBindingSource;
        private BibliotekaDatasetTableAdapters.KsiazkiTableAdapter ksiazkiTableAdapter1;
        private System.Windows.Forms.Label label1;
    }
}