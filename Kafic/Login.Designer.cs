namespace Kafic
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.prijavi_se = new System.Windows.Forms.Button();
            this.Ime = new System.Windows.Forms.TextBox();
            this.Sifra = new System.Windows.Forms.TextBox();
            this.ugasi_program = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelKorisnickoIme = new System.Windows.Forms.Label();
            this.labelSifra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prijavi_se
            // 
            this.prijavi_se.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.prijavi_se.FlatAppearance.BorderSize = 0;
            this.prijavi_se.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prijavi_se.Location = new System.Drawing.Point(295, 314);
            this.prijavi_se.Name = "prijavi_se";
            this.prijavi_se.Size = new System.Drawing.Size(75, 23);
            this.prijavi_se.TabIndex = 2;
            this.prijavi_se.Text = "Prijavi se";
            this.prijavi_se.UseVisualStyleBackColor = true;
            this.prijavi_se.Click += new System.EventHandler(this.prijavi_se_Click);
            // 
            // Ime
            // 
            this.Ime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ime.Location = new System.Drawing.Point(281, 230);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(100, 20);
            this.Ime.TabIndex = 0;
            // 
            // Sifra
            // 
            this.Sifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Sifra.Location = new System.Drawing.Point(281, 271);
            this.Sifra.Name = "Sifra";
            this.Sifra.PasswordChar = '*';
            this.Sifra.Size = new System.Drawing.Size(100, 20);
            this.Sifra.TabIndex = 1;
            // 
            // ugasi_program
            // 
            this.ugasi_program.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ugasi_program.FlatAppearance.BorderSize = 0;
            this.ugasi_program.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ugasi_program.Location = new System.Drawing.Point(1151, 652);
            this.ugasi_program.Name = "ugasi_program";
            this.ugasi_program.Size = new System.Drawing.Size(93, 23);
            this.ugasi_program.TabIndex = 3;
            this.ugasi_program.Text = "Ugasi program";
            this.ugasi_program.UseVisualStyleBackColor = true;
            this.ugasi_program.Click += new System.EventHandler(this.ugasi_program_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 63);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login";
            // 
            // labelKorisnickoIme
            // 
            this.labelKorisnickoIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelKorisnickoIme.AutoSize = true;
            this.labelKorisnickoIme.BackColor = System.Drawing.Color.Transparent;
            this.labelKorisnickoIme.Location = new System.Drawing.Point(197, 233);
            this.labelKorisnickoIme.Name = "labelKorisnickoIme";
            this.labelKorisnickoIme.Size = new System.Drawing.Size(78, 13);
            this.labelKorisnickoIme.TabIndex = 5;
            this.labelKorisnickoIme.Text = "Korisnicko ime:";
            // 
            // labelSifra
            // 
            this.labelSifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSifra.AutoSize = true;
            this.labelSifra.BackColor = System.Drawing.Color.Transparent;
            this.labelSifra.Location = new System.Drawing.Point(244, 274);
            this.labelSifra.Name = "labelSifra";
            this.labelSifra.Size = new System.Drawing.Size(31, 13);
            this.labelSifra.TabIndex = 6;
            this.labelSifra.Text = "Sifra:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Kafic.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.labelSifra);
            this.Controls.Add(this.labelKorisnickoIme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ugasi_program);
            this.Controls.Add(this.Sifra);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.prijavi_se);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijavi_se;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.TextBox Sifra;
        private System.Windows.Forms.Button ugasi_program;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelKorisnickoIme;
        private System.Windows.Forms.Label labelSifra;
    }
}

