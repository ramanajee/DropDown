using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            string URL = "https://www.instamojo.com/api/1.1/";
            string urlParameters = "?X-Api-Key:"+ ConfigurationManager.AppSettings["API_KEY"].ToString() + "&X-Auth-Token:"+ ConfigurationManager.AppSettings["AUTH_TOKEN"].ToString();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;
            HttpResponseMessage response2 =await client.PostAsync(urlParameters, new StringContent(URL));
            if (response.IsSuccessStatusCode)
            {
                var dataObject = response.Content.ReadAsStringAsync();

            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}