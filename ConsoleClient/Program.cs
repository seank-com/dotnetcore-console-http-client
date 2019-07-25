using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static async Task Doit()
        {

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.PostAsync("http://localhost:8080/data/", new StringContent(
                "{\"key\": \"value\"}", Encoding.UTF8, "application/json"));

            string content = await response.Content.ReadAsStringAsync();
            Console.WriteLine("{0} {1}", response.StatusCode, content);
        }

        static void Main(string[] args)
        {
            Doit().Wait();
        }
    }
}