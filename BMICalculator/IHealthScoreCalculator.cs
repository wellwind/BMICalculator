using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    /// <summary>
    /// 計算健康分數interface
    /// </summary>
    public interface IHealthScoreCalculator : IHealthSystem
    {
        double CalculateHealthScore();
    }
}