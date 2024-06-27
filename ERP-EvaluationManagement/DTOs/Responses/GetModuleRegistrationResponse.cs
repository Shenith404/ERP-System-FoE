using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_EvaluationManagement.DTOs.Responses
{
    public class GetModuleRegistrationResponse
    {
        public Guid StudentId { get; set; }
        public Guid ModuleOfferingId { get; set; }
        public string ModuleName { get; set; } = string.Empty;
        public string StudentRegistrationNum { get; set; } = string.Empty;
        public string StudentName { get; set; } = string.Empty;
        public string StudentEmail { get; set; } = string.Empty;
    }
}
