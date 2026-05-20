namespace Ornek12_1_Ornekler;

public class Program
{
    private static void Main(string[] args)
    {
        //Dependency Injection (Bağımlılık Enjeksiyonu) Nedir?
        //Servis sınıflarının ihtiyaç duyduğu bağımlılıkları dışarıdan sağlayarak,
        //sınıflar arasındaki bağımlılıkları azaltmayı amaçlayan bir tasarım desenidir.

        KullaniciYonetim kullaniciYonetim = new KullaniciYonetim(new SmsGonder());
   
        kullaniciYonetim.BildirimGonder();

        KullaniciYonetim kullaniciYonetim2 = new KullaniciYonetim(new EmailGonder()); 
        kullaniciYonetim2.BildirimGonder();

        KullaniciYonetim kullaniciYonetim3 = new KullaniciYonetim(new BildirimGonder());
    }
}
