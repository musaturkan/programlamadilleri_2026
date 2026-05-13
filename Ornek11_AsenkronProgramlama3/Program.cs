// See https://aka.ms/new-console-template for more information



using Ornek11_AsenkronProgramlama3;

///Aşağıdaki servisleri kullanan bir sınıf ve altındaki asenkron metotları yazınız
///Tek bir görev verisini döndüren adres:https://jsonplaceholder.typicode.com/todos/50
///Tüm görevleri döndüren api:https://jsonplaceholder.typicode.com/todos
///Sınıf altında tam sayı parametresi ile çalışan asenkron bir metot olacaktır.
///Bu metot servisten tek bir görevi çekip bilgilerini gösterecektir.
///Tüm görevleri döndüren metot parametresiz olacaktır
///Servisten gelen tüm görevleri liste olarak döndürecktir.
GorevApi api=new GorevApi();
Task<GorevDTO> gorev = api.GorevGetir(125);
Task<List<GorevDTO>> liste = api.GorevListesi();
Task.WaitAll(gorev, liste);

Console.WriteLine($"Gorev başlık:{gorev.Result.title}");

var todosListesi = await liste;
foreach (var yapilanIs in todosListesi)
{
    Console.WriteLine($"Görev id:{yapilanIs.id} KullanıcıId:{yapilanIs.userId} İş başlığı: {yapilanIs.title} Bitirildi mi:{yapilanIs.compledet}");
}
