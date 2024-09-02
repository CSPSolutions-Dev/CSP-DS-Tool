using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSP.DataScience.Tool
{
    public class NLPInputModel
    {
        public NLPInputModel(string nlpAnalyzeColumn, string labelColumn, DataTable inputData, string targetFilePath)
        { 
            this.NLPAnalyzeColumn = nlpAnalyzeColumn;
            this.LabelColumn = labelColumn;
            this.TargetFilePath = targetFilePath;
            this.InputData = inputData;
        }
        public string NLPAnalyzeColumn { get; set; }

        public string LabelColumn { get; set; }
        
        public DataTable InputData { get; set; }
        
        public string TargetFilePath { get; set; }
    }
}
