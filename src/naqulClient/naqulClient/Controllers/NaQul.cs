using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using naqulClient.Helper;
using naqulClient.Models;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace naqulClient.Controllers
{
    public class NaQul : Controller
    {
        private readonly IConfiguration configuration;
        private readonly ConfigurationHelper configHelper;

        public NaQul(IConfiguration iConfig)
        {
            this.configuration = iConfig;

            configHelper = new ConfigurationHelper(configuration);
        }
        // GET: /<controller>/ 
        public IActionResult Index()
        {
            ViewData["Message"] = "Client";
            NaQulResponseViewModel model = new NaQulResponseViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult GetData(string text)
        {
            // List<string> queries = new List<string>(){
            //     "SELECT * FROM Employees;",
            //     "SELECT * FROM Customers;"
            // };

            NaQulResponseViewModel model = new NaQulResponseViewModel();
            model.Text = text;
            try
            {
                var queries = GetQueries(text);


                foreach (var query in queries)
                {
                    try
                    {
                        var connectionString = configHelper.GetClientDbConnectionString();
                        var result = new DBHelper(connectionString).GetDataFromDB(query);
                        if (result.Tables[0].Rows.Count > 0)
                            model.Results.Add(new Result(query, result.Tables[0]));
                    }
                    catch(Exception ex)
                    { 
                    }
                }

            }
            catch (Exception ex)
            {
                model.Message= "Internal Server error in naqul backend server";
            }

            if(model.Results.Count >0)
            {
                var naqulConnection= configHelper.GetNaqulDbConnectionString();
                var db = new DBHelper(naqulConnection);
                db.SaveSqlQuery(text);
            }

            return View("Index", model);

        }
        private List<string> GetQueries(string text)
        {
            string URL = configHelper.GetNaQulBackendEndpoint();
            var client = new HttpClient();

            var data = new NaQulRequestModel(text);

            var myContent = JsonConvert.SerializeObject(data);
            var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = client.PostAsync(URL, byteContent).Result;

            if (response.IsSuccessStatusCode)
            {
                var contents = response.Content.ReadAsStringAsync().Result;
                var result = JsonConvert.DeserializeObject<List<string>>(contents);
                return result;
            }
            return new List<string>();
        }

       
    }
}
