namespace ERP_EvaluationManagement.DTOs.Requests;

public class CreateTeacherRequest
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}