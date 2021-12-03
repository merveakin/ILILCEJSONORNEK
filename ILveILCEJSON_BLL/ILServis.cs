using ILveILCEJSON_ENTITYMODELS.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJSON_BLL
{
    public class ILServis
    {
        private string JSonString = string.Empty;       //Field
        public ILServis()
        {
            VeriKaynaginaBaglan();
        }

        private void VeriKaynaginaBaglan()
        {
            using (WebClient istemci = new WebClient())
            {
                byte[] data = istemci.DownloadData(@"C:\Users\103SABAH_MERVE\source\repos\ILILCEJSONORNEK\belediyeler.json");

                //JSon dosyasınki ş ç ü gibi harfler çevrilirken bozulma olabiliyor. Biz Encoding.UTF8 kullanırsak bütün dillere göre çözümleme sunar.

                JSonString = Encoding.UTF8.GetString(data);

            }
        }
        public List<IL> IlleriGetir()
        {
            List<IL> ILListesi = new List<IL>();

            //data ILJson classından alınacak.Oradaki propertyler küçük harfli. Çünkü json dosyasında küçük harfli yazmışlar.
            var jsonData = JsonConvert.DeserializeObject<List<ILJson>>(JSonString);

            //Alınan data bizim sistemimizdeki IL Classına aktarılacak.
            foreach (var item in jsonData)
            {
                ILListesi.Add(
                    new IL()
                    {
                        ILAdi = item.il,
                        PlakaKodu = Convert.ToByte(item.plaka),
                        Ilceleri = item.ilceleri
                    });
            }

            return ILListesi;
        }
    }
}
