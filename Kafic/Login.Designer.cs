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
            this.prijavi_se = new System.Windows.Forms.Button();
            this.Ime = new System.Windows.Forms.TextBox();
            this.Sifra = new System.Windows.Forms.TextBox();
            this.ugasi_program = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prijavi_se
            // 
            this.prijavi_se.Location = new System.Drawing.Point(508, 348);
            this.prijavi_se.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prijavi_se.Name = "prijavi_se";
            this.prijavi_se.Size = new System.Drawing.Size(112, 35);
            this.prijavi_se.TabIndex = 0;
            this.prijavi_se.Text = "Prijavi se";
            this.prijavi_se.UseVisualStyleBackColor = true;
            this.prijavi_se.Click += new System.EventHandler(this.prijavi_se_Click);
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(490, 223);
            this.Ime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(148, 26);
            this.Ime.TabIndex = 1;
            // 
            // Sifra
            // 
            this.Sifra.Location = new System.Drawing.Point(490, 280);
            this.Sifra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sifra.Name = "Sifra";
            this.Sifra.Size = new System.Drawing.Size(148, 26);
            this.Sifra.TabIndex = 2;
            // 
            // ugasi_program
            // 
            this.ugasi_program.Location = new System.Drawing.Point(927, 529);
            this.ugasi_program.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ugasi_program.Name = "ugasi_program";
            this.ugasi_program.Size = new System.Drawing.Size(140, 35);
            this.ugasi_program.TabIndex = 3;
            this.ugasi_program.Text = "Ugasi program";
            this.ugasi_program.UseVisualStyleBackColor = true;
            this.ugasi_program.Click += new System.EventHandler(this.ugasi_program_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.ugasi_program);
            this.Controls.Add(this.Sifra);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.prijavi_se);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiha tisa";
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
    }
}

