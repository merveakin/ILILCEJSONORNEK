using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ILveILCEJSON_ENTITYMODELS.Classes
{
    public class IL
    {
        //C# Property kurallarına göre IL isimli class'ı oluşturduk.
        //JsonIL class deserialize olunca oradaki dataları IL Class'ında türeteceğimiz nesneye aktaracağız.

        public string ILAdi { get; set; }
        public byte PlakaKodu { get; set; }
        public List<string> Ilceleri { get; set; }

    }
}
