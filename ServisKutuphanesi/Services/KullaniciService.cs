using DataModel;
using ServisKutuphanesi.Interfaces;

namespace ServisKutuphanesi.Services;

/// <summary>
/// Kullanıcı işlemlerini gerçekleştiren servis sınıfı
/// </summary>
public class KullaniciService : IKullaniciService
{
    private readonly LokantaContext _context;

    public KullaniciService(LokantaContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Veritabanına yeni bir kullanıcı ekler
    /// </summary>
    public async Task<bool> KullaniciEkleAsync(Kullanici kullanici)
    {
        try
        {
            _context.Kullanici.Add(kullanici);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Kullanıcı ekleme hatası: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Kullanıcı ID'sine göre kullanıcıyı siler
    /// </summary>
    public async Task<bool> KullaniciSilAsync(int id)
    {
        try
        {
            var kullanici = await _context.Kullanici.FindAsync(id);
            if (kullanici != null)
            {
                _context.Kullanici.Remove(kullanici);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Kullanıcı silme hatası: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Tüm kullanıcıları getirir
    /// </summary>
    public async Task<List<Kullanici>> TumKullanicilarGetirAsync()
    {
        try
        {
            return await Task.FromResult(_context.Kullanici.ToList());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Kullanıcılar getirme hatası: {ex.Message}");
            return new List<Kullanici>();
        }
    }

    /// <summary>
    /// Kullanıcı ID'sine göre kullanıcıyı getirir
    /// </summary>
    public async Task<Kullanici> KullaniciGetirAsync(int id)
    {
        try
        {
            return await _context.Kullanici.FindAsync(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Kullanıcı getirme hatası: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Kullanıcı bilgilerini günceller
    /// </summary>
    public async Task<bool> KullaniciGuncelleAsync(Kullanici kullanici)
    {
        try
        {
            _context.Kullanici.Update(kullanici);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Kullanıcı güncelleme hatası: {ex.Message}");
            return false;
        }
    }
}
