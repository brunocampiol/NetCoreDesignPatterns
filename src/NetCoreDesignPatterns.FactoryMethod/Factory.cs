using NetCoreDesignPatterns.FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDesignPatterns.FactoryMethod
{
    public abstract class Factory
    {
        // Note that the Creator may also provide some default implementation of
        // the factory method.
        public abstract IVehicle FactoryMethod();

    }
}
