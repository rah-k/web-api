using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAPI.DefaultModel
{
    public class UserRequest
    {
        public long Id { get; set; }
        public string PatientName { get; set; }
        public string ReasonOfAdmission { get; set; }
        public string Age { get; set; }
        public string DOJ { get; set; }
        public string Fees { get; set; }


    }
}
