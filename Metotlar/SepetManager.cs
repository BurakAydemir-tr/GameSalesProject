using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete eklendi: "+urun.Adi);
        }

        public void Ekle2(string urunAdi,string urunAciklama, double urunFiyat)
        {
            Console.WriteLine("Sepete eklendi: " + urunAdi);
        }
    }
}
