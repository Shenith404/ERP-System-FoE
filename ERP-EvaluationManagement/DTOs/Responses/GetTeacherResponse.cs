namespace ERP_EvaluationManagement.DTOs.Responses;

public class GetTeacherResponse
{
    public Guid TeacherId { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}