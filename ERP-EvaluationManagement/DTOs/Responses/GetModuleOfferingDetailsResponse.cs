namespace ERP_EvaluationManagement.DTOs.Responses;

public class GetModuleOfferingDetailsResponse
{
    public Guid ModuleOfferingId { get; set; }
    public string ModuleName { get; set; }
    public string ModuleCode { get; set; }
    public string CoordinatorName { get; set; }

    public ICollection<GetEvaluationDetailsResponse> Evaluations { get; set; }
}