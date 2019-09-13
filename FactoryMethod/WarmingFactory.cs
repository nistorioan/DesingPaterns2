using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class WarmingFactory : Factory
    {
        public override IAirConditioner Create(double temperature) => new WarmRoom(temperature);
    }
}
