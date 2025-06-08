using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafic
{
    public partial class UpravljanjeProizvodima : Form
    {
        private Pocetna parentForm;
        private Baza baza = new Baza();
        private List<Vrsta> vrste = new List<Vrsta>();
        private List<Button> proizvodiBtn = new List<Button>();
        private List<Button> vrsteBtn = new List<Button>();

        public UpravljanjeProizvodima(Pocetna parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            parentForm.Show();
            this.Hide();
        }

        private void nazadP_Click(object sender, EventArgs e)
        {
            nabavka.Visible = true;
            stanje.Visible = true;
            izmeniKol.Visible = true;

            foreach (Button btn in vrsteBtn)
            {
                this.Controls.Remove(btn);
            }

            foreach (Button btn in proizvodiBtn)
            {
                this.Controls.Remove(btn);
            }

            this.nazad.Click += new System.EventHandler(this.nazad_Click);
            this.nazad.Click -= new System.EventHandler(this.nazadP_Click);

        }

        private void nabavka_Click(object sender, EventArgs e)
        {
            this.nazad.Click -= new System.EventHandler(this.nazad_Click);
            this.nazad.Click += new System.EventHandler(this.nazadP_Click);

            nabavka.Visible = false;
            stanje.Visible = false;
            izmeniKol.Visible = false;

            vrste = baza.getVrste();

            foreach (Vrsta vrsta in vrste)
            {
                Button vrstaBtn = new Button
                {
                    Text = vrsta.getIme(),
                    Location = new Point(461 + 72 * (vrsta.getIdV() - 1), 12),
                    BackColor = Color.White,
                    //FlatAppearance.BorderSize = 0,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat
                };
                vrstaBtn.FlatAppearance.BorderSize = 0;
                vrstaBtn.Click += vrstaBtn_Click;
                vrsteBtn.Add(vrstaBtn);
                this.Controls.Add(vrstaBtn);
            }


        }

        private void vrstaBtn_Click(object sender, EventArgs e)
        {
            if (proizvodiBtn.Count != 0)
            {
                foreach (Button btn in proizvodiBtn)
                {
                    this.Controls.Remove(btn);
                }
            }
            string imeVrste = (sender as Button).Text;
            List<Proizvod> proizvodi = new List<Proizvod>();
            foreach (Vrsta vrsta in vrste)
            {
                if (vrsta.getIme().Equals(imeVrste))
                {
                    proizvodi = baza.getProizvodiByVrsta(vrsta.getIdV());
                }
            }
            int i = 0;
            foreach (Proizvod p in proizvodi)
            {
                Button proizvodBtn = new Button
                {
                    Text = p.getIme(),
                    Location = new Point(461 + 100 * i, 81),
                    Size = new Size(100, 30),
                    BackColor = Color.White,
                    //FlatAppearance.BorderSize = 0,
                    FlatStyle = System.Windows.Forms.FlatStyle.Flat
                };
                proizvodBtn.FlatAppearance.BorderSize = 0;
                //proizvodBtn.Click += item_Click;
                proizvodiBtn.Add(proizvodBtn);
                this.Controls.Add(proizvodBtn);
                i++;
            }
        }

    }
}
