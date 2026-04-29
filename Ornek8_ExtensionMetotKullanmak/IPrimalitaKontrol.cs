namespace Ornek8_ExtensionMetotKullanmak;

/// <summary>
/// Sayıların asal olup olmadığını kontrol eden arayüz
/// </summary>
public interface IPrimalitaKontrol
{
    /// <summary>
    /// Verilen bir sayının asal olup olmadığını kontrol eder
    /// </summary>
    /// <param name="sayi">Kontrol edilecek sayı</param>
    /// <returns>Asal ise true, değilse false</returns>
    bool AsalMi(int sayi);
}
