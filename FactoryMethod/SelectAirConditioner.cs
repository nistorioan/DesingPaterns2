using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SelectAirConditioner
    {
        private readonly Dictionary<AirConditionerActions, Factory> _factories;

        public SelectAirConditioner()
        {
            _factories = new Dictionary<AirConditionerActions, Factory>();

            foreach (AirConditionerActions action in Enum.GetValues(typeof(AirConditionerActions)))
            {
                var factory = (Factory)Activator.CreateInstance(Type.GetType("FactoryMethod." + Enum.GetName(typeof(AirConditionerActions), action) + "Factory"));
                _factories.Add(action, factory);
            }
        }

        public static SelectAirConditioner InitializeFactories() => new SelectAirConditioner();

        public IAirConditioner ExecuteCreation(AirConditionerActions action, double temperature) => _factories[action].Create(temperature);
    }
}
