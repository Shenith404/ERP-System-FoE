namespace ERP_EvaluationManagement.DTOs.Responses;

public class GetModuleResponse
{
    public Guid ModuleId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public int Credits { get; set; }
    public string Semester { get; set; } = string.Empty;
    public int Type { get; set; }
}