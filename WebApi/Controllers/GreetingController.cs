using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class GreetingController : ApiController
    {
        public static List<Greeting> _greetings = new List<Greeting>();

        public string GetGreeting()
        {
            return "Hello World!"; 
        }

        public string GetGreeting(string id)
        {
            var greeting = _greetings.FirstOrDefault(g => g.Name == id);
            if (greeting == null)
            {
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                throw new HttpResponseException(this.Request.CreateErrorResponse(HttpStatusCode.NotFound,"没有对应的数据！"));
            }

            return greeting.Message;
        }

        public HttpResponseMessage PostGreeting(Greeting greeting)
        {
            _greetings.Add(greeting);

            Uri greetingLocation = new Uri(this.Request.RequestUri, "greeting/" + greeting.Name);
            HttpResponseMessage response = this.Request.CreateResponse(HttpStatusCode.Created);
            response.Headers.Location = greetingLocation;
            
            return response;
        }
    }
}
