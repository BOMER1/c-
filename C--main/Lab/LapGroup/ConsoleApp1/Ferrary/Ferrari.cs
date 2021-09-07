using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    public class Ferrari : IFerrari
    {
        public string Model { get; set; } = "488-Spider";
        public string Driver { get; set; }
        public Ferrari(string driver)
        {
            Driver = driver;
        }
        public string PushGasPedal()
        {
            return "Zadusavam sA!";
        }
        public string UseBrakes()
        {
            return "Brakes !!!";
        }
    }
}
