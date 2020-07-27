using ChoETL;
using Shopi.Task.Abstract;
using Shopi.Task.Utilities.Results.Abstract;
using System;
using System.IO;
using System.Net;

namespace Shopi.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string getPath = @"http://dev.shopiconnect.com/api/product/123";
            string postPath = @"http://dev.shopiconnect.com/api/productImport/ImportDeltaProducts";
            string csvPath = @"./sample.csv";



            using (RequestFromCSV request = new RequestFromCSV(postPath))
            {

                IResult result = request.GetRequest(csvPath);

                if (result.Success)
                    _ = request.PostRequest();


            }
        }
    }
}
