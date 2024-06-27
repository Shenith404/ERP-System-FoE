namespace ERP.EvaluationManagement.Core.DTOs.Responses;

public class GetAllEvaluationsMarksForModuleOfferingResponse
{
    public Guid StudentId { get; set; }
    public Guid EvaluationId { get; set; }
    public string EvaluationName { get; set; } = string.Empty;
    public string RegistrationNum { get; set; } = string.Empty;
    public string FullName { get; set; } = string.Empty;
    public double StudentScore { get; set; }
    public Dictionary<string, double> EvaluationScores { get; set; } = new Dictionary<string, double>();
}
