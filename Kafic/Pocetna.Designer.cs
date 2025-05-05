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
            this.odjavi_se = new System.Windows.Forms.Button();
            this.sto1 = new System.Windows.Forms.Button();
            this.sto2 = new System.Windows.Forms.Button();
            this.sto3 = new System.Windows.Forms.Button();
            this.sto4 = new System.Windows.Forms.Button();
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
            // sto1
            // 
            this.sto1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sto1.Location = new System.Drawing.Point(114, 76);
            this.sto1.Name = "sto1";
            this.sto1.Size = new System.Drawing.Size(100, 100);
            this.sto1.TabIndex = 1;
            this.sto1.UseVisualStyleBackColor = false;
            this.sto1.Click += new System.EventHandler(this.sto_Click);
            // 
            // sto2
            // 
            this.sto2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sto2.Location = new System.Drawing.Point(264, 76);
            this.sto2.Name = "sto2";
            this.sto2.Size = new System.Drawing.Size(100, 100);
            this.sto2.TabIndex = 2;
            this.sto2.UseVisualStyleBackColor = false;
            this.sto2.Click += new System.EventHandler(this.sto_Click);
            // 
            // sto3
            // 
            this.sto3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sto3.Location = new System.Drawing.Point(422, 76);
            this.sto3.Name = "sto3";
            this.sto3.Size = new System.Drawing.Size(100, 100);
            this.sto3.TabIndex = 3;
            this.sto3.UseVisualStyleBackColor = false;
            this.sto3.Click += new System.EventHandler(this.sto_Click);
            // 
            // sto4
            // 
            this.sto4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sto4.Location = new System.Drawing.Point(585, 76);
            this.sto4.Name = "sto4";
            this.sto4.Size = new System.Drawing.Size(100, 100);
            this.sto4.TabIndex = 4;
            this.sto4.UseVisualStyleBackColor = false;
            this.sto4.Click += new System.EventHandler(this.sto_Click);
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 445);
            this.Controls.Add(this.sto4);
            this.Controls.Add(this.sto3);
            this.Controls.Add(this.sto2);
            this.Controls.Add(this.sto1);
            this.Controls.Add(this.odjavi_se);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button odjavi_se;
        private System.Windows.Forms.Button sto1;
        private System.Windows.Forms.Button sto2;
        private System.Windows.Forms.Button sto3;
        private System.Windows.Forms.Button sto4;
    }
}