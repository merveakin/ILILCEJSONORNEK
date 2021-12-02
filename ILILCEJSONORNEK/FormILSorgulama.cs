using ILveILCEJSON_BLL;
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
    public partial class FormILSorgulama : Form
    {
        public FormILSorgulama()
        {
            InitializeComponent();
        }
        //GLOBAL ALAN
        ILServis ilServisim = new ILServis();
        private void FormILSorgulama_Load(object sender, EventArgs e)
        {
            //form Yüklenirken burası çalışacak

            comboBoxILSecimi.DataSource = ilServisim.IlleriGetir();
            comboBoxILSecimi.DisplayMember = "il";



        }
    }
}
