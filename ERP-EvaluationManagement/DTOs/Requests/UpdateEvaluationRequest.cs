namespace ERP.EvaluationManagement.Core.DTOs.Requests;

public class UpdateEvaluationRequest
{
    public Guid EvaluationId { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Type { get; set; }
    public double FinalMarks { get; set; }
    public double Marks { get; set; }
}