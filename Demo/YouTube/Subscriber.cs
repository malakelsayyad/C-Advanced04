using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.YouTube
{
    internal class Subscriber
    {
        public string  Name { get; set; }

        public void Notify(Channel channel , Video video) 
        {
            Console.WriteLine($"Channel : {channel.Title} Uploaded {video} ya {Name}");
        }
        public override string ToString()
        {
            return $"Subscriber Name : {Name}";
        }
    }
}
