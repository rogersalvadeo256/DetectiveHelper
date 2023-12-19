using DetectiveHelper.Facade.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveHelper.Facade.Rules.Base
{
    public class BaseFacade<T> : IBaseFacade<T>
    {
        private readonly T _business;

        public BaseFacade(T business)
        {
            _business = business;
        }

        // Implemente métodos genéricos, se necessário
    }
}
