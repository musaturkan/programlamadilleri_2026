using DataModel;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //C# dilinde koleksiyonlar
        //Dizi ve koleksiyon farkı nedir?
        //Dizi: Sabit boyutlu, aynı türdeki verileri tutan
        //Koleksiyon: Dinamik boyutlu, farklı türdeki verileri tutabilen
        //Dizi tanımlama
        int[] sayilar= new int[5];
        int[] sayilar2= new int[]{1,2,3,4,5};
        //Koleksiyon tanımlama
        List<int> sayilar3= new List<int>();
        sayilar3.Add(1);
        sayilar3.Add(2);
        sayilar3.Add(3);
        sayilar3.Add(4);
        ///Veri sayısı belli değilse koleksiyon kullanmak daha avantajlıdır.
        ///Listedeki elemanlara ekleme, silme, güncelleme gibi işlemler yapmak daha kolaydır.
        ///Dinamik veri ekleme ve silme işlemi varsa koleksiyon kullanmak daha avantajlıdır.
        List<string> isimler= new List<string>();
        isimler.Add("Ahmet");
        isimler.Add("Mehmet");
        List<DataModel.Kullanici> kullaniciListe= new List<DataModel.Kullanici>();
            kullaniciListe.Add(new DataModel.Kullanici
            {
                Id=1,
                Ad="Ahmet",
                Soyad="Yılmaz",
                DogumTarihi=new DateTime(1990,1,1),
                KayitTarihi=DateTime.Now,
                KullaniciAdi="ahmet123",
                Parola="123456",
                Cinsiyet=true
            });
            kullaniciListe.Add(new DataModel.Kullanici
            {
                Id=2,
                Ad="Mehmet",
                Soyad="Yılmaz",
                DogumTarihi=new DateTime(1992,1,1),
                KayitTarihi=DateTime.Now,
                KullaniciAdi="mehmet123",
                Parola="123456",
                Cinsiyet=true
            });

        //List koleksiyonu Linq sorguları ile kullanılabilir.
        var secilenKullanici = kullaniciListe.Where(k=>k.Ad=="Ahmet").ToList();
        sayilar3.Remove(2);
        kullaniciListe.Remove(kullaniciListe.FirstOrDefault(k=>k.Id==1));
        isimler.Contains("Ahmet"); //true döner

        kullaniciListe[0].Ad="Ahmet Can"; //Güncelleme işlemi
        ///kullaniciListe.Add(45); //Hata verir çünkü List<Kullanici> türünde bir koleksiyon tanımladık.
        int elemenaSayiis = kullaniciListe.Count; //Koleksiyondaki eleman sayısını verir
        kullaniciListe.Count(p => p.Id > 10);
        kullaniciListe.Any(p => p.Id > 10); //Koleksiyonda Id'si 10'dan büyük eleman var mı?
        kullaniciListe.Clear(); //Koleksiyondaki tüm elemanları siler
        var kullaniciListe2 = new List<Kullanici>();
        kullaniciListe2.Add(new DataModel.Kullanici
        {
            Id=3,
            Ad="Ayşe",
            Soyad="Yılmaz",
            DogumTarihi=new DateTime(1995,1,1),
            KayitTarihi=DateTime.Now,
            KullaniciAdi="ayse123",
            Parola="123456",
            Cinsiyet=false
        });

        kullaniciListe.AddRange(kullaniciListe2); //Bir koleksiyonu diğerine ekler
        kullaniciListe.Max(m => m.DogumTarihi); //Koleksiyondaki en büyük doğum tarihini verir
        var sıraliListe = kullaniciListe.OrderBy(k => k.Ad).ToList(); //Koleksiyonu ada göre sıralar
        ///List koleksiyonu özellikleri
        /// - Dinamik boyutlu
        /// - Farklı türdeki verileri tutabilir
        /// - Eleman ekleme, silme, güncelleme işlemleri kolaydır
        /// - Linq sorguları ile kullanılabilir
        /// - Aynı veri türünden birden fazla eleman tutabilir
        /// - Performans açısından dizilere göre daha yavaştır
        /// - Sıralı şekilde verileri saklar, index ile erişilebilir
        /// - Generic yapısı sayesinde tür güvenliği sağlar
        /// 

        ///2. Dictionary koleksiyonu
        /// - Key-Value çiftleri şeklinde veri saklar
        /// - Key benzersiz olmalıdır
        /// - Value herhangi bir türde olabilir
        /// - Hızlı veri erişimi sağlar
        /// - Linq sorguları ile kullanılabilir
        Dictionary<int, string> kullaniciSozluk = new Dictionary<int, string>();
        kullaniciSozluk.Add(1, "Ahmet");
        kullaniciSozluk.Add(2, "Mehmet");
        kullaniciSozluk.Add(3, "Ayşe");
        ///kullaniciSozluk.Add(1, "Ali"); //Hata verir çünkü key benzersiz olmalıdır
        Console.WriteLine(kullaniciSozluk[2]);
        string isim = kullaniciSozluk.GetValueOrDefault(2); //Key'e karşılık gelen value'yu verir, key yoksa default değeri döner
        kullaniciSozluk.Remove(2); //Key'e karşılık gelen key-value çiftini siler
        kullaniciSozluk.ContainsKey(1); //true döner Sözlükte key değeri 1 olan kayıt var mı?
        kullaniciSozluk.ContainsValue("Ahmet"); //true döner. sözlükte value değeri Ahmet olan kayıt var mı?
        int elemanSayisi = kullaniciSozluk.Count; //Sözlükteki key-value çiftlerinin sayısını verir
        kullaniciSozluk.Where(p=>p.Key > 1).ToList(); //Key değeri 1'den büyük olan key-value çiftlerini verir
        kullaniciSozluk.Clear(); //Sözlükteki tüm key-value çiftlerini siler
        sayilar2.ToList().ForEach(s => Console.WriteLine(s)); //Dizideki elemanları ekrana yazdırır
        Dictionary<int, Kullanici> kullaniciSozluk2 = new Dictionary<int, Kullanici>();
        kullaniciSozluk2.Add(1, new DataModel.Kullanici
        {
            Id=1,
            Ad="Ahmet",
            Soyad="Yılmaz",
            DogumTarihi=new DateTime(1990,1,1),
            KayitTarihi=DateTime.Now,
            KullaniciAdi="ahmet123",
            Parola="123456",
            Cinsiyet=true
        });
         kullaniciSozluk2.Add(2, new DataModel.Kullanici
        {
            Id=2,
            Ad="Mehmet",
            Soyad="Yılmaz",
            DogumTarihi=new DateTime(1992,1,1),
            KayitTarihi=DateTime.Now,
            KullaniciAdi="mehmet123",
            Parola="123456",
            Cinsiyet=true
        });
         var secilenKullanici2 = kullaniciSozluk2.Where(k=>k.Value.Ad=="Ahmet").ToList();
         var secilenKullanici3 = kullaniciSozluk2.Where(k=>k.Key==1).ToList();
         var secilenKullanici4 = kullaniciSozluk2.GetValueOrDefault(1); //Key'e karşılık gelen value'yu verir, key yoksa default değeri döner
        ///Dictionary List Farklılığı
        /// - Dictionary key-value çiftleri şeklinde veri saklar, List ise sadece değerleri saklar
        /// - Dictionary'de key benzersiz olmalıdır, List'de aynı değer birden fazla kez bulunabilir
        /// - Dictionary'de hızlı veri erişimi sağlanır, List'de arama işlemleri daha yavaştır

        ///Queue Koleksiyonu - Kuyruk FIFO
        ///- Kuyruk yapısıdır, ilk giren ilk çıkar (FIFO) yapısında veri saklar
        /// - Enqueue ile eleman eklenir, Dequeue ile eleman çıkarılır
        /// - Peek ile kuyruğun başındaki eleman görüntülenir
        /// - Linq sorguları ile kullanılabilir
        /// - Performans açısından dizilere göre daha yavaştır
        /// - Sıralı şekilde verileri saklar, index ile erişilemez
        /// - İş sıralama sistemlerinde kullanılır
        /// - Verilere sıralı şekilde erişilebilir index ile erişilemez
        /// 
        Queue<string> isimKuyrugu = new Queue<string>();
        Queue<Kullanici> kullaniciKuyrugu = new Queue<Kullanici>();
        isimKuyrugu.Enqueue("Ahmet");
        isimKuyrugu.Enqueue("Mehmet");
        isimKuyrugu.Enqueue("Ayşe");
        kullaniciKuyrugu.Enqueue(new DataModel.Kullanici
        {
            Id=1,
            Ad="Ahmet",
            Soyad="Yılmaz",
            DogumTarihi=new DateTime(1990,1,1),
            KayitTarihi=DateTime.Now,
            KullaniciAdi="ahmet123",
            Parola="123456",
            Cinsiyet=true
        });
        var siradakiIsim = isimKuyrugu.Dequeue(); //Kuyruğun başındaki elemanı çıkarır ve döner
        var siradakiKullanici = kullaniciKuyrugu.Dequeue(); //Kuyruğun başındaki elemanı çıkarır ve döner
        var siradakiIsim2 = isimKuyrugu.Peek(); //Kuyruğun başındaki elemanı görüntüler, kuyruğu değiştirmez

        ///Stack Koleksiyonu - Yığın LIFO Son giren ilk çıkar mantığı ile çalışır
        /// - Yığın yapısıdır, son giren ilk çıkar (LIFO) yapısında veri saklar
        /// - Push ile eleman eklenir, Pop ile eleman çıkarılır
        /// - Peek ile yığının tepesindeki eleman görüntülenir
        /// - Linq sorguları ile kullanılabilir
        /// - Performans açısından dizilere göre daha yavaştır
        /// - Sıralı şekilde verileri saklar, index ile erişilemez
        /// - İşlem geçmişi, geri alma işlemleri gibi durumlarda kullanılır
        /// 
        Stack<string> isimYigini = new Stack<string>();
        Stack<Kullanici> kullaniciYigini = new Stack<Kullanici>();
        isimYigini.Push("Ahmet");
        isimYigini.Push("Mehmet");
        isimYigini.Push("Ayşe");
        kullaniciYigini.Push(new DataModel.Kullanici
        {
            Id=1,
            Ad="Ahmet",
            Soyad="Yılmaz",
            DogumTarihi=new DateTime(1990,1,1),
            KayitTarihi=DateTime.Now,
            KullaniciAdi="ahmet123",
            Parola="123456",
            Cinsiyet=true
        });
        var sonIsim = isimYigini.Pop(); //Yığının tepesindeki elemanı çıkarır ve döner
        var sonKullanici = kullaniciYigini.Pop(); //Yığının tepesindeki elemanı çıkarır ve döner
        var sonIsim2 = isimYigini.Peek(); //Yığının tepesindeki elemanı görüntüler, yığını değiştirmez


        ///HashSet Koleksiyonu - Benzersiz elemanlar kümesi
        /// - HashSet, benzersiz elemanlar kümesi sağlar
        /// - Eleman eklemek için Add, silmek için Remove kullanılır
        /// - Contains ile elemanın varlığı kontrol edilir
        /// - Linq sorguları ile kullanılabilir
        /// - Performans açısından dizilere göre daha hızlıdır
        /// - Sıralı şekilde verileri saklamaz, index ile erişilemez
        /// - HasSet koleksiyonunda veriler hash kodlarına göre saklanır, bu nedenle sıralı değildir
        HashSet<string> isimKumesi = new HashSet<string>();
        HashSet<string> isimKumesi2 = new HashSet<string>(){"Ahmet","Mehmet","Ali","Emine","Feride"};
        HashSet<Kullanici> kullaniciKumesi = new HashSet<Kullanici>();
        isimKumesi.Add("Ahmet");
        isimKumesi.Add("Mehmet");
        isimKumesi.Add("Ayşe");
        kullaniciKumesi.Add(new DataModel.Kullanici
        {
            Id=1,
            Ad="Ahmet",
            Soyad="Yılmaz",
            DogumTarihi=new DateTime(1990,1,1),
            KayitTarihi=DateTime.Now,
            KullaniciAdi="ahmet123",
            Parola="123456",
            Cinsiyet=true
        });
            kullaniciKumesi.Add(new DataModel.Kullanici
            {
                Id=2,
                Ad="Mehmet",
                Soyad="Yılmaz",
                DogumTarihi=new DateTime(1992,1,1),
                KayitTarihi=DateTime.Now,
                KullaniciAdi="mehmet123",
                Parola="123456",
                Cinsiyet=true
            });

        isimKumesi.Contains("Ahmet"); //true döner
        isimKumesi.Remove("Ahmet"); //Kümeden "Ahmet" elemanını siler
        int kumeElemanSayisi =  isimKumesi.Count; //Kümedeki eleman sayısını verir
        var secilenKullanici5 = kullaniciKumesi.Where(k=>k.Ad=="Ahmet").ToList();
        kullaniciKumesi.RemoveWhere(k=>k.Ad=="Ahmet"); //Ad'ı "Ahmet" olan kullanıcıları kümeden siler
        isimKumesi.IntersectWith(isimKumesi2); //isimKumesi kümesi ile isimKumesi2 kümesinin kesişimini alır, yani her iki kümede de bulunan elemanları isimKumesi kümesine atar
        
        ///HashSet List Farklılığı
        /// - HashSet, benzersiz elemanlar kümesi sağlar, List ise sıralı bir koleksiyondur
        /// - HashSet, eleman ekleme ve silme işlemlerinde daha hızlıdır, List ise sıralı erişim sağlar
        /// - HashSet, elemanların sırasını korumaz, List ise ekleme sırasını korur
        /// 
        //Koleksiyonların generic yapıda kullanımı
        ArrayList arrayList = new ArrayList();
        arrayList.Add(1);
        arrayList.Add("Ahmet");
        arrayList.Add(new DataModel.Kullanici
        {
            Id=1,
            Ad="Ahmet",
            Soyad="Yılmaz",
            DogumTarihi=new DateTime(1990,1,1),
            KayitTarihi=DateTime.Now,
            KullaniciAdi="ahmet123",
            Parola="123456",
            Cinsiyet=true
        });

        List<int> genericList = new List<int>();
        genericList.Add(1);
        ///genericList.Add("Ahmet"); //Hata verir çünkü List<int> türünde bir koleksiyon tanımladık, sadece int türünde eleman ekleyebiliriz)

        ///Hangi koleksiyon ne zaman kullanılır?
        /// - Veri sayısı belli değilse koleksiyon kullanmak daha avantajlıdır.
        /// - Elemanların benzersiz olması gerekiyorsa HashSet kullanılır.
        /// - Elemanların sıralı bir şekilde saklanması gerekiyorsa List kullanılır.    
        /// - Elemanlara hızlı erişim gerekiyorsa Dictionary kullanılır.
        /// - Elemanların benzersiz olması gerekiyorsa HashSet kullanılır.
        /// - İş sıralama sistemlerinde Queue kullanılır.
        /// - İşlem geçmişi, geri alma işlemleri gibi durumlarda Stack kullanılır.
        /// - Son eklene ilk çıkar mantığıyla çalışması gereken durumlarda Stack kullanılır.
    }
}

public class Ogrenci
{
    public int Id { get; set; }
    public override bool Equals(object? obj)
    {      
        return obj is Ogrenci ogrenci && Id == ogrenci.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}