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
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.odjavi_se);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button odjavi_se;
    }
}