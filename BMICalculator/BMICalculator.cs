using BMICalculator.BMIAdviseCalculator;
using BMICalculator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    public class BMICalculator : IHealthScoreCalculator, IHealthAdviser
    {
        public Human Person { get; set; }

        public double CalculateHealthScore()
        {
            return Person.Weight / Math.Pow(Person.Height / 100, 2);
        }

        public Enum GetHealthAdvise()
        {
            var bmi = CalculateHealthScore();
            IBMIAdviseCalculator adviseCalculator = getBMIAdviseCalculator();
            return adviseCalculator.GetHealthAdvise(bmi);
        }

        private IBMIAdviseCalculator getBMIAdviseCalculator()
        {
            if (Person.Gender == GenderEnum.Male)
            {
                return new MaleBMIAdviseCalculator();
            }
            else if (Person.Gender == GenderEnum.Female)
            {
                return new FemaleBMIAdviseCalculator();
            }
            else
            {
                throw new Exception("性別設定錯誤");
            }
        }
    }
}