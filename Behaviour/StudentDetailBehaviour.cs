using StudentDetailBL.Contracts.Request;
using StudentDetailBL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailBL.Behaviour
{
    public class StudentDetailBehaviour : BaseBehaviour
    {
        public override BaseResponse Execute(BaseRequest request)
        {
            StudentDetailRequest studentDetailRequest = (StudentDetailRequest)request;
            
            if(studentDetailRequest.BehaviourAction == "insert_student_details")
            {
                SaveStudentDetails(studentDetailRequest);
            }

            throw new NotImplementedException();
        }
        private string SaveStudentDetails(StudentDetailRequest studentRequestObj)
        {
            return "success";
        }

        private string UpdateStudentDetails(StudentDetailRequest studentRequestObj)
        {
            return "success";
        }

        private string GetStudentDetails(StudentDetailRequest studentRequestObj)
        {
            return "success";
        }

        
    }
}
