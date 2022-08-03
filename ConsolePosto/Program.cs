using ConsolePosto.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ConsolePosto
{
    class Program
    {

        

        static async Task Main(string[] args)
        {
            HttpClient Client = new HttpClient { BaseAddress = new Uri("http://localhost:5000/api")  };
            var response = await Client.GetAsync("pedido");
            var content = await response.Content.ReadAsStringAsync();

            var pedido = JsonConvert.DeserializeObject<Pedido[]>(content);

            foreach (var item in pedido)
            {
                Console.WriteLine(item.ItensPedido);

                Console.WriteLine(item.ValorTotal);
            }

        }
    }
}
