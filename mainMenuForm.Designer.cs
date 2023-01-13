
namespace Biblioteka
{
    partial class mainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenuForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button20 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button23 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(-4, -2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 410);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Biblioteka.Properties.Resources.subMenuBG;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.button20);
            this.tabPage1.Controls.Add(this.button22);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button21);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button13);
            this.tabPage1.Controls.Add(this.button19);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(935, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Funkcje Książkowe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.BackgroundImage = global::Biblioteka.Properties.Resources.add_author_icon;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(264, 79);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(251, 67);
            this.button20.TabIndex = 21;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button22
            // 
            this.button22.BackgroundImage = global::Biblioteka.Properties.Resources.unassign_author_icon;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(264, 225);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(251, 67);
            this.button22.TabIndex = 21;
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button8
            // 
            this.button8.BackgroundImage = global::Biblioteka.Properties.Resources.add_publisher_icon;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(7, 298);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(251, 67);
            this.button8.TabIndex = 7;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Biblioteka.Properties.Resources.view_books_icon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(7, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 67);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Biblioteka.Properties.Resources.view_authors_icon;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(264, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 67);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button21
            // 
            this.button21.BackgroundImage = global::Biblioteka.Properties.Resources.remove_author_icon;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(264, 298);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(251, 67);
            this.button21.TabIndex = 20;
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button9.BackgroundImage")));
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(7, 225);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(251, 67);
            this.button9.TabIndex = 8;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Biblioteka.Properties.Resources.add_books_icon;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(7, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(251, 67);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button13
            // 
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(7, 152);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(251, 67);
            this.button13.TabIndex = 12;
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button19
            // 
            this.button19.BackgroundImage = global::Biblioteka.Properties.Resources.assign_author_icon1;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(264, 152);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(251, 67);
            this.button19.TabIndex = 18;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button18);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button17);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(935, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Funkcje Czytelnicze";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.BackgroundImage = global::Biblioteka.Properties.Resources.extend_lease_icon;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(7, 152);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(251, 67);
            this.button12.TabIndex = 11;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button16
            // 
            this.button16.BackgroundImage = global::Biblioteka.Properties.Resources.lend_book_icon;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(7, 79);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(251, 67);
            this.button16.TabIndex = 15;
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Biblioteka.Properties.Resources.view_readers_icon;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(7, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 67);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button18
            // 
            this.button18.BackgroundImage = global::Biblioteka.Properties.Resources.return_book_icon;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(7, 225);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(251, 67);
            this.button18.TabIndex = 17;
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button11
            // 
            this.button11.BackgroundImage = global::Biblioteka.Properties.Resources.register_reader_icon;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(264, 6);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(251, 67);
            this.button11.TabIndex = 10;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button17
            // 
            this.button17.BackgroundImage = global::Biblioteka.Properties.Resources.remove_reader_icon;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Location = new System.Drawing.Point(264, 79);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(251, 67);
            this.button17.TabIndex = 16;
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Biblioteka.Properties.Resources.view_leases_icon;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(7, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 67);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Biblioteka.Properties.Resources.OrganizationFunctionsMenuBG;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.button23);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.button15);
            this.tabPage3.Controls.Add(this.button14);
            this.tabPage3.Controls.Add(this.button10);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage3.ImageIndex = 2;
            this.tabPage3.Location = new System.Drawing.Point(4, 30);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(935, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Funkcje Organizacyjne";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.BackgroundImage = global::Biblioteka.Properties.Resources.switch_employee_job_icon;
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(7, 79);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(251, 67);
            this.button23.TabIndex = 15;
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button23_Click_1);
            // 
            // button7
            // 
            this.button7.BackgroundImage = global::Biblioteka.Properties.Resources.add_job_icon;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(7, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(251, 67);
            this.button7.TabIndex = 6;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button15
            // 
            this.button15.BackgroundImage = global::Biblioteka.Properties.Resources.remove_employee_icon;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(264, 6);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(251, 67);
            this.button15.TabIndex = 14;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackgroundImage = global::Biblioteka.Properties.Resources.remove_job_icon;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Location = new System.Drawing.Point(6, 152);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(251, 67);
            this.button14.TabIndex = 13;
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button10
            // 
            this.button10.BackgroundImage = global::Biblioteka.Properties.Resources.register_employee_icon;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(6, 298);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(251, 67);
            this.button10.TabIndex = 9;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::Biblioteka.Properties.Resources.view_employees_icon;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(6, 225);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(251, 67);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "BookFunctionsTabIcon.png");
            this.imageList1.Images.SetKeyName(1, "ReaderFunctionsTabIcon.png");
            this.imageList1.Images.SetKeyName(2, "OrganizationFunctionsTabIcon.png");
            // 
            // mainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 402);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Biblioteczny - Menu Główne";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button23;
    }
}