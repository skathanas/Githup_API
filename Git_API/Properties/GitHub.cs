using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Linq;
using System.Threading.Tasks;
using Nancy.Json;

namespace Git_API

{
    class GitHub
    {
        public string login { get; set; }
        public string id { get; set; }
        public string html_url { get; set; }
        public string public_repos { get; set; }
        public string follorwers { get; set; }
        public string following { get; set; }
        public string email { get; set; }
    }
}