
namespace Biblioteka
{
    partial class deregisterReaderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deregisterReaderForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.wyswietlczytelnikowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bibliotekaDataset1 = new Biblioteka.BibliotekaDataset();
            this.label1 = new System.Windows.Forms.Label();
            this.wyswietl_czytelnikowTableAdapter1 = new Biblioteka.BibliotekaDatasetTableAdapters.Wyswietl_czytelnikowTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.wyswietlczytelnikowBindingSource)).BeginInit();
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
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Biblioteka.Properties.Resources.remove_reader_icon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(91, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 63);
            this.button2.TabIndex = 21;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.wyswietlczytelnikowBindingSource;
            this.comboBox1.DisplayMember = "Imię i nazwisko";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 25);
            this.comboBox1.TabIndex = 20;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Czytelnik : ";
            // 
            // wyswietl_czytelnikowTableAdapter1
            // 
            this.wyswietl_czytelnikowTableAdapter1.ClearBeforeFill = true;
            // 
            // deregisterReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(345, 164);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deregisterReaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Biblioteczny - Panel Usuwania Czytelnika";
            this.Load += new System.EventHandler(this.Deregister_Reader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wyswietlczytelnikowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bibliotekaDataset1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private BibliotekaDataset bibliotekaDataset1;
        private BibliotekaDatasetTableAdapters.Wyswietl_czytelnikowTableAdapter wyswietl_czytelnikowTableAdapter;
        private System.Windows.Forms.BindingSource wyswietlczytelnikowBindingSource;
        private BibliotekaDatasetTableAdapters.Wyswietl_czytelnikowTableAdapter wyswietl_czytelnikowTableAdapter1;
    }
}