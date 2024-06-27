namespace ERP_EvaluationManagement.DTOs.Responses;

public class GetTeacherModulesResponse
{
    public Guid ModuleOfferingId { get; set; }
    public Guid ModuleId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Semester { get; set; } = string.Empty;
}