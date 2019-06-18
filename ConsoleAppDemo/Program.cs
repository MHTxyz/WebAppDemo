using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestNewGreetingAdd();

            Test();
        }

        public void HostTset()
        {
            //System.Web.Http.SelfHost.dll

            //var config = new HttpSelfHostConfiguration(new Uri("http://localhost:10930"));

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate:"api/{controller}/{id}",
            //    defaults :new { id = RouteParameter.Optional});

            //var host = new HttpSelfHostServer(config);
            //host.OpenAsync().Wait();

            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();

            //host.CloseAsync().Wait();
        }

        /// <summary>
        /// 模拟客户端调用
        /// </summary>
        public static void Test()
        {
            var greetingServiceAddress = new Uri("http://localhost:10930/api/greeting");
            var client = new HttpClient();
            var result = client.GetAsync(greetingServiceAddress).Result;
            var greeting = result.Content.ReadAsStringAsync().Result;

            Console.WriteLine(greeting);
        }

        //[Fact]
        //public void TestNewGreetingAdd()
        //{
        //    //准备
        //    var greetingName = "newgreeting";
        //    var greetingMessage = "Hello Test";
        //    var fakeRequest = new HttpRequestMessage(HttpMethod.Post, "http://localhost:10930/api/greeting");
        //    var greeting = new Greeting
        //    {
        //        Name = greetingName,
        //        Message=greetingMessage
        //    };

        //    var service = new GreetingController();
        //    service.Request = fakeRequest;

        //    //操作
        //    var response = service.PostGreeting(greeting);

        //    //断言
        //    Assert.NotNull(response);
        //    Assert.Equal(HttpStatusCode.Created,response.StatusCode);
        //    Assert.Equal(new Uri("http://localhost:10930/api/greeting/newgreeting"), response.Headers.Location);
        //}

        //模拟客户端调用
    }
}
