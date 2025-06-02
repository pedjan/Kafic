namespace Kafic
{
    partial class Pocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pocetna));
            this.odjavi_se = new System.Windows.Forms.Button();
            this.uprproj = new System.Windows.Forms.Button();
            this.updateSto = new System.Windows.Forms.Button();
            this.napraviSto = new System.Windows.Forms.Button();
            this.obrisiSto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // odjavi_se
            // 
            this.odjavi_se.Location = new System.Drawing.Point(700, 21);
            this.odjavi_se.Name = "odjavi_se";
            this.odjavi_se.Size = new System.Drawing.Size(75, 23);
            this.odjavi_se.TabIndex = 0;
            this.odjavi_se.Text = "Odjavi se";
            this.odjavi_se.UseVisualStyleBackColor = true;
            this.odjavi_se.Click += new System.EventHandler(this.odjavi_se_Click);
            // 
            // uprproj
            // 
            this.uprproj.BackColor = System.Drawing.SystemColors.Control;
            this.uprproj.Location = new System.Drawing.Point(533, 21);
            this.uprproj.Name = "uprproj";
            this.uprproj.Size = new System.Drawing.Size(127, 23);
            this.uprproj.TabIndex = 5;
            this.uprproj.Text = "Upravljanje proizvodima";
            this.uprproj.UseVisualStyleBackColor = false;
            this.uprproj.Click += new System.EventHandler(this.uprproj_Click);
            // 
            // updateSto
            // 
            this.updateSto.Location = new System.Drawing.Point(412, 20);
            this.updateSto.Name = "updateSto";
            this.updateSto.Size = new System.Drawing.Size(91, 23);
            this.updateSto.TabIndex = 6;
            this.updateSto.Text = "Sacuvaj stolove";
            this.updateSto.UseVisualStyleBackColor = true;
            this.updateSto.Click += new System.EventHandler(this.updateSto_Click);
            // 
            // napraviSto
            // 
            this.napraviSto.Location = new System.Drawing.Point(302, 19);
            this.napraviSto.Name = "napraviSto";
            this.napraviSto.Size = new System.Drawing.Size(75, 23);
            this.napraviSto.TabIndex = 7;
            this.napraviSto.Text = "Napravi sto";
            this.napraviSto.UseVisualStyleBackColor = true;
            this.napraviSto.Click += new System.EventHandler(this.napraviSto_Click);
            // 
            // obrisiSto
            // 
            this.obrisiSto.Location = new System.Drawing.Point(201, 21);
            this.obrisiSto.Name = "obrisiSto";
            this.obrisiSto.Size = new System.Drawing.Size(75, 23);
            this.obrisiSto.TabIndex = 8;
            this.obrisiSto.Text = "Obrisi sto";
            this.obrisiSto.UseVisualStyleBackColor = true;
            this.obrisiSto.Click += new System.EventHandler(this.obrisiSto_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(811, 445);
            this.Controls.Add(this.obrisiSto);
            this.Controls.Add(this.napraviSto);
            this.Controls.Add(this.updateSto);
            this.Controls.Add(this.uprproj);
            this.Controls.Add(this.odjavi_se);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button odjavi_se;
        private System.Windows.Forms.Button uprproj;
        private System.Windows.Forms.Button updateSto;
        private System.Windows.Forms.Button napraviSto;
        private System.Windows.Forms.Button obrisiSto;
    }
}