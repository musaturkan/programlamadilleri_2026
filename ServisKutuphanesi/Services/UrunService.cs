using DataModel;
using ServisKutuphanesi.Interfaces;

namespace ServisKutuphanesi.Services;

/// <summary>
/// Ürün işlemlerini gerçekleştiren servis sınıfı
/// </summary>
public class UrunService : IUrunService
{
    private readonly LokantaContext _context;

    public UrunService(LokantaContext context)
    {
        _context = context;
    }

    /// <summary>
    /// Veritabanına yeni bir ürün ekler
    /// </summary>
    public async Task<bool> UrunEkleAsync(Yemek urun)
    {
        try
        {
            _context.Yemek.Add(urun);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ürün ekleme hatası: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Ürün ID'sine göre ürünü siler
    /// </summary>
    public async Task<bool> UrunSilAsync(int id)
    {
        try
        {
            var urun = await _context.Yemek.FindAsync(id);
            if (urun != null)
            {
                _context.Yemek.Remove(urun);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ürün silme hatası: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Tüm ürünleri getirir
    /// </summary>
    public async Task<List<Yemek>> TumUrunleriGetirAsync()
    {
        try
        {
            return await Task.FromResult(_context.Yemek.ToList());
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ürünler getirme hatası: {ex.Message}");
            return new List<Yemek>();
        }
    }

    /// <summary>
    /// Ürün ID'sine göre ürünü getirir
    /// </summary>
    public async Task<Yemek> UrunGetirAsync(int id)
    {
        try
        {
            return await _context.Yemek.FindAsync(id);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ürün getirme hatası: {ex.Message}");
            return null;
        }
    }

    /// <summary>
    /// Ürün bilgilerini günceller
    /// </summary>
    public async Task<bool> UrunGuncelleAsync(Yemek urun)
    {
        try
        {
            _context.Yemek.Update(urun);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ürün güncelleme hatası: {ex.Message}");
            return false;
        }
    }
}
