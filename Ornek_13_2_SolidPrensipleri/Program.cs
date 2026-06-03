internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
///Open-Closed Principle (OCP) açık-kapalı prensibi anlamına gelir. 
///Bu prensip, yazılım tasarımında önemli bir ilkedir ve kodun genişletilebilir olmasını sağlar. 
///OCP'ye göre, bir sınıf veya modül, mevcut kodu değiştirmeden yeni özellikler eklenmesine izin verecek 
///şekilde tasarlanmalıdır. 
///Bu sayede, mevcut kodun çalışması bozulmaz ve yeni özellikler eklemek daha kolay hale gelir.
///Gelişmeye açık, değişime kapalı kod yazılmalıdır.
///OCP'ye uymayan bir sınıfın örneği:
public class MaasHesaplama
{
    public double Hesapla(double maas, string calisanTipi)
    {
        if (calisanTipi == "yazilimci")
        {
            return maas * 1.2; // Yazılımcılar için %20 zam
        }
        else if (calisanTipi == "tasarimci")
        {
            return maas * 1.1; // Tasarımcılar için %10 zam
        }
        else if (calisanTipi=="eğitmen")
        {
            return maas * 1.15; // Eğitmenler için %15 zam
        }
        else
        {
            throw new ArgumentException("Geçersiz çalışan tipi");
        }
    }
    public double Hesapla(IMaasHesaplama maasHesaplama, double maas)
    {
        return maasHesaplama.Hesapla(maas);
    }

}
///Yukarıdaki sınıf, yeni bir çalışan tipi eklemek istediğimizde 
///mevcut kodu değiştirmemiz gerektiği için OCP'ye uymamaktadır.
///OCP'ye uyan bir sınıfın örneği:  
public interface IMaasHesaplama
{
    double Hesapla(double maas);
}
public class YazilimciMaasHesaplama : IMaasHesaplama
{
    public double Hesapla(double maas)
    {
        return maas * 1.2; // Yazılımcılar için %20 zam
    }
}
public class TasarimciMaasHesaplama : IMaasHesaplama
{
    public double Hesapla(double maas)
    {
        return maas * 1.1; // Tasarımcılar için %10 zam
    }
}
public class EgitmenMaasHesaplama : IMaasHesaplama
{
    public double Hesapla(double maas)
    {
        return maas * 1.15; // Eğitmenler için %15 zam
    }
}
///Yukarıdaki sınıflar, yeni bir çalışan tipi eklemek istediğimizde mevcut kodu değiştirmemize gerek kalmadan yeni bir sınıf oluşturarak OCP'ye uymaktadır.
///Bir hesaplama sınıfındaki bir değişiklik diğer hesaplama sınıflarını etkilemez. Yeni bir çalışan tipi eklemek istediğimizde, sadece yeni bir sınıf oluşturarak OCP'ye uymaktadır.
///