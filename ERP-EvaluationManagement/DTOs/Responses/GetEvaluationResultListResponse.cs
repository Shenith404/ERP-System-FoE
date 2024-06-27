namespace ERP_EvaluationManagement.DTOs.Responses;

public class GetEvaluationResultListResponse
{
    public string RegistrationNum { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public double StudentScore { get; set; }
}