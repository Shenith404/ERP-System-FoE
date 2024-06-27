namespace ERP_EvaluationManagement.DTOs.Requests;

public class CreateEvaluationRequest
{    
    public string Name { get; set; } = string.Empty;
    public int Type { get; set; }
    public double FinalMarks { get; set; }
    public double Marks { get; set; }
}