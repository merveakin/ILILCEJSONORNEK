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

        public List<ILveILCEBILGILERI> ILAdinaGoreIlceleriGetir(string ilAdi)
        {

            List<ILveILCEBILGILERI> liste = new List<ILveILCEBILGILERI>();
            JObject j = JObject.Parse(JsonString);

            //ağrı ---> agri        //ismi Json içindeki gibi değiştirdik.


           List<string> ilcelerListem= ilservisi.IlleriGetir().Single(x => x.ILAdi == ilAdi).Ilceleri;


            //ilçeler de json içinde ingilizce karakterli halde yazıyor.
            //bu nedenle onu da çevirdik.
            ilcelerListem = ilcelerListem.Select(x => DilIslemleri.TurkceKarakterleriIngilizceyeCevir(x.ToLower())).ToList();

            ilAdi = DilIslemleri.TurkceKarakterleriIngilizceyeCevir(ilAdi.ToLower());


            foreach (var item in ilcelerListem)
            {
                var data = j.SelectToken(ilAdi.ToLower()).SelectToken(item);
               
                //bazı illerin ilçelerinde null gelme durumuna yakalanmayalım.
                
                if (data != null)
                {
                    ILveILCEBILGILERI bilgim = new ILveILCEBILGILERI();
                    bilgim.Ismi = data["belediye-ismi"] == null ? "" : data["belediye-ismi"].ToObject<string>();
                    bilgim.Tel = data["belediye-tel"]==null? "": data["belediye-tel"].ToObject<string>();
                    bilgim.Faks = data["belediye-faks"]==null? "":data["belediye-faks"].ToObject<string>();
                    bilgim.Mail = data["belediye-mail"] == null ? "" : data["belediye-mail"].ToObject<string>();
                    bilgim.Web = data["belediye-web"] == null ? "" : data["belediye-web"].ToObject<string>();
                    bilgim.Nufus = data["nufus"].ToObject<string>();
                    bilgim.Bilgi = data["bilgi"]==null? "":data["bilgi"].ToObject<string>();
                    liste.Add(bilgim);
                }
            }


            return liste;
        }



    }
}
