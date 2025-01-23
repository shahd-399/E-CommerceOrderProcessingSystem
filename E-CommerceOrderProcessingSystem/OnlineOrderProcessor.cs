using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_CommerceOrderProcessingSystem.Interface;

namespace E_CommerceOrderProcessingSystem
{
    internal class OnlineOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.1m;
        }

        public string ProcessOrder()
        {
            return "Processes orders placed online";
        }
    }
}
