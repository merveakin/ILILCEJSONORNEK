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
    public partial class FormILEAitILceleriSorgulama : Form
    {
        public FormILEAitILceleriSorgulama()
        {
            InitializeComponent();
        }

        //GLOBAL
        ILServis ilservisim = new ILServis();
        ILILCEServis ilceServis = new ILILCEServis();

        private void FormILEAitILceleriSorgulama_Load(object sender, EventArgs e)
        {
            comboBoxILLER.DataSource = ilservisim.IlleriGetir();
            comboBoxILLER.DisplayMember = "ILAdi";
            comboBoxILLER.ValueMember = "PlakaKodu";
        }

        private void comboBoxILLER_SelectedIndexChanged(object sender, EventArgs e)
        {
            //yani içindeki değer değiştiğinde bu metot tetiklenecek/çalışacak..
            IL secilenIL = comboBoxILLER.SelectedItem as IL;
            // kısa yol --->    IL secilenIL = (IL)comboBoxILLER.SelectedItem;
            //BLL'nin bilgileri getirmesine ihtiyacım var.
            // BLL'de öyle bir metot olmalı ki... il ismini parametre olarak verince bana ilçeye dair detay bilgileri versin.

            List<ILveILCEBILGILERI> sehreAitIlcelerListem =
                   ilceServis.ILAdinaGoreIlceleriGetir(secilenIL.ILAdi);



            listView1.Items.Clear();

            foreach (var item in sehreAitIlcelerListem)
            {
                //her birinin listviewitem olarak tutup

                ListViewItem li = new ListViewItem();
                li.Text = item.Ismi;
                li.Tag = item;
                li.SubItems.Add(item.Tel);
                li.SubItems.Add(item.Mail);
                //listView içerisine ekleyeceğeim.

                listView1.Items.Add(li);
            }


        }
    }
}
