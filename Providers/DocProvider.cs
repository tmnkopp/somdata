 
using SOMData.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace SOMData.Providers
{
    public static class DocProvider
    {
        public static IEnumerable<CodeTemplate> GetTemplates(string Path)  
        {
            DirectoryInfo DI = new DirectoryInfo($"{Path}");
            foreach (FileInfo file in DI.GetFiles("*.*"))
            {
                using (TextReader tr = File.OpenText(file.FullName))
                { 
                    yield return (new CodeTemplate() { Name = file.Name, Content = tr.ReadToEnd()});
                }

            }
        }

    }
}
