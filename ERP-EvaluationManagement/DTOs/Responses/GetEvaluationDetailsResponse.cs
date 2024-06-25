namespace ERP_EvaluationManagement.DTOs.Responses;

public class GetEvaluationDetailsResponse
{
    public Guid EvaluationId { get; set; }
    public string EvaluationName { get; set; } = string.Empty;
    public int EvaluationType { get; set; }
    public double EvaluationFinalMarks { get; set; }
    public double EvaluationMarks { get; set; }
    
}