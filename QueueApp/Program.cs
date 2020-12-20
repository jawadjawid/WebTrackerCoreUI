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
            //string connectionString = Environment.GetEnvironmentVariable("AZURE_STORAGE_CONNECTION_STRING");
            //string connectionString = "DefaultEndpointsProtocol=https;AccountName=webpagetracker;AccountKey=/g6DvEgYEzxD1Ajd+875jXC4Z3fkxFEz+SZciP8vL/ZzM1OKpaZWlFPbA+noTVqBAZfq1J+rslElSuJcrp87aQ==;EndpointSuffix=core.windows.net";
            //QueueClient queue = new QueueClient(connectionString, "webpagetracker");

            //if (args.Length > 0)
            //{
            //    string value = String.Join(" ", args);
            //    await InsertMessageAsync(queue, value);
            //    Console.WriteLine($"Sent: {value}");
            //}
            //else
            //{
            //    string value = await RetrieveNextMessageAsync(queue);
            //    Console.WriteLine($"Received: {value}");
            //}

            //Console.Write("Press Enter...");
            //Console.ReadLine();
        }

        //public static async Task InsertMessageAsync(QueueClient theQueue, string newMessage)
        //{
        //    if (null != await theQueue.CreateIfNotExistsAsync())
        //    {
        //        Console.WriteLine("The queue was created.");
        //    }

        //    var plainText = JsonConvert.SerializeObject(newMessage);

        //    //await theQueue.SendMessageAsync(newMessage);
        //    await theQueue.SendMessageAsync(Base64Encode(plainText));

        //}

        //private static string Base64Encode(string plainText)
        //{
        //    var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
        //    return System.Convert.ToBase64String(plainTextBytes);
        //}

        //public static async Task<string> RetrieveNextMessageAsync(QueueClient theQueue)
        //{
        //    if (await theQueue.ExistsAsync())
        //    {
        //        QueueProperties properties = await theQueue.GetPropertiesAsync();

        //        if (properties.ApproximateMessagesCount > 0)
        //        {
        //            QueueMessage[] retrievedMessage = await theQueue.ReceiveMessagesAsync(1);
        //            string theMessage = retrievedMessage[0].MessageText;
        //            await theQueue.DeleteMessageAsync(retrievedMessage[0].MessageId, retrievedMessage[0].PopReceipt);
        //            return theMessage;
        //        }
        //        else
        //        {
        //            Console.Write("The queue is empty. Attempt to delete it? (Y/N) ");
        //            string response = Console.ReadLine();

        //            if (response.ToUpper() == "Y")
        //            {
        //                await theQueue.DeleteIfExistsAsync();
        //                return "The queue was deleted.";
        //            }
        //            else
        //            {
        //                return "The queue was not deleted.";
        //            }
        //        }
        //    }
        //    else
        //    {
        //        return "The queue does not exist. Add a message to the command line to create the queue and store the message.";
        //    }
        //}

        public static void Run(string url, string email)
        {
            string uri = $"https://nodetracker.azurewebsites.net/api/screenshot?url={url}&email={email}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();
            var responseReader = new StreamReader(webStream);
            var response = responseReader.ReadToEnd();
            Console.WriteLine("Response: " + response);
            responseReader.Close();
        }
    }
}