using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyserProject
{
   
        public class MoodAnalyserClass
        {
            public string message { get; set; }
            public MoodAnalyserClass()
            {
                this.message = "";
            }
            public MoodAnalyserClass(string message)
            {
                this.message = message;
            }
            public string AnalyseMood()
            {
                if (this.message.Contains("sad", StringComparison.OrdinalIgnoreCase))
                    return "SAD";
                else
                    return "HAPPY";
            }
        }
    
}
