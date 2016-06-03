using BMICalculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator.BMIAdviseCalculator
{
    /// <summary>
    /// 男性BMI診斷
    /// </summary>
    public class MaleBMIAdviseCalculator : IBMIAdviseCalculator
    {
        public Enum GetHealthAdvise(double bmi)
        {
            if (bmi < 20)
            {
                return BMIAdviseEnum.Thin;
            }
            else if (bmi > 25)
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