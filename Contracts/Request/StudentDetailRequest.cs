using StudentDetailBL.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetailBL.Contracts.Request
{
    public class StudentDetailRequest : BaseRequest
    {
        public string studentName { get; set; }
        public string address { get; set; }
        public string rollNumber { get; set; }
    }
}
