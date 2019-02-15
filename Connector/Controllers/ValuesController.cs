using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Connector.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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


        public DataTable GetLeads()
        {
            DataTable myTable = new DataTable();
            // Betty Code

            // Get Token
            // Get A list of Objects List<LeadJson>
            // Create a Data Table based on your List<LeadJson>


            DataTable leadTable = new DataTable();
            leadTable.Clear();

            //Columns
            leadTable.Columns.Add("id");
            leadTable.Columns.Add("status");


            // foreach item in your list
            DataRow row = leadTable.NewRow();
            row["id"] = "ravi";
            row["status"] = "500";
            leadTable.Rows.Add(row);


            //
            return myTable;
        }
    }
}
