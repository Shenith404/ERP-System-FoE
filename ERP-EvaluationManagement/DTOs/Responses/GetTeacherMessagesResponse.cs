using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP_EvaluationManagement.DTOs.Responses
{
    public class GetTeacherMessagesResponse
    {
        public Guid RequestId { get; set; }
        public string Message { get; set; }
        public string SenderName { get; set; }
        public string RecieverName { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecieverId { get; set; }
        public int Header { get; set; }
        public DateTime AddedDate { get; set; }
        public string RecieverRegistrationNum { get; set; }
    }
}
