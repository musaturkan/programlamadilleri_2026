using DataModel;

namespace ServisKutuphanesi.Interfaces;

/// <summary>
/// Kullanıcı işlemlerini gerçekleştiren servis arayüzü
/// </summary>
public interface IKullaniciService
{
    /// <summary>
    /// Veritabanına yeni bir kullanıcı ekler
    /// </summary>
    Task<bool> KullaniciEkleAsync(Kullanici kullanici);

    /// <summary>
    /// Kullanıcı ID'sine göre kullanıcıyı siler
    /// </summary>
    Task<bool> KullaniciSilAsync(int id);

    /// <summary>
    /// Tüm kullanıcıları getirir
    /// </summary>
    Task<List<Kullanici>> TumKullanicilarGetirAsync();

    /// <summary>
    /// Kullanıcı ID'sine göre kullanıcıyı getirir
    /// </summary>
    Task<Kullanici> KullaniciGetirAsync(int id);

    /// <summary>
    /// Kullanıcı bilgilerini günceller
    /// </summary>
    Task<bool> KullaniciGuncelleAsync(Kullanici kullanici);
}
