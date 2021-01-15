using System;
using Ninject;
using Ninject.Modules;

namespace FrameworkNinject
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            //Bind<IPersistencia>().To<Persistencia>();
        }
    }
}
