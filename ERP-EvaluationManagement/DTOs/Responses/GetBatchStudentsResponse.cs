using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_EvaluationManagement.DTOs.Responses
{
    public class GetBatchStudentsResponse
    {
        public Guid StudentId { get; set; }
        public string RegistrationNum { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string AcademicAdvisorName { get; set; }
        public string BatchName { get; set; }
    }
}
