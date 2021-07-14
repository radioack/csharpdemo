using System;
using System.IO;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebAPIClient
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static async Task Main(string[] args)
        {
            await WriteLatestXkcd();
        }

        private static async Task WriteLatestXkcd()
        {
            var response = await client.GetStringAsync("https://xkcd.com/info.0.json");

            //Console.Write(response);

            //var xkcdObj = JsonSerializer.Deserialize<XkcdObject>(response);
            //Console.WriteLine(xkcdObj.img);

            //var imageWeWant = await client.GetByteArrayAsync(xkcdObj.img);
            //System.Console.WriteLine(imageWeWant);
            //File.WriteAllBytes("./myXkcdImage.png", imageWeWant);

        }
    }
}
