using Newtonsoft.Json;
using Shopi.Task.Model;
using Shopi.Task.Utilities.Results;
using Shopi.Task.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Shopi.Task.Abstract
{
    public abstract class RequestBase : IRequestHelper
    {
        public List<Product> products { get; set; }
        public string PostPath { get; protected set; }

        public RequestBase(string postPath)
        {
            this.PostPath = postPath;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }


        public abstract IResult GetRequest(string path);


        public async Task<IResult> PostRequest()
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(this.PostPath);
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream());
                string json = JsonConvert.SerializeObject(this.products);
                streamWriter.Write(json);

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                using var streamReader = new StreamReader(httpResponse.GetResponseStream());
                var result = streamReader.ReadToEnd();


            }
            catch (Exception e)
            {
                return new Result(success: false, message: e.Message);
            }

            return new Result(true);


        }
    }
}
