using System;
using ServiceStack;
using ServiceStack.Text;
using ServiceStack.Redis;
using ServiceStack.DataAnnotations;
using StackExchange.Redis;

namespace redisPOC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            using(var cm = ConnectionMultiplexer.Connect(""))
            {
				var db = cm.GetDatabase();
				//db.StringSet("key", "QamarAli");
				var key = db.StringGet("key");
                Console.WriteLine(key);

            }
			
          //  Console.WriteLine("Hello World!");
        }
    }
}
