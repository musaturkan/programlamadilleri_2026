namespace Ornek13_1_SolidPrensipleri;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

///Signle respensibilty principle (SRP) tek sorumluluk prensibi anlamına gelir. Bir sınıfın sadece bir sorumluluğu olması gerektiğini ifade eder. Bu prensip, yazılım tasarımında önemli bir ilkedir ve kodun daha okunabilir, bakımı kolay ve genişletilebilir olmasını sağlar. SRP'ye göre, bir sınıfın sadece bir nedeni olmalıdır ve bu neden, sınıfın tek bir sorumluluğunu yerine getirmesidir. Bu sayede, sınıfın değişiklik yapma ihtiyacı olduğunda, sadece o sorumluluğa odaklanarak değişiklik yapılabilir ve diğer sorumluluklara zarar verme riski azalır.
///Bir sınıf hem rapor almak hem de veri kaydetmek gibi birden fazla sorumluluğa sahipse,
///bu sınıfın SRP'ye uymadığı söylenebilir. 
///Bu durumda, rapor alma işlemi için ayrı bir sınıf ve veri kaydetme işlemi için ayrı bir sınıf oluşturmak daha uygun olabilir. Böylece, her sınıfın tek bir sorumluluğu olur ve kod daha düzenli ve bakımı kolay hale gelir.
///
///SRP'ye uymayan bir sınıfın örneği:
public class  Personel
{
    public void Kaydet()
    {
        // Personel bilgilerini kaydetme işlemi
    }
    public void RaporAl()
    {
        // Personel raporu alma işlemi
    }
    public void MailGonder() 
    {

    }
}

///SRP'ye uyan bir sınıfın örneği:
public class PersonelRepo
{
    public void Kaydet()
    {
        // Personel bilgilerini kaydetme işlemi
    }
}
public class PersonelRapor
{
    public void RaporAl()
    {
        // Personel raporu alma işlemi
    }
}

public class MailGonderici
{
    public void MailGonder()
    {
        // Mail gönderme işlemi
    }
}

