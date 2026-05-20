namespace Ornek12_4_Ornekler;
internal class Program
{
    private static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();    
        ogrenci.NotIlan(1, 90);

        //ogrenci.NotIlanEvent += (dersId, not) =>
        //{
        //    Console.WriteLine($"Ders Id: {dersId}, Not: {not}");
        //};
        ogrenci.NotIlanEvent += notIlanOlayi;
        ogrenci.NotIlan(1, 90);

        ///lambda ifadesi ile kayıt silme olayına abone olma
        ///lambda ifadesi ile isimisiz bir metot oluşturup kayit silme olayına abone olduk
        ogrenci.KayitSilmeEvent += (ogrenciId) =>
        {
            Console.WriteLine("Kayıt silme olayı tetiklendi.");
        };
        
        ogrenci.KayitSil(5);
    }

    public static void notIlanOlayi(int i, int j) 
    {
      Console.WriteLine("ilan olayı tetiklendi. Ders Id: {i}, Not: {j}");
    }
}