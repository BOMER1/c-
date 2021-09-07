using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public string Model { get; set; }

        public string Color { get; set; }

        public string Start()
        {
            return "Engine Start";
        }

        public string Stop()
        {
            return "Break!!!";
        }
        public override string ToString()
        {
            return $"{Color} " + "Seat " + $"{Model}" +
                $"{Start()} " + "\n" + $"{Stop()}";
        }
    }
}

