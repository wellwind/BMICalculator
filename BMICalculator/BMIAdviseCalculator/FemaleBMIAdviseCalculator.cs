using BMICalculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.BMIAdviseCalculator
{
    /// <summary>
    /// 女性BMI診斷
    /// </summary>
    public class FemaleBMIAdviseCalculator : IBMIAdviseCalculator
    {
        public Enum GetHealthAdvise(double bmi)
        {
            if (bmi < 18)
            {
                return BMIAdviseEnum.Thin;
            }
            else if (bmi > 22)
            {
                return BMIAdviseEnum.Fat;
            }
            else
            {
                return BMIAdviseEnum.Standatd;
            }
        }
    }
}