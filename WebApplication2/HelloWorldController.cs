using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using Hello.Data;

namespace WebApplication2
{
    [Route("api/random")]
    public class HelloWorldController : ApiController
    {
        private IDataSource _dataSource;

        public HelloWorldController()
        {
            _dataSource = new FileDataSource();

        }
        public string Get()
        {
            return _dataSource.Read();

        }


    }
}