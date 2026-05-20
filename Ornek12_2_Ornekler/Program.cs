namespace Ornek12_2_Ornekler;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

internal class Program
{
    public static ServiceCollection services = new ServiceCollection();

    private static ServiceProvider servisSaglayici;
    public Program()
    {  
       
        services.AddTransient<IMesaj, EmailGonder>();
        services.AddTransient<KullaniciYonetim>();
        servisSaglayici=services.BuildServiceProvider();
    }
    private static void Main(string[] args)
    {
        //KullaniciYonetim kullaniciYonetim = new KullaniciYonetim(new SmsGonder());

 

        var servisSaglayici = services.BuildServiceProvider();

        //KullaniciYonetim kullaniciYonetim = new KullaniciYonetim();

        KullaniciYonetim kullaniciYonetim = servisSaglayici.GetService<KullaniciYonetim>();
        kullaniciYonetim.BildirimGonder();

        //kullaniciYonetim.BildirimGonder(new EmailGonder());
        //kullaniciYonetim.BildirimGonder(new SmsGonder());

        //KullaniciYonetim kullaniciYonetim2 = new KullaniciYonetim(servisSaglayici.GetService<IMesaj>());

       
    }

    public static void Islem()
    {
        //var servisSaglayici = services.BuildServiceProvider();
        var kulaniciYonetim = servisSaglayici.GetService<KullaniciYonetim>();
    }
}