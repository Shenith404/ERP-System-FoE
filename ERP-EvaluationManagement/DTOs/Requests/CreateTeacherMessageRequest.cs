using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_EvaluationManagement.DTOs.Requests
{
    public class CreateTeacherMessageRequest
    {
        public string? Message { get; set; }
        public int Header { get; set; }
    }
}
