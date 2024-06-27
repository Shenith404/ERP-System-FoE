namespace ERP.EvaluationManagement.Core.DTOs.Responses;

public class GetParticularSecondExaminerModuleOfferingResponse
{
    public Guid ModuleOfferingId { get; set; }
    public string ModuleName { get; set; }
    public string ModuleCode { get; set; }
    public string SecondExaminerName { get; set; }
    public string Semester { get; set; } = string.Empty;
}