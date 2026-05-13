using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Ornek11_AsenkronProgramlama3
{
    public class GorevApi
    {
        public async Task<GorevDTO> GorevGetir(int gorevId)
        {
            GorevDTO gorev=new GorevDTO();
            ///servis çağrısı yapmak için gerekli kodalrı yazıyoruz
            HttpClient client = new HttpClient();
            string servisUrl = $"https://jsonplaceholder.typicode.com/todos/{gorevId}";
            var jsonVeri =  await client.GetStringAsync(servisUrl);
            
            gorev  = JsonSerializer.Deserialize<GorevDTO>(jsonVeri);

            return gorev;
        }

        public async Task<List<GorevDTO>> GorevListesi()
        {
            List<GorevDTO> liste = new List<GorevDTO>();
            HttpClient client = new HttpClient();
            string servisUrl = "https://jsonplaceholder.typicode.com/todos";
            string jsonListe = await client.GetStringAsync(servisUrl);
            liste = JsonSerializer.Deserialize<List<GorevDTO>>(jsonListe);
            return liste;
        }
    }
}
