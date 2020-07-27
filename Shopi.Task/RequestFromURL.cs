using Shopi.Task.Abstract;
using Shopi.Task.Utilities.Results;
using Shopi.Task.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Shopi.Task
{
    public sealed class RequestFromURL : RequestBase
    {

        public RequestFromURL(string postPath) : base(postPath)
        {
        }

        public override IResult GetRequest(string path)
        {
            //    //string html = string.Empty;
            //    //HttpWebRequest request = (HttpWebRequest)WebRequest.Create(path);
            //    //request.AutomaticDecompression = DecompressionMethods.GZip;

            //    //using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            //    //using (Stream stream = response.GetResponseStream())
            //    //using (StreamReader reader = new StreamReader(stream))
            //    //{
            //    //    html = reader.ReadToEnd();
            //    //}

            //    //Console.WriteLine(html);
            return new Result(true);
        }

      
    }
}
