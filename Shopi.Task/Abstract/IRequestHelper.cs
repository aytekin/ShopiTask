using Shopi.Task.Model;
using Shopi.Task.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Shopi.Task.Abstract
{
    internal interface IRequestHelper : IDisposable
    {
        public Task<IResult> PostRequest();

    }
}
