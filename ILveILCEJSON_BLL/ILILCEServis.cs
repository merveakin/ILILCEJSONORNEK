using ILveILCEJSON_ENTITYMODELS.Classes;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJSON_BLL
{
    public class ILILCEServis
    {
        private string JsonString = string.Empty;

        ILServis ilservisi = new ILServis();

        public ILILCEServis()
        {
            VeriKaynaginaBaglan();
        }

        private void VeriKaynaginaBaglan()
        {
            using (WebClient istemci = new WebClient())
            {
                byte[] data = istemci.DownloadData(@"C:\Users\103SABAH_MERVE\source\repos\ILILCEJSONORNEK\belediyelerfull.json");
                JsonString = Encoding.UTF8.GetString(data);
            }
        }
        public List<ILveILCEBILGILERI> BilgileriGetir()
        {
            List<ILveILCEBILGILERI> liste = new List<ILveILCEBILGILERI>();

            JObject j = JObject.Parse(JsonString);

            List<string> illerim = ilservisi.IlleriGetir().Select(x => x.ILAdi).ToList();

            illerim = illerim.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();

            foreach (string item in illerim)
            {
                //Her bir il için bilgileri belediyelerfull.json'dan çekeceğiz.
                var data = j.SelectToken(item).SelectToken("il");

                ILveILCEBILGILERI detayliBilgi = new ILveILCEBILGILERI();
                detayliBilgi.Plaka=Convert.ToByte(data["plaka"].ToObject<string>());

                detayliBilgi.Tel = data["belediye-tel"].ToObject<string>();

                detayliBilgi.Faks=data["belediye-faks"].ToObject<string>();

                detayliBilgi.Ismi=data["belediye-ismi"].ToObject<string>();

                detayliBilgi.Mail = data["belediye-mail"] == null ? 
                    "" 
                    : data["belediye-mail"].ToObject<string>();

                detayliBilgi.Web = data["belediye-web"] == null ?
                    ""
                    : data["belediye-web"].ToObject<string>();

                detayliBilgi.Nufus=data["nufus"].ToObject<string>();

                detayliBilgi.Alankodu = data["alankodu"]==null ? 
                    "" 
                    : data["alankodu"].ToObject<string>();

                detayliBilgi.Bolge = data["bolge"].ToObject<string>();

                detayliBilgi.Bilgi = data["bilgi"].ToString();

                liste.Add(detayliBilgi);
            }

            return liste;
        }
    }
}
