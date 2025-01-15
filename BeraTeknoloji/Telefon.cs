using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeraTeknoloji
{
    internal class Telefon : BaseMakine
    {
        public bool TrLisansliMi { get; set; }
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR lisanslı mı?: {(TrLisansliMi ? "Evet" : "Hayır")}");
        }
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }
    
}
