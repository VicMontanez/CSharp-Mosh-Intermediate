using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        private readonly Dictonary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {

            _dictionary = new Dictonary<string, string>();
        }

        public string this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set { _dictionary[key] = value; }
        }
    }
}