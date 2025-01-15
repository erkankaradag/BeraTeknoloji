using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BeraTeknoloji
{
    internal abstract class BaseMakine
    {
        public DateTime UretimTarihi { get; set; }
        public long SeriNo { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }

        public BaseMakine()
        {
            UretimTarihi = DateTime.Now;
        }
        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"\nÜretim Tarihi: {UretimTarihi}");
            Console.WriteLine($"Seri Numarası: {SeriNo}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
        }
        // Soyut bir metot olduğundan gövde olmamalı
        public abstract void UrunAdiGetir();
    }

}


