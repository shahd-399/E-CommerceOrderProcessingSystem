using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceOrderProcessingSystem.Interface
{
    internal interface IOrderProcessor
    {

        string ProcessOrder();
        decimal CalculateDiscount(decimal orderAmount);
    }
}
