using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;
using System.Net.Http;
using System.IO;
using NewsAPI;
using NewsAPI.Models;
using NewsAPI.Constants;
using System.Net;

namespace test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        string TOKEN = "628a7a9721c830d14da532b8fed95b19";
        string url = "https://gnews.io/api/v4/";  

        /*[HttpGet]
        public ActionResult<ItemNews[]> Get()
        {
            List<ItemNews> Details = new List<ItemNews>();
            var client = new HttpClient();
                var newsApiClient = new NewsApiClient("d64a688d2f3d437d86ae524e234e8c5c");
                var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
                {
                   Q = "Apple",
                    SortBy = SortBys.Popularity,
                    Language = Languages.EN,
                    From = new DateTime(2022, 4, 25)
                });
                if (articlesResponse.Status == Statuses.Ok)
                {
                    // total results found
                    Console.WriteLine(articlesResponse.TotalResults);
                    // here's the first 20
                    foreach (var article in articlesResponse.Articles)
                    {
                        ItemNews DataObj = new ItemNews();
                        DataObj.title = article.Title;
                        DataObj.content = article.Content;
                        DataObj.description = article.Description;
                        DataObj.url = article.Url;
                        DataObj.publishedAt = article.PublishedAt;
                        Details.Add(DataObj);
                }
                }
            
            return Details.ToArray();
        }
        //Define Class to return news data  
        public class ItemNews
        {
            public string title { get; set; }
            public string description { get; set; }
            public string content { get; set; }
            public string url { get; set; }
            public DateTime? publishedAt { get; set; }
        }*/

        [HttpGet]
        public ActionResult<string> Get()
        {

            WebRequest request = HttpWebRequest.Create(url + $"top-headlines?&token={TOKEN}");

            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string responseText = reader.ReadToEnd();


            return responseText;
        }

        [HttpGet("search/{q}")]
        public ActionResult<string> Get(string q)
        {

            WebRequest request = HttpWebRequest.Create(url + $"search?q={q}&token={TOKEN}");

            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string responseText = reader.ReadToEnd();  

            return responseText;
        }

        [HttpGet("max/{max}")]
        public ActionResult<string> Get(int max)
        {

            WebRequest request = HttpWebRequest.Create(url + $"top-headlines?max={max}&token={TOKEN}");

            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());

            string responseText = reader.ReadToEnd();

            return responseText;
        }
    }
}