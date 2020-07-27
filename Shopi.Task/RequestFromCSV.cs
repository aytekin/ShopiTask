using Shopi.Task.Abstract;
using Shopi.Task.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using Shopi.Task.Utilities.Results;
using ChoETL;
using Newtonsoft.Json;
using Shopi.Task.Model;

namespace Shopi.Task
{
    public sealed class RequestFromCSV : RequestBase
    {
        public RequestFromCSV(string postPath) : base(postPath)
        {
        }

        public override IResult GetRequest(string path)
        {
            try
            {
                var csv = new List<string[]>();
                var lines = File.ReadAllLines(path);

                foreach (string line in lines)
                    csv.Add(line.Split('|'));

                var properties = lines[0].Split('|');

                var listObjResult = new List<Dictionary<string, string>>();

                for (int i = 1; i < lines.Length; i++)
                {
                    var objResult = new Dictionary<string, string>();
                    for (int j = 0; j < properties.Length; j++)
                        objResult.Add(TrimString(properties[j].ToString(), '_'), csv[i][j]);

                    listObjResult.Add(objResult);
                }

                string a = JsonConvert.SerializeObject(listObjResult);
                this.products = JsonConvert.DeserializeObject<List<Product>>(a);
            }
            catch (Exception e)
            {
                return new Result(success: false, message: e.Message);
            }
            return new Result(true);

        }

        private string TrimString(string s ,char character)
        {
            string result = string.Empty;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != character)
                    result += s[i];
            }
            return result;
        }


    }
}
