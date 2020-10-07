using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // alustukset
            string url = "http://jsonplaceholder.typicode.com/albums";
            HttpClient client = new HttpClient();

            // tehdään HTTP-pyyntö
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            // Console.WriteLine(json);

            // muunnetaan JSON-data olioksi
            List<Album> albumit = JsonConvert.DeserializeObject<List<Album>>(json);

            // lajitellaan nimet
            List<string> nimet = new List<string>();
            foreach (Album albumi in albumit)
            {
                nimet.Add(albumi.title);
            }
            nimet.Sort();

            // tulostus
            foreach (string nimi in nimet)
            {
                Console.WriteLine(nimi);
            }

            // client.Dispose();
            Console.ReadLine();
        }
    }
}
