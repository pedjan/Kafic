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
            this.nazad = new System.Windows.Forms.Button();
            this.naplati = new System.Windows.Forms.Button();
            this.ukupno = new System.Windows.Forms.Label();
            this.test = new System.Windows.Forms.ListView();
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kolicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(713, 415);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(75, 23);
            this.nazad.TabIndex = 0;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // naplati
            // 
            this.naplati.Location = new System.Drawing.Point(12, 345);
            this.naplati.Name = "naplati";
            this.naplati.Size = new System.Drawing.Size(75, 23);
            this.naplati.TabIndex = 2;
            this.naplati.Text = "Naplati";
            this.naplati.UseVisualStyleBackColor = true;
            this.naplati.Click += new System.EventHandler(this.naplati_Click);
            // 
            // ukupno
            // 
            this.ukupno.AutoSize = true;
            this.ukupno.Location = new System.Drawing.Point(12, 308);
            this.ukupno.Name = "ukupno";
            this.ukupno.Size = new System.Drawing.Size(35, 13);
            this.ukupno.TabIndex = 6;
            this.ukupno.Text = "label1";
            // 
            // test
            // 
            this.test.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ime,
            this.Cena,
            this.Kolicina,
            this.columnHeader1});
            this.test.HideSelection = false;
            this.test.Location = new System.Drawing.Point(12, 12);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(400, 282);
            this.test.TabIndex = 7;
            this.test.UseCompatibleStateImageBehavior = false;
            this.test.View = System.Windows.Forms.View.Details;
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 103;
            // 
            // Cena
            // 
            this.Cena.Text = "Cena";
            this.Cena.Width = 116;
            // 
            // Kolicina
            // 
            this.Kolicina.Text = "Kolicina";
            this.Kolicina.Width = 92;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ukupno";
            // 
            // PojedinacanSto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.test);
            this.Controls.Add(this.ukupno);
            this.Controls.Add(this.naplati);
            this.Controls.Add(this.nazad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PojedinacanSto";
            this.Text = "Sto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}