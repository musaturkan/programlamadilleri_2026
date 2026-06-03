using Ornek_13_3_SolidPrensipleri;

namespace Ornek_13_13_SolidPrenispleri;
internal class Program
{
    private static void Main(string[] args)
    {
        Kus kus = new Serce();
        kus.Uc();

        SerceA serceA = new SerceA();
        serceA.Uc();

        KusA kusA = new KartalA();
        ((IUcabilir)kusA).Uc();
        
        kusA = new SerceA();
        ((IUcabilir)kusA).Uc();
        kusA = new Penguen();
        

        //Serce s = new Kartal();
        //s.Uc();
        //Serce serce = new Kus();
        // Hata: Kus sınıfı Serce sınıfının yerine geçemez
        TestMetot(new Diktortgen());
        TestMetot(new Kare());

    }


    public static void TestMetot(Diktortgen diktortgen)
    {
        diktortgen.Genislik = 5;
        diktortgen.Yukseklik = 10;
        int alan = diktortgen.Genislik * diktortgen.Yukseklik;
        Console.WriteLine($"Dikdörtgenin alanı: {alan}");
    }

}
///Liskov Substitution Principle (LSP) - Liskov Yerine Geçme Prensibi
///Türeyen sınıfın nesneleri, türetildiği sınıfın nesneleriyle yer değiştirebiliyorsa, 
///o zaman türeyen sınıfın nesneleri de türetildiği sınıfın nesneleriyle yer değiştirebilir. 
///Yani, bir sınıfın alt sınıfları, üst sınıfının yerine geçebilmeli ve aynı şekilde çalışmalıdır. 
///Bu prensip, kodun daha esnek ve genişletilebilir olmasını sağlar.
public class Kus {     
    public virtual void Uc()
    {
        Console.WriteLine("Kuş uçuyor.");
    }
}

public class Serce : Kus
{
    public override void Uc()
    {
        Console.WriteLine("Serçe uçuyor.");
    }
}

public class Penguen1 : Kus
{
    public override void Uc()
    {
        Console.WriteLine("Penguen uçamaz.");
    }
}



// LSP'ye göre, Serce ve Kartal sınıfları Kus sınıfının yerine geçebilir ve aynı şekilde çalışmalıdır.

public abstract class  KusA
{
    
}

public interface IUcabilir
{
    void Uc();
}
public class Penguen : KusA
{
 
}

public class SerceA : KusA, IUcabilir
{
    public void Uc()
    {
        Console.WriteLine("Serçe uçtu");
    }
}

public class KartalA : KusA, IUcabilir
{
    public void Uc()
    {
        Console.WriteLine("Kartal uçtu");
    }
}

///Penguen sınıfı uç metoduna sahip olmaması gerekir. Eğer tüm sınıflar aynı Kus sınıfından türetilirse,
///Penguen sınıfı da uçmak zorunda kalır ve bu da LSP'ye aykırıdır.
///Penguen sınıfının uçmak zorunda kalmaması için, uçma yeteneği olan sınıflar için 
///ayrı bir arayüz (interface) oluşturulabilir 
///ve sadece uçabilen sınıflar bu arayüzü uygulayabilir.
///
///Bir kamyonu bir araba yerine kullabiliriz, çünkü her ikisi de bir taşıt türüdür ve benzer işlevlere sahiptir.
///Ancak bir uçak bir araba yerine kullanılamaz, 
///çünkü uçak farklı bir taşıt türüdür ve farklı işlevlere sahiptir.
