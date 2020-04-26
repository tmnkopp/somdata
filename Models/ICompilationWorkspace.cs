namespace SOMData.Models
{
    public interface ICompilationWorkspace
    {
        int CompilationWorkspaceId { get; set; } 
        string Command { get; set; }
        string CommandParams { get; set; }
        string CompilationTitle { get; set; } 
        string CompileFrom { get; set; }
        string CompileTo { get; set; }
        string ReplaceLines { get; set; }
        string ReplaceTerms { get; set; }
        string WrapExpression { get; set; }
    }
}