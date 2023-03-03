using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema2.modelos
{
    public class tokenBody
    {
        public string access_token {get;set;}
        public string token_type { get;set;}
        public DateTime expires_in {get;set;}
        public string refresh_token { get;set;}
        public string refresh_token_expires_in { get; set;}
        public string username { get; set;}
        public string[] scope { get; set;}
    }
}
