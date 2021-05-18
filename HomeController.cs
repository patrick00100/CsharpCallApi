using Newtonsoft.Json;
using RestSharp;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            string url = String.Format("https://evostage.klonostek.com/api/ecashier?cCode=RWA&ecID=5yc9cpedniwiml1z&euID=patrick1234&output=1");
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "Get";
            HttpWebResponse respondObject = null;
            respondObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = respondObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                ViewBag.result = strresulttest.ToList();
                sr.Close();
            }
            return View(strresulttest);
            //    IEnumerable<RwaModel> rwa = null;

            //    using (var client = new HttpClient())
            //    {
            //        client.BaseAddress = new Uri("https://evostage.klonostek.com/api/ecashier?cCode=RWA&ecID=5yc9cpedniwiml1z&euID=patrick1234&output=1");
            //        client.DefaultRequestHeaders.Accept.Clear();
            //        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Intergration");
            //        //HTTP GET
            //        var respondTask = client.GetAsync("rwa");
            //        respondTask.Wait();

            //        var result = respondTask.Result;
            //        if (result.IsSuccessStatusCode)
            //        {
            //            var readTask = result.Content.ReadAsAsync<IList<RwaModel>>();
            //            readTask.Wait();

            //            rwa = readTask.Result;
            //        }
            //        else
            //        {
            //            rwa = Enumerable.Empty<RwaModel>();
            //            ModelState.AddModelError(string.Empty, "Server Error");
            //        }
            //    }
            //    return View(rwa);
            //}

            //public ActionResult Contact()
            //{
            //    ViewBag.Message = "Your contact page.";

            //    return View();
        }
        public ActionResult EDB()
        {
            string url = String.Format("https://evostage.klonostek.com/api/ecashier?cCode=ECR&ecID=5yc9cpedniwiml1z&euID=patrick1234&amount=100&eTransID=124356890123460&createuser=Y&output=1");
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "Get";
            HttpWebResponse respondObject = null;
            respondObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = respondObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                ViewBag.result = strresulttest.ToList();
                sr.Close();
            }
            return View(strresulttest);
        }
        public ActionResult ECR()
        {
            string url = String.Format("https://evostage.klonostek.com/api/ecashier?cCode=EDB&ecID=5yc9cpedniwiml1z&euID=patrick1234&amount=150&eTransID=1234562023456a&output=1");
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "Get";
            HttpWebResponse respondObject = null;
            respondObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = respondObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                ViewBag.result = strresulttest.ToList();
                sr.Close();
            }
            return View(strresulttest);
        }
        public ActionResult GUI()
        {
            string url = String.Format("https://evostage.klonostek.com/api/ecashier?cCode=GUI&ecID=5yc9cpedniwiml1z&euID=patrick1234&output=1");
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "Get";
            HttpWebResponse respondObject = null;
            respondObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = respondObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                ViewBag.result = strresulttest.ToList();
                sr.Close();
            }
            return View(strresulttest);
        }
        public ActionResult TRI()
        {
            string url = String.Format("https://evostage.klonostek.com/api/ecashier?cCode=TRI&ecID=5yc9cpedniwiml1z&euID=patrick1234&output=1&eTransID=1234567890123456a");
            WebRequest requestObject = WebRequest.Create(url);
            requestObject.Method = "Get";
            HttpWebResponse respondObject = null;
            respondObject = (HttpWebResponse)requestObject.GetResponse();

            string strresulttest = null;
            using (Stream stream = respondObject.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                ViewBag.result = strresulttest.ToList();
                sr.Close();
            }
            return View(strresulttest);
        }
        public ActionResult UserAuthentication()
        
        {
            string url = String.Format("https://evostage.klonostek.com/ua/v1/5yc9cpedniwiml1z/325a461b90ca3f97f59f71fcb271cfdd");
            //WebRequest requestObjectPost = WebRequest.Create(url);
            //requestObjectPost.Method = "POST";
            //requestObjectPost.ContentType = "application/json";

            string Jsonbody = "{" +
               "\"uuid\":\"unique request identifier\"," +
               "\"player\":{" +
               "\"id\":\"patrick1234\"," +
               "\"update\":true," +
               "\"firstName\":\"Patrick\"," +
               "\"lastName\":\"okok\"," +
               "\"nickname\":\"Patrick\"," +
               "\"country\":\"MY\"," +
               "\"language\":\"en\"," +
               "\"currency\":\"MYR\"," +
               "\"session\":{" +
               "\"id\":\"111ssss3333rrrrr45555\"," +
               "\"ip\":\"139.59.241.92\"" +
               "}" +
               "}," +
               "\"config\":{" +
               "\"brand\":{" +
               "\"id\":\"1\"," +
               "\"skin\":\"1\"" +
               "}," +
               "\"game\":{" +
               "\"category\":\"roulette\"," +
               "\"interface\":\"view1\"," +
               "\"table\":{" +
               "\"id\":\"leqhceumaq6qfoug\"" +
               "}" +
               "}," +
               "\"channel\":{" +
               "\"wrapper\":false," +
               "\"mobile\":false" +
               "}," +
               "\"urls\":{" +
               "\"cashier\":\"http://www.chs.ee\"," +
               "\"responsibleGaming\":\"http://www.RGam.ee\"," +
               "\"lobby\":\"http://www.lobb.ee\"," +
               "\"sessionTimeout\":\"http://www.sesstm.ee\"" +
               "}" +
               "}" +
               "}";

            //UserModel users = new UserModel();
            //users.uuid = "dcd";
            //string name = "ssds";
            //var user = new 
            //{ 
            // Name = name,
            //};
            //var json = JsonConvert.SerializeObject(users);
            //string json = "{\"uuid\":\"unique request identifier\",\"player\":\"{\"\"id\":\"patrick1234\",\"update\":\"true\",\"firstName\":\"Patrick\",\"lastName\":\".\",\"nickname\":\"Patrick\",\"country\":\"MY\",\"language\":\"en\",\"currency\":\"MYR\",\"session\":\"{\"\"id\":\"111ssss333rrrrr45555\",\"ip\":\"139.59.241.92\"\"}\"\"}\",\"config\":\"{\"\"brand\":\"{\"\"id\":\"1\",\"skin\":\"1\"\"}\",\"game\":\"{\"\"category\":\"roulette\",\"interface\":\"view1\",\"table\":\"{\"\"id\":\"leqhceumaq6qfoug\"\"}\"\"}\",\"channel\":\"{\"\"wrapper\":\"false\",\"mobile\":\"false\"\"}\",\"urls\":\"{\"\"cashier\":\"http://www,chs,ee\",\"reponsibleGaming\":\"http://www.RGam.ee\",\"lobby\":\"http://www.lobb.ee\",\"sessionTimeout\":\"http://sesstm.ee\"\"}\"\"}\"\"}\"}";
            //string json = "{\"uuid\":unique request indentifier,\"player\":{\"id\":patrick1234,\"update\":true,\"firstName\":patrick,\"lastName\":se,\"nickname\":Patrick,\"country\":MY,\"language\":en,\"currency\":MYR,\"session\":{\"id\":111ssss3333rrrrr45555,\"ip\":139.59.241.92}},\"config\":{\"brand\":{\"id\":1,\"skin\":1},\"game\":{\"category\":roulette,\"interface\":view1,\"table\":{\"id\":leqhceumaq6qfoug}},\"channel\":{\"wrapper\":false,\"mobile\":false},\"urls\":{\"cashier\":http://www.chs.ee,\"responsibleGaming\":http://www.RGam.ee,\"lobby\":http://www.lobb.ee,\"sessionTimeout\":http://www.sesstm.ee}}}}";

            //using (var streamWriter = new StreamWriter(requestObjectPost.GetRequestStream()))
            //{
            //    string json = new JavaScriptSerializer().Serialize(new
            //    {
            //        uuid = "unique request identifier",
            //        player = {
            //        id: "patrick1234",


            //    });
            //    streamWriter.Write(json);
            //    streamWriter.Flush();
            //    streamWriter.Close();
            //}
            //string text = System.IO.File.ReadAllText(@"C:\Users\patri\source\repos\WebApplication1\WebApplication1\json.json");
            //using (StreamReader file = new StreamReader(@"C:\Users\patri\source\repos\WebApplication1\WebApplication1\json.json"))
            //using (var StreamWrite = new StreamWriter(requestObjectPost.GetRequestStream()))
            //{
            //    StreamWrite.Write(Jsonbody);
            //    StreamWrite.Flush();
            //    StreamWrite.Close();

            //    var httResponse = (HttpWebResponse)requestObjectPost.GetResponse();

            //    using (var streamReader = new StreamReader(httResponse.GetResponseStream()))
            //    {
            //        var result2 = streamReader.ReadToEnd();
            //    }

            //}
            IRestClient restClient = new RestClient();
            IRestRequest request = new RestRequest() 
            { 
            Resource = url,
            Method = Method.POST,
            RequestFormat = DataFormat.Json
            };

            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "äpplication/xml");
            request.AddJsonBody(Jsonbody);
            IRestResponse response = restClient.Post(request);



            return View(response.Content);
        }
    }
}