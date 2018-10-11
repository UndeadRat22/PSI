using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musix
{
    public class Track
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Album { get; set; }
        public string Date { get; set; }
        public string Url { get; set; }

        public Track(string url)
        {
            Url = url;
        }
        public override string ToString()
        {
            if (Artist == null | Name == null)
                return Url;
            return Artist + " - " + Name;
        }
    }
}
