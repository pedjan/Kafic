using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kafic
{
    public class Sto
    {
        private int idS;
        private string ime;
        private int posX;
        private int posY;

        public Button stoBtn = new System.Windows.Forms.Button();

        Pocetna pocetna;

        public Sto(int idS, string ime, int posX, int posY)
        {
            this.idS = idS;
            this.ime = ime;
            this.posX = posX;
            this.posY = posY;
        }
        public Sto(int idS, string ime, int posX, int posY, Pocetna pocetna)
        {
            this.idS = idS;
            this.ime = ime;
            this.posX = posX;
            this.posY = posY;
            this.pocetna = pocetna;

            stoBtn.BackColor = System.Drawing.Color.Blue;
            stoBtn.FlatAppearance.BorderSize = 5;
            stoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            stoBtn.Location = new System.Drawing.Point(posX, posY);
            stoBtn.Name = ime;
            stoBtn.Size = new System.Drawing.Size(100, 100);
            stoBtn.UseVisualStyleBackColor = false;
            stoBtn.TabIndex = idS;
            stoBtn.Anchor = (System.Windows.Forms.AnchorStyles.None);

            //stoBtn.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);

            stoBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(pocetna.sto_MouseDown);
            stoBtn.MouseMove += new System.Windows.Forms.MouseEventHandler(pocetna.sto_MouseMove);
            stoBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(pocetna.sto_MouseUp);
            stoBtn.Click += new System.EventHandler(pocetna.sto_Click);

            pocetna.Controls.Add(stoBtn);
        }

        public int getIdS() { 
            return this.idS;
        }

        public string getIme()
        {
            return this.ime;
        }

        public int getX()
        {
            return this.posX;
        }

        public int getY()
        {
            return this.posY;
        }
    }
}
