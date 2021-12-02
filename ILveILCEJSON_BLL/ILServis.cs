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
            using (WebClient istemci =new WebClient())
            {
                byte[] data = istemci.DownloadData(@"C:\Users\103SABAH_MERVE\source\repos\ILILCEJSONORNEK\ILILCEJSONORNEK\belediyeler.json");

                //JSon dosyasınki ş ç ü gibi harfler çevrilirken bozulma olabiliyor. Biz Encoding.UTF8 kullanırsak bütün dillere göre çözümleme sunar.

                JSonString = Encoding.UTF8.GetString(data);

            }
        }
        public List<IL> IlleriGetir()
        {
            return JsonConvert.DeserializeObject<List<IL>>(JSonString);
        }
    }
}
