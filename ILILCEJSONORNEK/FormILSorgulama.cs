using ILveILCEJSON_BLL;
using ILveILCEJSON_ENTITYMODELS.Classes;
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
        ILILCEServis ILILCEServisim = new ILILCEServis();
        private void FormILSorgulama_Load(object sender, EventArgs e)
        {
            //form Yüklenirken burası çalışacak

            //combobox'ın içine illeri getirdim.
            comboBoxILSecimi.DataSource = ilServisim.IlleriGetir();
            comboBoxILSecimi.DisplayMember = "ILAdi";
            comboBoxILSecimi.ValueMember = "PlakaKodu";

            //ListView ile içini dolduracağız.
            List<ILveILCEBILGILERI> SehireAitBilgilerListesi = ILILCEServisim.BilgileriGetir();

            foreach (var item in SehireAitBilgilerListesi)
            {

                ListViewItem deger = new ListViewItem()
                {
                    Text=item.Ismi,
                    Tag=item
                };


                deger.SubItems.Add(item.Tel);
                deger.SubItems.Add(item.Faks);
                deger.SubItems.Add(item.Mail);
                deger.SubItems.Add(item.Web);

                //listview'e ekleme yapılacak.
                listView1.Items.Add(deger);
            }


        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            //ILILCEServis deneme = new ILILCEServis();
            //deneme.BilgileriGetir();
        }
    }
}
