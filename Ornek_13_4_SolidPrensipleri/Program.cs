namespace Ornek_13_4_SolidPrenispleri;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

///Interface Segregation Principle (ISP) - Arayüz Ayrımı Prensibi
///Sınıflar , kullanmadıkları arayüzlere bağımlı olmamalıdır.
///Sınflar sadece ihtiyaç duydurkları metotları uygulamalıdır.
///Sınfın ihtiyacı olan metodu uygumak zorunda kalması, o sınıfın gereksiz yere karmaşıklaşmasına neden olur.
///Bu prensip, kodun daha esnek ve bakımı kolay olmasını sağlar.
///ISP'yu uygun olmayan sınıf:
public interface ICalisan
    {
    void Calis();
    void RaporHazirla();
    void Uc();
}

public class Muhendis : ICalisan
{
    public void Calis()
    {
        Console.WriteLine("Mühendis çalışıyor.");
    }
    public void RaporHazirla()
    {
        Console.WriteLine("Mühendis rapor hazırlıyor.");
    }
    public void Uc()
    {
        // Mühendis uçmaz, bu metot gereksiz ve uygunsuzdur.
        throw new NotImplementedException();
    }
}

public class Pilot : ICalisan
{
    public void Calis()
    {
        Console.WriteLine("Pilot çalışıyor.");
    }
    public void RaporHazirla()
    {
        Console.WriteLine("Pilot rapor hazırlıyor.");
    }
    public void Uc()
    {
        Console.WriteLine("Pilot uçuyor.");
    }
}

///ISP'ye göre, Muhendis sınıfı sadece Calis ve RaporHazirla metotlarını içermelidir, 
///Uc metodu ise Pilot sınıfında yer almalıdır. Bu şekilde, 
///her sınıf sadece ihtiyaç duyduğu metotları uygulayarak daha temiz ve bakımı kolay bir kod yapısı oluşturur.
///ISP'ye uygun sınıflar:
public interface ICalisanA
{
    void Calis();
    void RaporHazirla();
}

public interface IUcabilir
{
    void Uc();
}

public class MuhendisA : ICalisanA
{
    public void Calis()
    {
        Console.WriteLine("Mühendis çalışıyor.");
    }
    public void RaporHazirla()
    {
        Console.WriteLine("Mühendis rapor hazırlıyor.");
    }
}

public class PilotA : ICalisanA, IUcabilir
{
    public void Calis()
    {
        Console.WriteLine("Pilot çalışıyor.");
    }
    public void RaporHazirla()
    {
        Console.WriteLine("Pilot rapor hazırlıyor.");
    }
    public void Uc()
    {
        Console.WriteLine("Pilot uçuyor.");
    }
}

///Intefaceler tanımlanırken, her bir arayüzün tek bir sorumluluğa sahip olması önemlidir.
///Alakasız metotlar aynı interface içinde yer almamalıdır. 
///Bu, sınıfların sadece ihtiyaç duydukları metotları uygulamalarını sağlar ve kodun daha esnek ve bakımı kolay olmasına yardımcı olur.