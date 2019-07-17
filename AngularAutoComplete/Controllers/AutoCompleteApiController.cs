using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AngularAutoComplete.Controllers
{
    [Route("api/[controller]")]
    public class AutoCompleteApiController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{search}")]
        public List<string> Get(string search)
        {
            List<string> data = new List<string>();
            data.Add("Surat");
            data.Add("Ahmedabad");
            data.Add("Rajkot");
            data.Add("Gandhinagar");
            data.Add("Pune");
            data.Add("Jaipur");
            data.Add("Udaipur");
            data.Add("Mumbai");
            data.Add("Vapi");
            data.Add("Katargam");
            data.Add("Varaccha");
            var result = data.Where(x => x.StartsWith(search)).Take(10).ToList();
            return result;
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
