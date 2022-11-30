using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odyssey.DiagnosticCertificateService.Application.Queries.Unit_test.test
{
    public class NunitTestClass
    {
        public string getGrade(int percent)
        {
            if (percent >= 90 & percent <= 100)
                return "A";
            else if(percent >=80 & percent < 90)
                return "B";
            else if (percent >= 70 & percent < 80)
                return "C";
            else if (percent >= 60 & percent < 70)
                return "D";
            else if (percent >= 0 & percent < 60)
                return "F";

            else
                return "invalid";
        }
    }
}
