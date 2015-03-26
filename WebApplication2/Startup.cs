using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Owin;

namespace WebApplication2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = GlobalConfiguration.Configuration;
            config.MapHttpAttributeRoutes();
            //config.MapHttpRoute();
            config.EnsureInitialized();
            app.UseWebApi(config);
        }
    }
}