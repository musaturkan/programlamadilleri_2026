// To fix CS0246, you need to add a reference to the ClosedXML NuGet package.
// Run the following command in your project directory:
// dotnet add package ClosedXML

using ClosedXML.Excel;

namespace Ornek10_2_excel_dosya_islemleri;
internal class Program
{
    private static void Main(string[] args)
    {
        ///Excel dosyaları, Microsoft Excel tarafından kullanılan bir elektronik tablo formatıdır.
        ///Excel ile çalışmak daha kullanıcı dostu ve görsel olarak daha zengin bir deneyim sunar, ancak Excel dosyalarıyla çalışmak için genellikle ek kütüphanelere ihtiyaç duyulur.
        ///Örneğin, EPPlus veya ClosedXML gibi kütüphaneler, Excel dosyalarını okumak ve yazmak için kullanılabilir.
        ///Raporlam, veri analizi ve diğer birçok senaryoda Excel dosyaları yaygın olarak kullanılır.

        ///Excel ile çalışırken aşağıdaki kütüphaneler tavsiye edilir:
        ///ClosedXML: Kullanımı kolay ve güçlü bir kütüphane olup, Excel dosyalarını oluşturmak, okumak ve düzenlemek için geniş özellikler sunar.
        ///EPPlus: Excel dosyalarını oluşturmak, okumak ve düzenlemek için kullanılan bir başka popüler kütüphanedir.
        ///EPPlus, Excelde grafik oluşturma, hücre stilleri, formüller ve diğer gelişmiş özellikler gibi birçok işlevi destekler.
        ExcelDosyasindanNotlariOkuma();
        
    }

    public static void ExcelDosyaOlusturma()
    {
        // ClosedXML kullanarak Excel dosyası oluşturma örneği
        var calismaKitabi= new ClosedXML.Excel.XLWorkbook();
        var calismaSayfasi = calismaKitabi.Worksheets.Add("Sayfa1");
        calismaSayfasi.Cell("A1").Value = "Merhaba";
        calismaSayfasi.Cell("A2").Value = "Dünya!";
        calismaSayfasi.Cell(2,3).Value = "Merhaba Dünya!";
        calismaKitabi.SaveAs("OrnekExcel.xlsx");

        //using (var workbook = new ClosedXML.Excel.XLWorkbook())
        //{
        //    var worksheet = workbook.Worksheets.Add("Sayfa1");
        //    worksheet.Cell("A1").Value = "Merhaba";
        //    worksheet.Cell("B1").Value = "Dünya!";
        //    workbook.SaveAs("OrnekExcel.xlsx");
        //}
    }

    public static void ListeyiExcelDosyasinaYazma()
    {
        var calismaKitabi = new ClosedXML.Excel.XLWorkbook();
        var calismaSayfasi = calismaKitabi.Worksheets.Add("Sayfa1");
        List<string> isimler = new List<string> { "Ahmet", "Mehmet", "Ayşe", "Fatma" };
        List<KullaniciDTO> kullanicilar = new List<KullaniciDTO>
        {
            new KullaniciDTO { Id = 1, Ad = "Ahmet", Soyad = "Yılmaz" },
            new KullaniciDTO { Id = 2, Ad = "Mehmet", Soyad = "Demir"},
            new KullaniciDTO { Id = 3, Ad = "Ayşe", Soyad = "Kara" },
            new KullaniciDTO { Id = 4, Ad = "Fatma", Soyad = "Çelik" }
        };

        for (int i = 0; i < kullanicilar.Count; i++)
        {            
            calismaSayfasi.Cell(i + 1, 1).Value = kullanicilar[i].Ad;
            calismaSayfasi.Cell(i + 1, 2).Value = kullanicilar[i].Soyad;
            calismaSayfasi.Cell(i + 1, 3).Value = kullanicilar[i].Id;
        }
        calismaKitabi.SaveAs("Isimler.xlsx");
    }

    public static void ExcelDosyasiOku()
    {
        var calismaKitabi = new ClosedXML.Excel.XLWorkbook("Isimler.xlsx");
        var calismaSayfasi = calismaKitabi.Worksheets.First();
        var kullanicilar = new List<KullaniciDTO>();

        for (int i = 1; i <= calismaSayfasi.LastRowUsed().RowNumber(); i++)
        {
            var kullanici = new KullaniciDTO
            {
                Ad = calismaSayfasi.Cell(i, 1).GetValue<string>(),
                Soyad = calismaSayfasi.Cell(i, 2).GetValue<string>(),
                Id = calismaSayfasi.Cell(i, 3).GetValue<int>()
            };
            kullanicilar.Add(kullanici);
        }
    }

    public static void HucreStilleri()
    {
        var calismaKitabi = new ClosedXML.Excel.XLWorkbook();
        var calismaSayfasi = calismaKitabi.Worksheets.Add("Sayfa1");
        var hucre = calismaSayfasi.Cell("A1");
        hucre.Value = "Merhaba Dünya!";
        hucre.Style.Font.Bold = true;
        hucre.Style.Font.FontColor = XLColor.Red;
        hucre.Style.Fill.BackgroundColor = XLColor.Yellow;
        calismaKitabi.SaveAs("StilOrnegi.xlsx");
    }

    public static void ExcelDosyaGuncelleme()
    {
        var calismaKitabi = new ClosedXML.Excel.XLWorkbook("Isimler.xlsx");
        var calismaSayfasi = calismaKitabi.Worksheets.First();
        calismaSayfasi.Cell(1, 1).Value = "Ahmet Güncellenmiş";
        calismaKitabi.SaveAs("GuncellenmisIsimler.xlsx");
    }

    public static void ExcelFormulleri()
    {
        var calismaKitabi = new ClosedXML.Excel.XLWorkbook();
        var calismaSayfasi = calismaKitabi.Worksheets.Add("Sayfa1");
        calismaSayfasi.Cell("A1").Value = 10;
        calismaSayfasi.Cell("A2").Value = 20;
        calismaSayfasi.Cell("A3").FormulaA1 = "=SUM(A1:A2)";
        calismaKitabi.SaveAs("FormulOrnegi.xlsx");
    }

    public static void ExcelDosyasindanNotlariOkuma()
    {
        var calismaKitabi = new ClosedXML.Excel.XLWorkbook("AraSinav.xlsx");
        var calismaSayfasi = calismaKitabi.Worksheets.First();
        var notlar = new List<double>();
        //for (int i = 2; i <= calismaSayfasi.LastRowUsed().RowNumber(); i++)
        for (int i = 2; i <= 5; i++)
        {
            var notDegeri = calismaSayfasi.Cell(i, 3).GetValue<double>();
            if (notDegeri>70)
            {
                calismaSayfasi.Cell(i, 3).Style.Fill.BackgroundColor = XLColor.Green;
            }
            else
            {
                calismaSayfasi.Cell(i, 3).Style.Fill.BackgroundColor = XLColor.Red;
            }
                notlar.Add(notDegeri);
        }

        calismaSayfasi.Cell("C6").FormulaA1 ="=SUM(C2:C5)";
        calismaSayfasi.Cell("C7").Value="Excele dosyasını güncelliyoruz";
        calismaKitabi.Save();

        calismaSayfasi.Cell("D7").IsEmpty();// Hücre boş mu kontrolü
        //calismaKitabi.SaveAs("AraSinavGuncellenmis.xlsx");
    }
}

public class KullaniciDTO {    
    public int Id { get; set; }
    public string? Ad { get; set; }
    public string? Soyad { get; set; }
    public string? Email { get; set; }
}