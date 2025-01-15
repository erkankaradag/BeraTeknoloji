using System;
using System.Diagnostics;
using System.Threading.Channels;
namespace BeraTeknoloji
{
    class Program
    {
        static void Main(string[] args)
        {

            bool devamEt = true;

            while (devamEt)
            {
      
            Console.WriteLine("Lütfen oluşturmak istediğiniz cihazı seçin! (1: Telefon, 2: Bilgisayar)");
            string secim = Console.ReadLine();
                switch (secim)
                {
                    case "1": //Telefon seçildiğinde
                        Telefon telefon = new Telefon();

                        Console.Write("Telefon adı girin: ");
                        telefon.Ad = Console.ReadLine();

                        Console.Write("Telefon açıklaması girin: ");
                        telefon.Aciklama = Console.ReadLine();

                        Console.Write("Telefon işletim sistemi girin: ");
                        telefon.IsletimSistemi = Console.ReadLine();

                        Console.Write("Telefon Türkiye lisanslı mı?: ");
                        string lisansliMi = Console.ReadLine().ToLower();
                        telefon.TrLisansliMi = lisansliMi == "evet";

                        Console.Write("Seri Numarasını girin: ");
                        if (!long.TryParse(Console.ReadLine(), out long telefonSeriNo))
                        {
                            Console.WriteLine("Geçersiz seri numarası. Lütfen geçerli bir sayı girin.");
                        }
                        else
                        {
                            telefon.SeriNo = telefonSeriNo;
                        }


                        telefon.BilgileriYazdir();
                        telefon.UrunAdiGetir();
                        break;

                    case "2": //Bilgisayar seçildiğinde

                        Bilgisayar bilgisayar = new Bilgisayar();

                        Console.Write("Bilgisayar adı girin: ");
                        bilgisayar.Ad = Console.ReadLine();

                        Console.Write("Bilgisayar açıklaması girin: ");
                        bilgisayar.Aciklama = Console.ReadLine();

                        Console.Write("Bilgisayar işletim sistemi girin: ");
                        bilgisayar.IsletimSistemi = Console.ReadLine();

                        Console.Write("Bilgisayar USB giriş sayısını girin (2 veya 4): ");
                        if (int.TryParse(Console.ReadLine(), out int usbSayisi))
                        {
                            bilgisayar.UsbSayisi = usbSayisi;
                        }
                        else
                        {
                            Console.Write("Geçersiz giriş yapıldı. USB giriş sayısı varsayılan olarak -1 atandı.");
                            bilgisayar.UsbSayisi = -1;
                        }
                        Console.Write("Bilgisayarda bluetooth var mı? (Evet / Hayır) : ");
                        string bluetoothVarMi = Console.ReadLine().ToLower();
                        bilgisayar.BluetoothVarMi = bluetoothVarMi == "evet";

                        Console.Write("Bilgisayar seri numarasını girin: ");
                        if (!long.TryParse(Console.ReadLine(), out long bilgisayarSeriNo))
                        {
                            Console.WriteLine("Geçersiz seri numarası. Lütfen geçerli bir sayı girin.");
                        }
                        else
                        {
                            bilgisayar.SeriNo = bilgisayarSeriNo;
                        }

                        bilgisayar.BilgileriYazdir();
                        bilgisayar.UrunAdiGetir();
                        break;
                    default: //Geçersiz seçim
                        Console.Write("Hatalı seçim yaptınız! Lütfen 1 veya 2 seçin.");
                        continue;
                }
                // Başka ürün üretmek isteyip istemediğini sorma
                Console.Write("\nBaşka bir ürün üretmek istiyor musunuz? (Evet/Hayır):");
                string devam = Console.ReadLine();
                devamEt = devam.ToLower() == "evet";

                if (!devamEt)
                {
                    Console.Write("Program sonlandırılıyor. İyi günler!");
                }

            }
        }
    }
}