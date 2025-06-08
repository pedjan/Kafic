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
            this.edit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nazad.BackColor = System.Drawing.Color.White;
            this.nazad.FlatAppearance.BorderSize = 0;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazad.Location = new System.Drawing.Point(1177, 646);
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
            this.naplati.Location = new System.Drawing.Point(15, 646);
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
            this.ukupno.Location = new System.Drawing.Point(12, 595);
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
            this.columnHeader1,
            this.edit});
            this.test.HideSelection = false;
            this.test.LabelEdit = true;
            this.test.Location = new System.Drawing.Point(12, 12);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(400, 569);
            this.test.TabIndex = 7;
            this.test.UseCompatibleStateImageBehavior = false;
            this.test.View = System.Windows.Forms.View.Details;
            this.test.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Test_MouseDoubleClick);
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 177;
            // 
            // Cena
            // 
            this.Cena.Text = "Cena";
            this.Cena.Width = 68;
            // 
            // Kolicina
            // 
            this.Kolicina.Text = "Kolicina";
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
            this.panel1.Controls.Add(this.test);
            this.panel1.Controls.Add(this.naplati);
            this.panel1.Controls.Add(this.ukupno);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 681);
            this.panel1.TabIndex = 8;
            // 
            // edit
            // 
            this.edit.Text = "Edit";
            // 
            // PojedinacanSto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nazad);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.ColumnHeader edit;
    }
}