namespace ERP_EvaluationManagement.DTOs.Responses;

public class GetModuleOfferingResponse
{
    public Guid ModuleOfferingId { get; set; }
    public Guid ModuleId { get; set; }
    public Guid CoordinatorId { get; set; }
    public Guid ModeratorId { get; set; }
    public Guid ExternalModeratorId { get; set; }
}