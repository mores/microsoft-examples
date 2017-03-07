using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Right-Click run as Administrator
 */

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            System.Net.HttpListener listener = new System.Net.HttpListener();
            listener.Prefixes.Add("http://*:8080/");
            listener.Start();
            Console.WriteLine("Listening...");
            for (;;)
            {
                System.Net.HttpListenerContext ctx = listener.GetContext();
               new System.Threading.Thread(new Worker(ctx).ProcessRequest).Start();
            }
        }

        class Worker
        {
            private System.Net.HttpListenerContext context;

            public Worker(System.Net.HttpListenerContext context)
            {
                this.context = context;
            }

            public void ProcessRequest()
            {
                string msg = context.Request.HttpMethod + " " + context.Request.Url;
                Console.WriteLine(msg);

                StringBuilder sb = new StringBuilder();
                sb.Append("<html><body><h1>" + msg + "</h1>");
                sb.Append("</body></html>");

                byte[] b = Encoding.UTF8.GetBytes(sb.ToString());
                context.Response.ContentLength64 = b.Length;
                context.Response.OutputStream.Write(b, 0, b.Length);
                context.Response.OutputStream.Close();
            }
        }
    }
}
