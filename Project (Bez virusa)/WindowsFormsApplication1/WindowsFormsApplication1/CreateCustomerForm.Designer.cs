namespace WindowsFormsApplication1
{
    partial class CreateCustomerForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dodavanjeIAžuriranjeArtiklaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priakzIBrisanjeNarudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UpdateCustomerButton = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.CreateCustomerButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxFindFirstName = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxMobilePhone = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxFindLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxTown = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodavanjeIAžuriranjeArtiklaToolStripMenuItem,
            this.priakzIBrisanjeNarudžbeToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Meni";
            // 
            // dodavanjeIAžuriranjeArtiklaToolStripMenuItem
            // 
            this.dodavanjeIAžuriranjeArtiklaToolStripMenuItem.Name = "dodavanjeIAžuriranjeArtiklaToolStripMenuItem";
            this.dodavanjeIAžuriranjeArtiklaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.dodavanjeIAžuriranjeArtiklaToolStripMenuItem.Text = "Dodavanje i Ažuriranje artikla";
            this.dodavanjeIAžuriranjeArtiklaToolStripMenuItem.Click += new System.EventHandler(this.dodavanjeIAžuriranjeArtiklaToolStripMenuItem_Click);
            // 
            // priakzIBrisanjeNarudžbeToolStripMenuItem
            // 
            this.priakzIBrisanjeNarudžbeToolStripMenuItem.Name = "priakzIBrisanjeNarudžbeToolStripMenuItem";
            this.priakzIBrisanjeNarudžbeToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.priakzIBrisanjeNarudžbeToolStripMenuItem.Text = "Priakz i Brisanje narudžbe";
            this.priakzIBrisanjeNarudžbeToolStripMenuItem.Click += new System.EventHandler(this.priakzIBrisanjeNarudžbeToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label10.Location = new System.Drawing.Point(130, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Prezime:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label9.Location = new System.Drawing.Point(12, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Ime:";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(181, 429);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 28;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 192);
            this.dataGridView1.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label8.Location = new System.Drawing.Point(121, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "ID kupca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label6.Location = new System.Drawing.Point(203, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Korisničko ime:";
            // 
            // UpdateCustomerButton
            // 
            this.UpdateCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.UpdateCustomerButton.FlatAppearance.BorderSize = 0;
            this.UpdateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCustomerButton.ForeColor = System.Drawing.Color.Black;
            this.UpdateCustomerButton.Location = new System.Drawing.Point(287, 419);
            this.UpdateCustomerButton.Name = "UpdateCustomerButton";
            this.UpdateCustomerButton.Size = new System.Drawing.Size(127, 38);
            this.UpdateCustomerButton.TabIndex = 39;
            this.UpdateCustomerButton.Text = "Ažuriranje kupca";
            this.UpdateCustomerButton.UseVisualStyleBackColor = false;
            this.UpdateCustomerButton.Click += new System.EventHandler(this.UpdateCustomerButton_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(287, 336);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(127, 20);
            this.textBoxPassword.TabIndex = 29;
            // 
            // CreateCustomerButton
            // 
            this.CreateCustomerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.CreateCustomerButton.FlatAppearance.BorderSize = 0;
            this.CreateCustomerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateCustomerButton.ForeColor = System.Drawing.Color.Black;
            this.CreateCustomerButton.Location = new System.Drawing.Point(287, 374);
            this.CreateCustomerButton.Name = "CreateCustomerButton";
            this.CreateCustomerButton.Size = new System.Drawing.Size(127, 39);
            this.CreateCustomerButton.TabIndex = 38;
            this.CreateCustomerButton.Text = "Kreiranje kupca";
            this.CreateCustomerButton.UseVisualStyleBackColor = false;
            this.CreateCustomerButton.Click += new System.EventHandler(this.CreateCustomerButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label7.Location = new System.Drawing.Point(250, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Šifra:";
            // 
            // textBoxFindFirstName
            // 
            this.textBoxFindFirstName.Location = new System.Drawing.Point(12, 50);
            this.textBoxFindFirstName.Name = "textBoxFindFirstName";
            this.textBoxFindFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFindFirstName.TabIndex = 35;
            this.textBoxFindFirstName.TextChanged += new System.EventHandler(this.textBoxFindFirstName_TextChanged);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(287, 310);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(127, 20);
            this.textBoxUsername.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label5.Location = new System.Drawing.Point(235, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Telefon:";
            // 
            // textBoxMobilePhone
            // 
            this.textBoxMobilePhone.Location = new System.Drawing.Point(287, 284);
            this.textBoxMobilePhone.Name = "textBoxMobilePhone";
            this.textBoxMobilePhone.Size = new System.Drawing.Size(127, 20);
            this.textBoxMobilePhone.TabIndex = 31;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(77, 361);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdress.TabIndex = 34;
            // 
            // textBoxFindLastName
            // 
            this.textBoxFindLastName.Location = new System.Drawing.Point(133, 50);
            this.textBoxFindLastName.Name = "textBoxFindLastName";
            this.textBoxFindLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFindLastName.TabIndex = 36;
            this.textBoxFindLastName.TextChanged += new System.EventHandler(this.textBoxFindLastName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(16, 364);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Adresa:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(77, 284);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(26, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Grad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(32, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Ime:";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(77, 309);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 33;
            // 
            // textBoxTown
            // 
            this.textBoxTown.Location = new System.Drawing.Point(77, 335);
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(100, 20);
            this.textBoxTown.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Prezime:";
            // 
            // CreateCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(674, 466);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UpdateCustomerButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.CreateCustomerButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxFindFirstName);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMobilePhone);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxFindLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.textBoxTown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CreateCustomerForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateCustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CreateCustomerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dodavanjeIAžuriranjeArtiklaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priakzIBrisanjeNarudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button UpdateCustomerButton;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button CreateCustomerButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxFindFirstName;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxMobilePhone;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxFindLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxTown;
        private System.Windows.Forms.Label label2;
    }
}