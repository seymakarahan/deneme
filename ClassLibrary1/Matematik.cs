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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="v_Gelen">Değerleri Doldur Yolla</param>
        /// <returns>Hata varsa açıklamayı mutlaka ekrana yazdır</returns>
        public ToplamaIslemSonuc fn_Topla(requestfntopla v_Gelen)
        {
            #region Burada değişkenleri Tanımladım

            ToplamaIslemSonuc _Gidecek = new ToplamaIslemSonuc();

            int abc = 0;

            #endregion

            try
            {
               

                abc =int.Parse( v_Gelen.sayi1) +int.Parse( v_Gelen.sayi2);              

                _Gidecek._Yanit = Durum.Basarili;
                _Gidecek._HataAciklama = "";
                _Gidecek._Cevap = abc;

            }
            catch (Exception ex)
            {
                #region Hatayı yakalayıp geri döndüm
                _Gidecek = new ToplamaIslemSonuc();
                _Gidecek._Yanit = Durum.HataVar;
                _Gidecek._HataAciklama = ex.ToString();
                _Gidecek._Cevap = 0;
                #endregion

            }

            return _Gidecek;
        }
        public int fn_Bolme(int _Sayi1, int _Sayi2)
        {
            return _Sayi1 / _Sayi2;
        }
    }
}
