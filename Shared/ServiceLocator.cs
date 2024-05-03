using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailBL.Shared
{
    public class ServiceLocator
    {
        public BaseResponse Execute(BaseRequest requestOb)
        {
            BaseResponse responseObj = new BaseResponse();

            Type classType = Type.GetType(requestOb.BehaviourClass);
            BaseBehaviour behObj = (BaseBehaviour)Activator.CreateInstance(classType);
            behObj.Execute(requestOb);

            return responseObj;
        }
    }
}
