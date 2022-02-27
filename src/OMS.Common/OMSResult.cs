using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OMS.Common
{
    public class OMSResult
    {
        public bool success { get; set; }

        public string code { get; set; }

        public int httpStatusCode { get; set; }

        public string title { get; set; }

        public string message { get; set; }

        public object data { get; set; }

        public Dictionary<string, IEnumerable<string>> errors { get; set; }

        public OMSResult()
        {
            success = true;
            httpStatusCode = (int)HttpStatusCode.OK;
            errors = new Dictionary<string, IEnumerable<string>>();
        }
    }
}
