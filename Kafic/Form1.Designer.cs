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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prijavi_se
            // 
            this.prijavi_se.Location = new System.Drawing.Point(339, 226);
            this.prijavi_se.Name = "prijavi_se";
            this.prijavi_se.Size = new System.Drawing.Size(75, 23);
            this.prijavi_se.TabIndex = 0;
            this.prijavi_se.Text = "Prijavi se";
            this.prijavi_se.UseVisualStyleBackColor = true;
            this.prijavi_se.Click += new System.EventHandler(this.prijavi_se_Click);
            // 
            // Ime
            // 
            this.Ime.Location = new System.Drawing.Point(327, 145);
            this.Ime.Name = "Ime";
            this.Ime.Size = new System.Drawing.Size(100, 20);
            this.Ime.TabIndex = 1;
            // 
            // Sifra
            // 
            this.Sifra.Location = new System.Drawing.Point(327, 182);
            this.Sifra.Name = "Sifra";
            this.Sifra.Size = new System.Drawing.Size(100, 20);
            this.Sifra.TabIndex = 2;
            // 
            // ugasi_program
            // 
            this.ugasi_program.Location = new System.Drawing.Point(618, 344);
            this.ugasi_program.Name = "ugasi_program";
            this.ugasi_program.Size = new System.Drawing.Size(93, 23);
            this.ugasi_program.TabIndex = 3;
            this.ugasi_program.Text = "Ugasi program";
            this.ugasi_program.UseVisualStyleBackColor = true;
            this.ugasi_program.Click += new System.EventHandler(this.ugasi_program_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ugasi_program);
            this.Controls.Add(this.Sifra);
            this.Controls.Add(this.Ime);
            this.Controls.Add(this.prijavi_se);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiha tisa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prijavi_se;
        private System.Windows.Forms.TextBox Ime;
        private System.Windows.Forms.TextBox Sifra;
        private System.Windows.Forms.Button ugasi_program;
        private System.Windows.Forms.Button button1;
    }
}

