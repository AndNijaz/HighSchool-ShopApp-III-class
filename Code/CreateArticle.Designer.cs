﻿namespace Projektni_zadatak
{
    partial class CreateArticle
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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxArticleType = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArticleLabel = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUpdateArticle = new System.Windows.Forms.Button();
            this.buttonAddArticle = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazIBrisanjeNarudžbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(580, 325);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(57, 20);
            this.numericUpDown1.TabIndex = 23;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 192);
            this.dataGridView1.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label6.Location = new System.Drawing.Point(481, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dodaj količinu:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(103, 365);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(100, 20);
            this.textBoxAmount.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(11, 49);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(95, 20);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(127, 49);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(112, 20);
            this.textBoxLabel.TabIndex = 8;
            this.textBoxLabel.TextChanged += new System.EventHandler(this.textBoxLabel_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label4.Location = new System.Drawing.Point(47, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Količina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label5.Location = new System.Drawing.Point(506, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "ID artikla:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label3.Location = new System.Drawing.Point(55, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Cijena:";
            // 
            // textBoxArticleType
            // 
            this.textBoxArticleType.Location = new System.Drawing.Point(103, 316);
            this.textBoxArticleType.Name = "textBoxArticleType";
            this.textBoxArticleType.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticleType.TabIndex = 5;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(580, 296);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(57, 20);
            this.textBoxID.TabIndex = 4;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label1.Location = new System.Drawing.Point(26, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Naziv artikla:";
            // 
            // textBoxArticleLabel
            // 
            this.textBoxArticleLabel.Location = new System.Drawing.Point(103, 292);
            this.textBoxArticleLabel.Name = "textBoxArticleLabel";
            this.textBoxArticleLabel.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticleLabel.TabIndex = 2;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(103, 342);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrice.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label2.Location = new System.Drawing.Point(32, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vrsta artikla:";
            // 
            // buttonUpdateArticle
            // 
            this.buttonUpdateArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.buttonUpdateArticle.FlatAppearance.BorderSize = 0;
            this.buttonUpdateArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateArticle.ForeColor = System.Drawing.Color.Black;
            this.buttonUpdateArticle.Location = new System.Drawing.Point(397, 418);
            this.buttonUpdateArticle.Name = "buttonUpdateArticle";
            this.buttonUpdateArticle.Size = new System.Drawing.Size(138, 35);
            this.buttonUpdateArticle.TabIndex = 12;
            this.buttonUpdateArticle.Text = "Ažurairanje podataka";
            this.buttonUpdateArticle.UseVisualStyleBackColor = false;
            this.buttonUpdateArticle.Click += new System.EventHandler(this.buttonUpdateArticle_Click);
            // 
            // buttonAddArticle
            // 
            this.buttonAddArticle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(206)))), ((int)(((byte)(239)))));
            this.buttonAddArticle.FlatAppearance.BorderSize = 0;
            this.buttonAddArticle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddArticle.ForeColor = System.Drawing.Color.Black;
            this.buttonAddArticle.Location = new System.Drawing.Point(127, 418);
            this.buttonAddArticle.Name = "buttonAddArticle";
            this.buttonAddArticle.Size = new System.Drawing.Size(134, 35);
            this.buttonAddArticle.TabIndex = 11;
            this.buttonAddArticle.Text = "Dodavanje artikla";
            this.buttonAddArticle.UseVisualStyleBackColor = false;
            this.buttonAddArticle.Click += new System.EventHandler(this.buttonAddArticle_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(664, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem,
            this.prikazIBrisanjeNarudžbeToolStripMenuItem,
            this.odjavaToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Meni";
            // 
            // kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem
            // 
            this.kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem.Name = "kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem";
            this.kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem.Text = "Kreiranje i Ažuriranje novog kupca";
            this.kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem.Click += new System.EventHandler(this.kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem_Click);
            // 
            // prikazIBrisanjeNarudžbeToolStripMenuItem
            // 
            this.prikazIBrisanjeNarudžbeToolStripMenuItem.Name = "prikazIBrisanjeNarudžbeToolStripMenuItem";
            this.prikazIBrisanjeNarudžbeToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.prikazIBrisanjeNarudžbeToolStripMenuItem.Text = "Prikaz i Brisanje narudžbe";
            this.prikazIBrisanjeNarudžbeToolStripMenuItem.Click += new System.EventHandler(this.prikazIBrisanjeNarudžbeToolStripMenuItem_Click);
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label9.Location = new System.Drawing.Point(11, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "ID Artikla:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(84)))), ((int)(((byte)(116)))));
            this.label7.Location = new System.Drawing.Point(124, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Naziv artikla:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 465);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonUpdateArticle);
            this.Controls.Add(this.buttonAddArticle);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLabel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxArticleType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxArticleLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CreateArticle";
            this.Text = "Dodavanje / Ažuriranje artikala";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateArticle_FormClosed);
            this.Load += new System.EventHandler(this.CreateArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxArticleType;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArticleLabel;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUpdateArticle;
        private System.Windows.Forms.Button buttonAddArticle;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem kreiranjeIAžuriranjeNovogKupcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazIBrisanjeNarudžbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}