using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ILILCEJSONORNEK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ILSorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Açık bir form varsa kapatılacak.
            if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Hide();
            }

            FormILSorgulama formILSorgulama = new FormILSorgulama();
            formILSorgulama.MdiParent = this;
            formILSorgulama.Show();
            //form içinde form boyutlarunda göstermesi için ayarlama yap
            this.LayoutMdi(MdiLayout.TileVertical);

        }

        private void ıLCESorgulamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild!=null)
            {
                this.ActiveMdiChild.Hide();
            }
            FormILEAitILceleriSorgulama frmILCE = new FormILEAitILceleriSorgulama();
            frmILCE.MdiParent = this;
            frmILCE.Show();

            this.LayoutMdi(MdiLayout.TileVertical);


        }
    }
}
