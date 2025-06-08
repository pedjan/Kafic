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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpravljanjeProizvodima));
            this.nabavka = new System.Windows.Forms.Button();
            this.stanje = new System.Windows.Forms.Button();
            this.izmeniKol = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.vrstaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Kafic.bazaDataSet();
            this.vrstaTableAdapter = new Kafic.bazaDataSetTableAdapters.vrstaTableAdapter();
            this.bazaDataSet1 = new Kafic.bazaDataSet1();
            this.proizvodiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proizvodiTableAdapter = new Kafic.bazaDataSet1TableAdapters.proizvodiTableAdapter();
            this.vrstaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.vrstaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nabavka
            // 
            this.nabavka.FlatAppearance.BorderSize = 0;
            this.nabavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nabavka.Location = new System.Drawing.Point(447, 307);
            this.nabavka.Name = "nabavka";
            this.nabavka.Size = new System.Drawing.Size(85, 23);
            this.nabavka.TabIndex = 0;
            this.nabavka.Text = "Nabavka";
            this.nabavka.UseVisualStyleBackColor = true;
            this.nabavka.Click += new System.EventHandler(this.nabavka_Click);
            // 
            // stanje
            // 
            this.stanje.FlatAppearance.BorderSize = 0;
            this.stanje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stanje.Location = new System.Drawing.Point(750, 307);
            this.stanje.Name = "stanje";
            this.stanje.Size = new System.Drawing.Size(85, 23);
            this.stanje.TabIndex = 1;
            this.stanje.Text = "Stanje";
            this.stanje.UseVisualStyleBackColor = true;
            // 
            // izmeniKol
            // 
            this.izmeniKol.FlatAppearance.BorderSize = 0;
            this.izmeniKol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izmeniKol.Location = new System.Drawing.Point(600, 307);
            this.izmeniKol.Name = "izmeniKol";
            this.izmeniKol.Size = new System.Drawing.Size(85, 23);
            this.izmeniKol.TabIndex = 2;
            this.izmeniKol.Text = "Izmeni kolicinu";
            this.izmeniKol.UseVisualStyleBackColor = true;
            // 
            // nazad
            // 
            this.nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nazad.FlatAppearance.BorderSize = 0;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazad.Location = new System.Drawing.Point(1161, 626);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(75, 23);
            this.nazad.TabIndex = 3;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // vrstaBindingSource1
            // 
            this.vrstaBindingSource1.DataMember = "vrsta";
            this.vrstaBindingSource1.DataSource = this.bazaDataSet;
            // 
            // bazaDataSet
            // 
            this.bazaDataSet.DataSetName = "bazaDataSet";
            this.bazaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vrstaTableAdapter
            // 
            this.vrstaTableAdapter.ClearBeforeFill = true;
            // 
            // bazaDataSet1
            // 
            this.bazaDataSet1.DataSetName = "bazaDataSet1";
            this.bazaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proizvodiBindingSource
            // 
            this.proizvodiBindingSource.DataMember = "proizvodi";
            this.proizvodiBindingSource.DataSource = this.bazaDataSet1;
            // 
            // proizvodiTableAdapter
            // 
            this.proizvodiTableAdapter.ClearBeforeFill = true;
            // 
            // vrstaBindingSource
            // 
            this.vrstaBindingSource.DataSource = typeof(Kafic.Vrsta);
            // 
            // UpravljanjeProizvodima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.izmeniKol);
            this.Controls.Add(this.stanje);
            this.Controls.Add(this.nabavka);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpravljanjeProizvodima";
            this.Text = "UpravljanjeProizvodima";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.vrstaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nabavka;
        private System.Windows.Forms.Button stanje;
        private System.Windows.Forms.Button izmeniKol;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.BindingSource vrstaBindingSource;
        private bazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource vrstaBindingSource1;
        private bazaDataSetTableAdapters.vrstaTableAdapter vrstaTableAdapter;
        private bazaDataSet1 bazaDataSet1;
        private System.Windows.Forms.BindingSource proizvodiBindingSource;
        private bazaDataSet1TableAdapters.proizvodiTableAdapter proizvodiTableAdapter;
    }
}