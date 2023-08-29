using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Matematik
    {

        public Matematik() { }

        public ToplamaIslemSonuc fn_Topla(requestfntopla v_Gelen)
        {
            ToplamaIslemSonuc _Gidecek = new ToplamaIslemSonuc();

            try
            {
                int abc = 0;

                abc = v_Gelen.sayi1 + v_Gelen.sayi2;              

                _Gidecek._Yanit = Durum.Basarili;
                _Gidecek._HataAciklama = "";
                _Gidecek._Cevap = abc;

            }
            catch (Exception ex)
            {
                _Gidecek = new ToplamaIslemSonuc();
                _Gidecek._Yanit = Durum.HataVar;
                _Gidecek._HataAciklama = ex.ToString();
                _Gidecek._Yanit = 0;
            }

            return _Gidecek;
        }
        public int fn_Bolme(int _Sayi1, int _Sayi2)
        {
            return _Sayi1 / _Sayi2;
        }
    }
}
