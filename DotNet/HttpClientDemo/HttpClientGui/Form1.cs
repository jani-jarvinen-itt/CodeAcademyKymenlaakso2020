using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpClientGui
{
    public partial class Form1 : Form
    {
        private static HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Album> albumit = LuetAlbumit();
            string tulos = LajitteleJaTulosta(albumit);
            textBox1.Text = tulos;
        }

        private static string LajitteleJaTulosta(List<Album> albumit)
        {
            // lajitellaan nimet
            List<string> nimet = new List<string>();
            foreach (Album albumi in albumit)
            {
                nimet.Add(albumi.title);
            }
            nimet.Sort();

            // tulostus
            string tulos = "";
            foreach (string nimi in nimet)
            {
                tulos += nimi + "\r\n";
            }

            return tulos;
        }

        private static List<Album> LuetAlbumit()
        {
            // alustukset
            string url = "http://jsonplaceholder.typicode.com/albums";

            // tehdään HTTP-pyyntö
            HttpResponseMessage response = client.GetAsync(url).Result;
            string json = response.Content.ReadAsStringAsync().Result;
            // Console.WriteLine(json);

            // muunnetaan JSON-data olioksi
            List<Album> albumit = JsonConvert.DeserializeObject<List<Album>>(json);
            return albumit;
        }
    }
}
