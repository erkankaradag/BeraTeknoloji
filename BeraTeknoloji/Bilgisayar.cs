using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeraTeknoloji
{
    internal class Bilgisayar : BaseMakine
    {
        private int usbSayisi;
        public int UsbSayisi
        {
            get
            {
                return usbSayisi;
            }
            set
            {
                if (value == 2 || value == 4)
                {
                    usbSayisi = value;
                }
                else
                {
                    Console.WriteLine("Varsayılan USB giriş portu 2 veya 4 olmalıdır. Hatalı giriş sayısı yapıldığı için değer -1 olarak atandı.");
                    usbSayisi = -1;
                }
            }
        }

        public bool BluetoothVarMi { get; set; }
        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"Bluetooth var mı?: {(BluetoothVarMi ? "Evet" : "Hayır")}");
            Console.WriteLine($"Usb giriş sayısı: {UsbSayisi}");
        }
        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }


    };

}

