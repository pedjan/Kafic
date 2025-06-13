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
            this.nabavka = new System.Windows.Forms.Button();
            this.stanje = new System.Windows.Forms.Button();
            this.izmeniKol = new System.Windows.Forms.Button();
            this.nazad = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vrstaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bazaDataSet = new Kafic.bazaDataSet();
            this.vrstaTableAdapter = new Kafic.bazaDataSetTableAdapters.vrstaTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.naslov = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.naslovRadnje = new System.Windows.Forms.Label();
            this.labelVrsta = new System.Windows.Forms.Label();
            this.labelPrizvod = new System.Windows.Forms.Label();
            this.labelKolicina = new System.Windows.Forms.Label();
            this.proizvodiTB = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pazar = new System.Windows.Forms.Button();
            this.labelDatum = new System.Windows.Forms.Label();
            this.labelTrenutnaKolicina = new System.Windows.Forms.Label();
            this.buttonStanjeKasa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vrstaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
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
            this.stanje.Click += new System.EventHandler(this.stanje_Click);
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
            this.izmeniKol.Click += new System.EventHandler(this.izmeniKol_Click);
            // 
            // nazad
            // 
            this.nazad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nazad.FlatAppearance.BorderSize = 0;
            this.nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nazad.Location = new System.Drawing.Point(1263, 713);
            this.nazad.Name = "nazad";
            this.nazad.Size = new System.Drawing.Size(75, 23);
            this.nazad.TabIndex = 3;
            this.nazad.Text = "Nazad";
            this.nazad.UseVisualStyleBackColor = true;
            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.vrstaBindingSource;
            this.comboBox1.DisplayMember = "ime";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 234);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "idV";
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.izabranaVrsta);
            // 
            // vrstaBindingSource
            // 
            this.vrstaBindingSource.DataMember = "vrsta";
            this.vrstaBindingSource.DataSource = this.bazaDataSet;
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
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(152, 298);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 5;
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.izabanProizvod);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.naslov);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 100);
            this.panel1.TabIndex = 6;
            // 
            // naslov
            // 
            this.naslov.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.naslov.AutoSize = true;
            this.naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslov.ForeColor = System.Drawing.Color.White;
            this.naslov.Location = new System.Drawing.Point(504, 30);
            this.naslov.Name = "naslov";
            this.naslov.Size = new System.Drawing.Size(382, 39);
            this.naslov.TabIndex = 0;
            this.naslov.Text = "Upravljanje proizvodima";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.FlatAppearance.BorderSize = 0;
            this.buttonDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDodaj.Location = new System.Drawing.Point(170, 430);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 8;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Visible = false;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(152, 365);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Visible = false;
            // 
            // naslovRadnje
            // 
            this.naslovRadnje.AutoSize = true;
            this.naslovRadnje.BackColor = System.Drawing.Color.Transparent;
            this.naslovRadnje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.naslovRadnje.ForeColor = System.Drawing.Color.White;
            this.naslovRadnje.Location = new System.Drawing.Point(110, 129);
            this.naslovRadnje.Name = "naslovRadnje";
            this.naslovRadnje.Size = new System.Drawing.Size(86, 31);
            this.naslovRadnje.TabIndex = 10;
            this.naslovRadnje.Text = "label1";
            this.naslovRadnje.Visible = false;
            // 
            // labelVrsta
            // 
            this.labelVrsta.AutoSize = true;
            this.labelVrsta.BackColor = System.Drawing.Color.Transparent;
            this.labelVrsta.ForeColor = System.Drawing.Color.White;
            this.labelVrsta.Location = new System.Drawing.Point(66, 237);
            this.labelVrsta.Name = "labelVrsta";
            this.labelVrsta.Size = new System.Drawing.Size(67, 13);
            this.labelVrsta.TabIndex = 11;
            this.labelVrsta.Text = "Izaberi vrstu:";
            this.labelVrsta.Visible = false;
            // 
            // labelPrizvod
            // 
            this.labelPrizvod.AutoSize = true;
            this.labelPrizvod.BackColor = System.Drawing.Color.Transparent;
            this.labelPrizvod.ForeColor = System.Drawing.Color.White;
            this.labelPrizvod.Location = new System.Drawing.Point(55, 301);
            this.labelPrizvod.Name = "labelPrizvod";
            this.labelPrizvod.Size = new System.Drawing.Size(78, 13);
            this.labelPrizvod.TabIndex = 12;
            this.labelPrizvod.Text = "Izaberi prizvod:";
            this.labelPrizvod.Visible = false;
            // 
            // labelKolicina
            // 
            this.labelKolicina.AutoSize = true;
            this.labelKolicina.BackColor = System.Drawing.Color.Transparent;
            this.labelKolicina.ForeColor = System.Drawing.Color.White;
            this.labelKolicina.Location = new System.Drawing.Point(53, 367);
            this.labelKolicina.Name = "labelKolicina";
            this.labelKolicina.Size = new System.Drawing.Size(80, 13);
            this.labelKolicina.TabIndex = 13;
            this.labelKolicina.Text = "Izaberi kolicinu:";
            this.labelKolicina.Visible = false;
            // 
            // proizvodiTB
            // 
            this.proizvodiTB.AcceptsReturn = true;
            this.proizvodiTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.proizvodiTB.BackColor = System.Drawing.SystemColors.Control;
            this.proizvodiTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proizvodiTB.Font = new System.Drawing.Font("Cascadia Mono", 9.75F);
            this.proizvodiTB.Location = new System.Drawing.Point(79, 199);
            this.proizvodiTB.Multiline = true;
            this.proizvodiTB.Name = "proizvodiTB";
            this.proizvodiTB.ReadOnly = true;
            this.proizvodiTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.proizvodiTB.Size = new System.Drawing.Size(614, 487);
            this.proizvodiTB.TabIndex = 15;
            this.proizvodiTB.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 272);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Visible = false;
            // 
            // pazar
            // 
            this.pazar.FlatAppearance.BorderSize = 0;
            this.pazar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pazar.Location = new System.Drawing.Point(888, 307);
            this.pazar.Name = "pazar";
            this.pazar.Size = new System.Drawing.Size(85, 23);
            this.pazar.TabIndex = 17;
            this.pazar.Text = "Pazar";
            this.pazar.UseVisualStyleBackColor = true;
            this.pazar.Click += new System.EventHandler(this.pazar_Click);
            // 
            // labelDatum
            // 
            this.labelDatum.AutoSize = true;
            this.labelDatum.BackColor = System.Drawing.Color.Transparent;
            this.labelDatum.ForeColor = System.Drawing.Color.White;
            this.labelDatum.Location = new System.Drawing.Point(66, 278);
            this.labelDatum.Name = "labelDatum";
            this.labelDatum.Size = new System.Drawing.Size(73, 13);
            this.labelDatum.TabIndex = 18;
            this.labelDatum.Text = "Izaberi datum:";
            this.labelDatum.Visible = false;
            // 
            // labelTrenutnaKolicina
            // 
            this.labelTrenutnaKolicina.AutoSize = true;
            this.labelTrenutnaKolicina.BackColor = System.Drawing.Color.Transparent;
            this.labelTrenutnaKolicina.ForeColor = System.Drawing.Color.White;
            this.labelTrenutnaKolicina.Location = new System.Drawing.Point(53, 435);
            this.labelTrenutnaKolicina.Name = "labelTrenutnaKolicina";
            this.labelTrenutnaKolicina.Size = new System.Drawing.Size(103, 13);
            this.labelTrenutnaKolicina.TabIndex = 19;
            this.labelTrenutnaKolicina.Text = "Trenutna kolicina je:";
            this.labelTrenutnaKolicina.Visible = false;
            // 
            // buttonStanjeKasa
            // 
            this.buttonStanjeKasa.FlatAppearance.BorderSize = 0;
            this.buttonStanjeKasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStanjeKasa.Location = new System.Drawing.Point(1016, 307);
            this.buttonStanjeKasa.Name = "buttonStanjeKasa";
            this.buttonStanjeKasa.Size = new System.Drawing.Size(104, 23);
            this.buttonStanjeKasa.TabIndex = 20;
            this.buttonStanjeKasa.Text = "Izmeni stanje kase";
            this.buttonStanjeKasa.UseVisualStyleBackColor = true;
            this.buttonStanjeKasa.Click += new System.EventHandler(this.buttonStanjeKasa_Click);
            // 
            // UpravljanjeProizvodima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kafic.Properties.Resources.upravljanje_proizvodima;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.buttonStanjeKasa);
            this.Controls.Add(this.labelTrenutnaKolicina);
            this.Controls.Add(this.labelDatum);
            this.Controls.Add(this.pazar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelKolicina);
            this.Controls.Add(this.labelPrizvod);
            this.Controls.Add(this.labelVrsta);
            this.Controls.Add(this.naslovRadnje);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonDodaj);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.nazad);
            this.Controls.Add(this.izmeniKol);
            this.Controls.Add(this.stanje);
            this.Controls.Add(this.nabavka);
            this.Controls.Add(this.proizvodiTB);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "UpravljanjeProizvodima";
            this.Text = "UpravljanjeProizvodima";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpravljanjeProizvodima_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vrstaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bazaDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nabavka;
        private System.Windows.Forms.Button stanje;
        private System.Windows.Forms.Button izmeniKol;
        private System.Windows.Forms.Button nazad;
        private System.Windows.Forms.ComboBox comboBox1;
        private bazaDataSet bazaDataSet;
        private System.Windows.Forms.BindingSource vrstaBindingSource;
        private bazaDataSetTableAdapters.vrstaTableAdapter vrstaTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label naslov;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label naslovRadnje;
        private System.Windows.Forms.Label labelVrsta;
        private System.Windows.Forms.Label labelPrizvod;
        private System.Windows.Forms.Label labelKolicina;
        private System.Windows.Forms.TextBox proizvodiTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button pazar;
        private System.Windows.Forms.Label labelDatum;
        private System.Windows.Forms.Label labelTrenutnaKolicina;
        private System.Windows.Forms.Button buttonStanjeKasa;
    }
}