using DataModel;

namespace ServisKutuphanesi.Interfaces;

/// <summary>
/// Ürün işlemlerini gerçekleştiren servis arayüzü
/// </summary>
public interface IUrunService
{
    /// <summary>
    /// Veritabanına yeni bir ürün ekler
    /// </summary>
    Task<bool> UrunEkleAsync(Yemek urun);

    /// <summary>
    /// Ürün ID'sine göre ürünü siler
    /// </summary>
    Task<bool> UrunSilAsync(int id);

    /// <summary>
    /// Tüm ürünleri getirir
    /// </summary>
    Task<List<Yemek>> TumUrunleriGetirAsync();

    /// <summary>
    /// Ürün ID'sine göre ürünü getirir
    /// </summary>
    Task<Yemek> UrunGetirAsync(int id);

    /// <summary>
    /// Ürün bilgilerini günceller
    /// </summary>
    Task<bool> UrunGuncelleAsync(Yemek urun);
}
