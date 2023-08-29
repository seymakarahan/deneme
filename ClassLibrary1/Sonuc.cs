using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ToplamaIslemSonuc
    {
        public Durum _Yanit { get; set; }
        public string _HataAciklama { get; set; }
        public int _Cevap { get; set; }
        
    }

    public enum Durum { 
        HataVar=10,
        Basarili=20,
        CevapBekleniyor=30
    }
}
