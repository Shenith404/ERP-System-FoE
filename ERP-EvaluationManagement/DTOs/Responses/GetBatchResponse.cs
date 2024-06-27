using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_EvaluationManagement.DTOs.Responses
{
    public class GetBatchResponse
    {
        public Guid BatchId { get; set; }
        public string? BatchName { get; set; }
        public ICollection<GetStudentResponse> BatchStudents { get; set; }
    }
}
