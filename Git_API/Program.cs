using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Json;
using Newtonsoft.Json;


namespace Git_API
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, insert github username: ");
            var username = Console.ReadLine();
            string client_ID = "8d3f4863d00401a49bd2";
            string client_secret = "a8a8786dc0aa8538f951aa1e18f61d48cdb436c2";
            var repos_count = 10;
            string repos_sort = "created: asc";
            

            string apiUrl = "https://api.github.com/users/";

            string gitHubUrl = apiUrl + username + "?client_id=" + client_ID + "&client_secret=" + client_secret;
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(gitHubUrl);
            request.Method = "GET";
            request.UserAgent = "foo";





            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                GitHub gInfo = JsonConvert.DeserializeObject<GitHub>(response);
                Console.WriteLine($"Kasutajanimi: {gInfo.login}");
                Console.WriteLine($"Kasutaja ID: {gInfo.id}");
                Console.WriteLine($"Kasutaja URL: {gInfo.html_url}");
                Console.WriteLine($"Kasutaja e-mail: {gInfo.email}");
                Console.WriteLine($"Kasutaja repod: {gInfo.public_repos}");
                Console.WriteLine($"Kasutaja jälgijad: {gInfo.follorwers}");
                Console.WriteLine($"Kasutaja jälgib: {gInfo.following}");
                Console.WriteLine($"Otselink APIle: {gitHubUrl}");
            }
        }
       

    }
}

