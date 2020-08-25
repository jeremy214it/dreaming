using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace HelloWorldAPI.Controler
{
    public class HelloApiController : ApiController
    {
        // GET api/<controller>
        [HttpGet]
        public string Get()
        {
            HelloWorld myworld = new HelloWorld();

           return myworld.Hello() + " API Get Method by Jeremy Martin";


        }

       
           



    }
}