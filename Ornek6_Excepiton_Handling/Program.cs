using Ornek6_Excepiton_Handling;

public class Program
{
    private static void Main(string[] args)
    {

        // BolmeIslemi(23, 0);
        try
        {
            int a = 10;
            int b = 0;
            //int sonuc = a / b; // Bu satır hata verecektir çünkü sıfıra bölme hatası oluşur

            int dogumTarihi = -1190;
            if (dogumTarihi < 0)
            {
                //throw new Exception("Doğum tarihi negatif olamaz."); // Özel bir hata mesajı ile istisna fırlatılır
                //Özel execption sınıfı oluşturup throw new DogumTarihiException("Doğum tarihi negatif olamaz."); şeklinde de kullanabiliriz
                throw new DogumTarihiException("dogum tarihi hatası fırlatıldı");
            }
        }
        catch(DogumTarihiException e)
        {
            Console.WriteLine("Doğum tarihi hatası yakalandı: " + e.Message.ToString());
        }
        catch (Exception e)
        {
            //Console.WriteLine("Bir hata oluştu: Sıfıra bölme hatası."); // Hata mesajı gösterilir
            Console.WriteLine(e.Message.ToString());
        }
        finally
        {
            Console.WriteLine("Program sonlandı."); // Bu blok her zaman çalışır, hata olsa da olmasa da
        }


        try
        {
            int sayi = int.Parse("45A");
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }


    public static void BolmeIslemi(int a, int b)
    {
        try
        {
            int sonuc = a / b; // Sıfıra bölme hatası oluşabilir
            Console.WriteLine($"Sonuç: {sonuc}");
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Hata: Dizi sınırının aşılması hatası."); // Hata mesajı gösterilir
            Console.WriteLine(e.Message.ToString());
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Hata: Sıfıra bölme hatası."); // Hata mesajı gösterilir
            Console.WriteLine(e.Message.ToString());
        }
        catch (Exception e)
        {
            Console.WriteLine("Hata: Sıfıra bölme hatası."); // Hata mesajı gösterilir
            Console.WriteLine(e.Message.ToString());
        }
        finally
        {
            Console.WriteLine("Bölme işlemi tamamlandı."); // Bu blok her zaman çalışır
        }
    }

    ///Hata olduğunda program çökmesin diye exception handling mekanizması kullanılırı
    ///Hata yakalamak ve işlemek için try-catch blokları kullanılır
    ///Böylece program çökmüyor ve kullanıcıya anlamlı bir hata mesajı gösterilebilir
    ///Bir cath bloğu tüm hatalar için tanımlanabilir veya spesifik hatalar için ayrı ayrı catch blokları oluşturulabilir
    ///NullReferenceExcepiton, IndexOutOfRangeException, DividedByZeroException gibi özel hata durumlarında çalışacak şekilde planlanabilir
    ///Kendimiz özel hata mesajları oluşturabiliriz ve kullanıcıya daha açıklayıcı bilgiler sunabiliriz
    ///Özel hata mesajı fırlatmak için throw anahtar kelimesi kullanılır ve bir Exception nesnesi oluşturulur
    ///throw new Exception("Özel hata mesajı"); şeklinde kullanılır
    ///Exception kullanılırıken yapılammaması gerekenler:
    ///Her şeyi execption ile yakalamak uygun olmayabilir, 
    ///bu nedenle spesifik hatalar için ayrı catch blokları oluşturmak daha iyi bir uygulamadır
    ///Boş catch blokları kullanmak, hataların nedenini anlamayı zorlaştırabilir 
    ///ve hataların doğru şekilde ele alınmasını engelleyebilir
    ///Hata yakalandığında mutlakta bir şeyler yapılmalı, örneğin hata mesajı gösterilmeli veya loglanmalı, aksi takdirde hataların nedenini anlamak zorlaşır
    ///Özel hata mesajlarımız varsa cath bloklarında önce özel hata mesayjları yakalanmalı, sonra genel hatalar yakalanmalıdır, aksi takdirde özel hata mesajları hiç yakalanamayabilir
    ///Uygulamadaki tüm hatalar GlobalException Handler ile yakalanabilir, 
    ///böylece uygulama çökmeden hatalar loglanabilir ve kullanıcıya anlamlı mesajlar gösterilebilir
    ///Böylece her yerde ayrı ayrı yazılan try-catch bloklarına gerek kalmaz ve hata yönetimi merkezi bir şekilde yapılabilir
}