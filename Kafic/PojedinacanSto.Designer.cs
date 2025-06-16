namespace Kafic
{
    partial class PojedinacanSto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PojedinacanSto));
            this.nazad = new System.Windows.Forms.Button();
            this.naplati = new System.Windows.Forms.Button();
            this.ukupno = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.ListView();
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kolicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelPremestiNaSto = new System.Windows.Forms.Label();
            this.buttonPomeri = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nazad.BackColor = System.Drawing.Color.White;
            this.nazad.FlatAppearance.BorderSize = 0;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazad.Location = new System.Drawing.Point(1279, 733);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(75, 23);
            this.nazad.TabIndex = 0;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = false;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // naplati
            // 
            this.naplati.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.naplati.BackColor = System.Drawing.Color.White;
            this.naplati.FlatAppearance.BorderSize = 0;
            this.naplati.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.naplati.Location = new System.Drawing.Point(15, 733);
            this.naplati.Name = "naplati";
            this.naplati.Size = new System.Drawing.Size(75, 23);
            this.naplati.TabIndex = 2;
            this.naplati.Text = "Naplati";
            this.naplati.UseVisualStyleBackColor = false;
            this.naplati.Click += new System.EventHandler(this.naplati_Click);
            // 
            // ukupno
            // 
            this.ukupno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ukupno.AutoSize = true;
            this.ukupno.BackColor = System.Drawing.SystemColors.Control;
            this.ukupno.Location = new System.Drawing.Point(12, 682);
            this.ukupno.Name = "ukupno";
            this.ukupno.Size = new System.Drawing.Size(35, 13);
            this.ukupno.TabIndex = 6;
            this.ukupno.Text = "label1";
            // 
            // test
            // 
            this.test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.test.BackColor = System.Drawing.SystemColors.Window;
            this.test.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ime,
            this.Cena,
            this.Kolicina,
            this.columnHeader1});
            this.test.HideSelection = false;
            this.test.Location = new System.Drawing.Point(12, 12);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(400, 656);
            this.test.TabIndex = 7;
            this.test.UseCompatibleStateImageBehavior = false;
            this.test.View = System.Windows.Forms.View.Details;
            this.test.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Test_MouseDoubleClick);
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 214;
            // 
            // Cena
            // 
            this.Cena.Text = "Cena";
            this.Cena.Width = 68;
            // 
            // Kolicina
            // 
            this.Kolicina.Text = "Količina";
            this.Kolicina.Width = 49;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ukupno";
            this.columnHeader1.Width = 51;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.labelPremestiNaSto);
            this.panel1.Controls.Add(this.buttonPomeri);
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.naplati);
            this.panel1.Controls.Add(this.ukupno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 768);
            this.panel1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DisplayMember = "ime";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(283, 691);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "ime";
            // 
            // labelPremestiNaSto
            // 
            this.labelPremestiNaSto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPremestiNaSto.AutoSize = true;
            this.labelPremestiNaSto.BackColor = System.Drawing.Color.White;
            this.labelPremestiNaSto.Location = new System.Drawing.Point(195, 694);
            this.labelPremestiNaSto.Name = "labelPremestiNaSto";
            this.labelPremestiNaSto.Size = new System.Drawing.Size(82, 13);
            this.labelPremestiNaSto.TabIndex = 10;
            this.labelPremestiNaSto.Text = "Premesti na sto:";
            // 
            // buttonPomeri
            // 
            this.buttonPomeri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPomeri.BackColor = System.Drawing.Color.White;
            this.buttonPomeri.FlatAppearance.BorderSize = 0;
            this.buttonPomeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPomeri.Location = new System.Drawing.Point(312, 733);
            this.buttonPomeri.Name = "buttonPomeri";
            this.buttonPomeri.Size = new System.Drawing.Size(75, 23);
            this.buttonPomeri.TabIndex = 8;
            this.buttonPomeri.Text = "Premesti";
            this.buttonPomeri.UseVisualStyleBackColor = false;
            this.buttonPomeri.Click += new System.EventHandler(this.buttonPomeri_Click);
            // 
            // PojedinacanSto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Kafic.Properties.Resources.pojedinacni_sto;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nazad);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "PojedinacanSto";
            this.Text = "Sto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.Button naplati;
        private System.Windows.Forms.Label ukupno;
        private System.Windows.Forms.ListView test;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Cena;
        private System.Windows.Forms.ColumnHeader Kolicina;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonPomeri;
        private System.Windows.Forms.Label labelPremestiNaSto;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}