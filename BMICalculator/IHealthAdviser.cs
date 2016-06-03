using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    /// <summary>
    /// 提供健康診斷interface
    /// </summary>
    public interface IHealthAdviser
    {
        Enum GetHealthAdvise();
    }
}