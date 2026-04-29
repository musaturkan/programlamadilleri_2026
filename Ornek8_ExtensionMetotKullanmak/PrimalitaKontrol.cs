namespace Ornek8_ExtensionMetotKullanmak;

/// <summary>
/// Asal sayı kontrol işlemlerini gerçekleştiren sınıf
/// </summary>
public class PrimalitaKontrol : IPrimalitaKontrol
{
    /// <summary>
    /// Verilen bir sayının asal olup olmadığını kontrol eder
    /// </summary>
    /// <param name="sayi">Kontrol edilecek sayı</param>
    /// <returns>Asal ise true, değilse false</returns>
    public bool AsalMi(int sayi)
    {
        // 1 ve daha küçük sayılar asal değildir
        if (sayi <= 1)
            return false;

        // 2 asal bir sayıdır
        if (sayi == 2)
            return true;

        // Çift sayılar asal değildir (2 hariç)
        if (sayi % 2 == 0)
            return false;

        // Tek sayılar için 3'ten başlayarak karekökü kadar kontrol yapılır
        // Eğer sayi, 3'ten karekökü kadar bir sayıya tam bölünüyorsa, asal değildir
        for (int i = 3; i * i <= sayi; i += 2)
        {
            if (sayi % i == 0)
                return false;
        }

        // Tüm kontroller başarılıysa, sayı asaldır
        return true;
    }
}
