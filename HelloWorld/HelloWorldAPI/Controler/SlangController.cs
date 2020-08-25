using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Web.Http;
using HelloWorldAPI.Models;

namespace HelloWorldAPI.Controler
{
    public class SlangController : ApiController
    {

        //this gives example of a controller getting a dataset that could be comming from a database or other storage location. 
        Slang[] Sayings =
        {
            new Slang {Id = 0, Saying="Hello World"},
            new Slang {Id = 1, Saying="Hi Peeps"},
            new Slang {Id = 2, Saying="Howdy Folks"},
            new Slang {Id = 3, Saying="What's Up"}
        };

        public IEnumerable<Slang> GetAll()
        {
            return Sayings;
        }

        public IHttpActionResult GetById(int id)
        {
            var saying = Sayings.FirstOrDefault(x => x.Id == id);

            if (saying == null)
            {
                return NotFound();
            }
            return Ok(saying);
        }
    }
}
