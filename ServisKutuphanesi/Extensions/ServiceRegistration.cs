using Microsoft.Extensions.DependencyInjection;
using DataModel;
using ServisKutuphanesi.Interfaces;
using ServisKutuphanesi.Services;

namespace ServisKutuphanesi.Extensions;

/// <summary>
/// Servis kayıt uzantısı - DI container'a servisleri eklemek için kullanılır
/// </summary>
public static class ServiceRegistration
{
    /// <summary>
    /// Tüm servisleri DI container'a kaydeder
    /// </summary>
    /// <param name="services">Service collection</param>
    /// <returns>Service collection</returns>
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        // Veritabanı bağlamı kaydedilir
        services.AddScoped<LokantaContext>();

        // Servisler kaydedilir
        services.AddScoped<IKullaniciService, KullaniciService>();
        services.AddScoped<IUrunService, UrunService>();

        return services;
    }
}
