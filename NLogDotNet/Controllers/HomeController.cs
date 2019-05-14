using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NLogDotNet.Controllers
{
    public class HomeController : ApiController
    {
        private static ILogger _logger;

        internal static ILogger Logger
        {
            get
            {
                if (_logger == null)
                {
                    _logger = LogManager.GetLogger("HomeController");
                }
                return _logger;
            }
            set
            {
                _logger = value;
            }
        }

        // GET: api/Home
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Home/5
        public string Get(int id)
        {

            Logger.Info("I am a Get Method.");
            return "value";
        }

        // POST: api/Home
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
