using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new SelectAirConditioner().ExecuteCreation(AirConditionerActions.WarmRoom, 24.5);
            factory.Operate();
        }
    }
}
