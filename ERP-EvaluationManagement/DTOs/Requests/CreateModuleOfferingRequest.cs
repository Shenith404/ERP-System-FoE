namespace ERP_EvaluationManagement.DTOs.Requests;

public class CreateModuleOfferingRequest
{
    public Guid ModuleId { get; set; }
    public Guid CoordinatorId { get; set; }
    public Guid ModeratorId { get; set; }
    public Guid ExternalModeratorId { get; set; }
}