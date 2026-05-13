using Ornek11_AsenkronProgramlama2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Ornek11_AsenkronProgramlama2
{
    /// <summary>
    /// Örnek bir web servis çağrısı simülasyonu için ServisApi sınıfı oluşturulabilir.
    /// </summary>
    public class ServisApi
    {
        /// <summary>
        /// Örnek bir api ile json api çağrısı simülasyonu yaparak veri getirme işlemi gerçekleştirebiliriz.
        /// </summary>
        /// <returns></returns>
        public async Task<Gonderi> VeriGetirAsync(int id)
        {
            string apiUrl = $"https://jsonplaceholder.typicode.com/posts/{id}";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(apiUrl);
                    Gonderi gonderi = JsonSerializer.Deserialize<Gonderi>(response);
                    return gonderi;
                  
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                    return null;
                }
            }

        }

        public async Task<string> UserGetirAsync(int id)
        {
            string apiUrl = $"https://jsonplaceholder.typicode.com/users/{id}";
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(apiUrl);
                   
                    return response;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Hata: {ex.Message}");
                    return null;
                }
            }


        }
    }
}
