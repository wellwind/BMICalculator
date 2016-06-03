using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.BMIAdviseCalculator
{
    /// <summary>
    /// 依照BMI給予診斷的interface
    /// </summary>
    internal interface IBMIAdviseCalculator
    {
        Enum GetHealthAdvise(double bmi);
    }
}