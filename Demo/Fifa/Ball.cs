using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Fifa
{
    internal class Ball
    {
        public int Id { get; set; }
        private Location location;

        public Location Location
        {
            get 
            { 
                return location; 
            }
            set
            { if ( !location.Equals(value))
                {
                    location = value;
                    if (BallLocationChanged is not null)
                        BallLocationChanged.Invoke(this);
                }
            }
        }

        public  Action<Ball> BallLocationChanged; 
        public override string ToString()
        {
            return $"Id : {Id} , Location : {Location}";
        }


    }
}
