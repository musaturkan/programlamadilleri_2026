using Ornek5_Delegate_Event_Library;

internal class Program
{
    delegate void temsilci();
    static void Selamlama()
    {
        Console.WriteLine("Merhaba, Dünya!");
    }   
    
    static void Yazdir() 
    {         
        Console.WriteLine("Bu bir delegate örneğidir.");
    }
    private static void Main(string[] args)
    {
        ///Delegate bir değişkene bir metodu atamamız sağlar.
        ///ilgili delegate türünden bir değişken oluşturulur ve bu değişkene bir metod atanır.
        temsilci a;        
        a = Selamlama;
        a();

        a = Yazdir;
        a();

        a = ()=> Console.WriteLine("Bu bir lambda ifadesidir.");

        a = ()=> 
                {
                    Console.WriteLine("Bu birden fazla satır içeren lambda ifadesidir.");
                    Console.WriteLine("Lambda ifadeleri anonim metotlar olarak da adlandırılır.");
                };

        Arac arac = new Arac { Marka = "Toyota", Model = "Corolla", Yil = 2020 };
        arac.HareketEvent += HareketOlayiMetodu;
        arac.YakitYuklemeBasliyorEvent += YakitYukmeleBaslamadanCalisanMetot;
        arac.YakitEkle(50);

        ///Action: Parametre alabilir ancak geriye değer döndürmez.
        ///Delegate türü oluşturmak yerine Action kullanarak daha kısa ve okunabilir kod yazabiliriz.
        Action<string> Yaz=(mesaj) => Console.WriteLine(mesaj);
        Yaz("Action delegate örneği.");        
        Action<int, int> Topla=(a,b) => Console.WriteLine($"Toplam: {a+b}");

        ///Func: Parametre alabilir ve geriye değer döndürebilir.
        ///Func ile belirtilen son parametre, metodun geri dönüş türünü temsil eder.
        Func<int, int, int> Carp=(a,b) => a*b;
        Carp(45, 58);
        arac.YakitEkle(30);
        OrnekMetot1((km) => Console.WriteLine($"Araç {km} km hareket etti."));
        OrnekMetot1(HareketOlayiMetodu);

        SiparisServis siparisServis = new SiparisServis();
        siparisServis.SiparisVerildiEvent += SmsGonder;
        siparisServis.SiparisVerildiEvent += EpostaGonder;

        siparisServis.SiparisVer("Yeni bir sipariş verildi.");

        siparisServis.SiparisVer("Başka bir sipariş verildi.");
    }

    public static void SmsGonder(string mesaj)
    {
        Console.WriteLine($"SMS gönderildi: {mesaj}");
    }

    public static void EpostaGonder(string mesaj)
    {
        Console.WriteLine($"E-posta gönderildi: {mesaj}");
    }

    private static void YakitYukmeleBaslamadanCalisanMetot(int litre)
    {
       Console.WriteLine($"Yakıt yükleme işlemi başlamadan önce {litre} litre yakıt ekleniyor.");
    }

    private static void OrnekMetot1(Action<int> d)
    {
        d(45);
    }

    static void HareketOlayiMetodu(int km)
    {
        Console.WriteLine($"Araç {km} km hareket etti.");
    }
}