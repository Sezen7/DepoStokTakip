using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoStokTakip.Models
{
    public class Urun
    {
        public int ID { get; set; }
        public string QRKod { get; set; }
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; }
        public int MarkaID { get; set; }
        public string Birim { get; set; }
        public int StokMiktari { get; set; }
        public int MinStok { get; set; }
        public string Aciklama { get; set; }
    }
}
