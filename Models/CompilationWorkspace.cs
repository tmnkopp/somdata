using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOMData.Models
{
    public class CompilationWorkspace : ICompilationWorkspace
    {
        public int CompilationWorkspaceId { get; set; }
        public string CompilationTitle { get; set; }  
        public string Command { get; set; }
        public string CommandParams { get; set; }
        public string CompileFrom { get; set; }
        public string CompileTo { get; set; }
        public string WrapExpression { get; set; }
        public string ReplaceTerms { get; set; }
        public string ReplaceLines { get; set; }
    }
}
