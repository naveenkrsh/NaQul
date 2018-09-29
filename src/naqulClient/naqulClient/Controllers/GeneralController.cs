using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using naqulClient.Helper;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace naqulClient.Controllers
{
    [Route("api/[controller]")]
    public class GeneralController : Controller
    {
        private ConfigurationHelper configHelper;

        // GET: api/values
        // [HttpGet]
        // public IEnumerable<string> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }
        public GeneralController(IConfiguration iConfig)
        {
            

            configHelper = new ConfigurationHelper(iConfig);
        }

        [HttpGet]
        public List<string> GetSuggetion()
        {
            string sql = "Select Distinct text FROM recent_queries";

            var naqulConnection = configHelper.GetNaqulDbConnectionString();
            DataSet ds = new DBHelper(naqulConnection).GetDataFromDB(sql);

            List<string> list = new List<string>();
            if(ds!= null && ds.Tables.Count >0)
            {
                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    list.Add(row[0].ToString());
                }
            }
            return list;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
