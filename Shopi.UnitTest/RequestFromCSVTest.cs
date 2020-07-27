using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopi.Task;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shopi.UnitTest
{
    [TestClass]
    public sealed class RequestFromCSVTest
    {


        [TestMethod]
        [DataRow(@"http://dev.shopiconnect.com/api/productImport/ImportDeltaProducts", @"./sample.csv")]
        public void GetRequestTest(string postPath, string getPath)
        {
            using RequestFromCSV request = new RequestFromCSV(postPath);

            var result = request.GetRequest(getPath);

            Assert.IsTrue(result.Success);
        }



  

    }
}
