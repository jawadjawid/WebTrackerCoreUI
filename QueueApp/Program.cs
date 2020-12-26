using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Newtonsoft.Json;

namespace QueueApp
{
    public class Program
    {
        static async Task Main(string[] args)
        {

        }

        public static int Run(string url, string email)
        {
            //Replace with the url of this https://github.com/jawadjawid/trackerAutomation function after running it locally(the port could be diff)
            string uri = $"http://localhost:7071/api/screenshot?url={url}&email={email}&modify=true";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            var responseReader = new StreamReader(webStream);
            var response = responseReader.ReadToEnd();
            Console.WriteLine("Response: " + response);
            responseReader.Close();
            return 0;
        }
    }
}
