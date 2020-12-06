using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsOtpWebCall
{
    public class File_info
    {
        [JsonProperty("filename")]
        public string filename { get; set; }

        [JsonProperty("contentInbase64")]
        public string contentInbase64 { get; set; }
    }
}
