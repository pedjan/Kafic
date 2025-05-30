namespace Kafic
{
    partial class UpravljanjeProizvodima
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
            this.nabavka = new System.Windows.Forms.Button();
            this.stanje = new System.Windows.Forms.Button();
            this.izmeniKol = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nabavka
            // 
            this.nabavka.Location = new System.Drawing.Point(162, 101);
            this.nabavka.Name = "nabavka";
            this.nabavka.Size = new System.Drawing.Size(85, 23);
            this.nabavka.TabIndex = 0;
            this.nabavka.Text = "Nabavka";
            this.nabavka.UseVisualStyleBackColor = true;
            // 
            // stanje
            // 
            this.stanje.Location = new System.Drawing.Point(479, 101);
            this.stanje.Name = "stanje";
            this.stanje.Size = new System.Drawing.Size(85, 23);
            this.stanje.TabIndex = 1;
            this.stanje.Text = "Stanje";
            this.stanje.UseVisualStyleBackColor = true;
            // 
            // izmeniKol
            // 
            this.izmeniKol.Location = new System.Drawing.Point(321, 101);
            this.izmeniKol.Name = "izmeniKol";
            this.izmeniKol.Size = new System.Drawing.Size(85, 23);
            this.izmeniKol.TabIndex = 2;
            this.izmeniKol.Text = "Izmeni kolicinu";
            this.izmeniKol.UseVisualStyleBackColor = true;
            // 
            // nazad
            // 
            this.nazad.Location = new System.Drawing.Point(664, 239);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(75, 23);
            this.nazad.TabIndex = 3;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // UpravljanjeProizvodima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.izmeniKol);
            this.Controls.Add(this.stanje);
            this.Controls.Add(this.nabavka);
            this.Name = "UpravljanjeProizvodima";
            this.Text = "UpravljanjeProizvodima";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nabavka;
        private System.Windows.Forms.Button stanje;
        private System.Windows.Forms.Button izmeniKol;
        private System.Windows.Forms.Button nazad;
    }
}