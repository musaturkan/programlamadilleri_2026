internal class Program
{
    private static void Main(string[] args)
    {
       KullaniciYonetimA kullaniciYonetim = new KullaniciYonetimA(new MailGonderA("Merhaba!"));

    }
}

///Dependency Inversion Principle (DIP) - Bağımlılıkların Tersine Çevrilmesi Prensibi
///Üst seviye sınıflar alt seviye sınıflara bağımlı olmamalıdır. Her ikisi de soyutlamalara bağımlı olmalıdır.
///DIP'ye uygun olmayan sınıf:
public class  MailGonder
{
    //public MailGonder(string metin)
    //{
    //    // Mail gönderme işlemi için gerekli olan kaynakları başlatma kodu burada olabilir.
    //}
    public void Gonder()
    {
         Console.WriteLine("Mail gönderiliyor.");
    }
}

public class KullaniciYonetim
{
    private MailGonder _mailGonder;
    public KullaniciYonetim()
    {
        _mailGonder = new MailGonder();
    }
    public void KullaniciEkle()
    {
        Console.WriteLine("Kullanıcı ekleniyor.");
        _mailGonder.Gonder();
    }
}

///Yukarıdaki örnekte, KullaniciYonetim sınıfı MailGonder sınıfına doğrudan bağımlıdır.
///MailGonder sınıfında yapılan herhangi bir değişiklik, KullaniciYonetim sınıfını da etkileyebilir.
///Mesela MailGonder sınıfının yapıcı metodunu değiştirmek, KullaniciYonetim sınıfında da değişiklik yapmayı gerektirebilir.
///bu durum bakımı ve genişletmeyi zorlaştırır. 
///DIP'ye uygun sınıflar:
public interface IMailGonder
{
    void Gonder();
}

public class MailGonderA : IMailGonder
{
    public MailGonderA(string metin)
    {
        // Mail gönderme işlemi için gerekli olan kaynakları başlatma kodu burada olabilir.
    }
    public void Gonder()
    {
        Console.WriteLine("Mail gönderiliyor.");
    }
}

public class KullaniciYonetimA
{
    private IMailGonder _mailGonder;
    public KullaniciYonetimA(IMailGonder mailGonder)
    {
        _mailGonder = mailGonder;
    }
    public void KullaniciEkle()
    {
        Console.WriteLine("Kullanıcı ekleniyor.");
        _mailGonder.Gonder();
    }
}

///Yukarıdaki örnekte, ///KullaniciYonetimA sınıfı IMailGonder arayüzüne bağımlıdır 
///ve MailGonderA sınıfı bu arayüzü uygular.
///Böyelce MailGonderA sınıfında yapılan herhangi bir değişiklik, KullaniciYonetimA sınıfını etkilemez,