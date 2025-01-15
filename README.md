# BeraTeknoloji - Cihaz Yönetim Programı

## Proje Açıklaması
Bu proje, kullanıcıların telefon ve bilgisayar gibi cihazlar oluşturmasını ve bu cihazların özelliklerini görüntülemesini sağlayan bir konsol uygulamasıdır. Kullanıcılar cihazların adını, açıklamasını, işletim sistemini ve çeşitli diğer özelliklerini belirleyebilir.

## Özellikler
- **Telefon** ve **Bilgisayar** sınıflarıyla cihaz oluşturma.
- Cihaz bilgilerini detaylı olarak yazdırma.
- Kullanıcı girdilerinde geçerlilik kontrolleri:
  - Seri numarası doğrulama (pozitif sayı olmalı).
  - USB giriş sayısı kontrolü (sadece 2 veya 4 olabilir).
  - Lisans bilgisi ve Bluetooth desteği için geçerli giriş doğrulama.
- Kullanıcıya başka bir cihaz oluşturma seçeneği sunma.

## Kullanım
Uygulama çalıştırıldığında kullanıcıdan aşağıdaki adımlar izlenir:

1. **Cihaz Seçimi:**
   Kullanıcıya hangi cihazı oluşturmak istediği sorulur:
   - `1` - Telefon
   - `2` - Bilgisayar

2. **Cihaz Özelliklerinin Belirlenmesi:**
   - Telefon için:
     - Ad
     - Açıklama
     - İşletim Sistemi
     - Türkiye Lisans Durumu
     - Seri Numarası
   - Bilgisayar için:
     - Ad
     - Açıklama
     - İşletim Sistemi
     - USB Giriş Sayısı (2 veya 4)
     - Bluetooth Desteği
     - Seri Numarası

3. **Geçersiz Girdiler:**
   - Kullanıcı geçersiz bir seri numarası veya USB giriş sayısı girdiğinde uygun hata mesajı görüntülenir ve yeniden giriş istenir.

4. **Cihaz Bilgilerinin Görüntülenmesi:**
   Kullanıcı tarafından girilen tüm özellikler ekrana yazdırılır.

5. **Döngü:**
   Kullanıcı başka bir cihaz oluşturmak isteyip istemediği sorulur. İstemiyorsa program sonlandırılır.

## Koddan Örnek
### Telefon Oluşturma Kodu
```csharp
Telefon telefon = new Telefon();

Console.Write("Telefon adı girin: ");
telefon.Ad = Console.ReadLine();

Console.Write("Telefon açıklaması girin: ");
telefon.Aciklama = Console.ReadLine();

Console.Write("Telefon işletim sistemi girin: ");
telefon.IsletimSistemi = Console.ReadLine();

Console.Write("Telefon Türkiye lisanslı mı? (Evet/Hayır): ");
string lisansliMi = Console.ReadLine()?.ToLower();
if (lisansliMi == "evet")
{
    telefon.TrLisansliMi = true;
}
else if (lisansliMi == "hayır")
{
    telefon.TrLisansliMi = false;
}
else
{
    Console.WriteLine("Geçersiz giriş yapıldı. Varsayılan olarak 'Hayır' seçildi.");
    telefon.TrLisansliMi = false;
}

Console.Write("Seri Numarasını girin: ");
if (!long.TryParse(Console.ReadLine(), out long telefonSeriNo) || telefonSeriNo <= 0)
{
    Console.WriteLine("Geçersiz seri numarası. Lütfen geçerli bir pozitif sayı girin.");
}
else
{
    telefon.SeriNo = telefonSeriNo;
}

telefon.BilgileriYazdir();
telefon.UrunAdiGetir();
```

## Gereksinimler
- .NET Framework veya .NET Core
- C# derleyicisi

## Nasıl Çalıştırılır?
1. Proje dosyasını bir C# IDE'sine (örneğin Visual Studio) yükleyin.
2. Programı çalıştırın.
3. Konsoldaki yönergeleri takip ederek cihaz oluşturun.

## Geliştirilecek Özellikler
- Cihaz bilgilerini bir dosyaya kaydetme ve dosyadan okuma.
- Kullanıcıdan daha fazla bilgi talep etme (örneğin fiyat, üretici marka).
- Yeni cihaz türlerinin eklenmesi (örneğin tablet, akıllı saat).

## Yazar
BeraTeknoloji Geliştirme Ekibi

