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

    }
}
