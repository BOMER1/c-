using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferrari
{
    interface IFerrari
    {
        string Model { get; }
        string Driver { get; }
        string UseBrakes();
        string PushGasPedal();
    }
}
