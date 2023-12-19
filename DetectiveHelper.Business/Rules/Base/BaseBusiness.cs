using DetectiveHelper.Business.Interface.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectiveHelper.Business.Rules.Base
{
    public class BaseBusiness <T> : IBaseBusiness<T>
    {

            private readonly T _repository;

            public BaseBusiness(T repository)
            {
                _repository = repository;
            }


    }

}
