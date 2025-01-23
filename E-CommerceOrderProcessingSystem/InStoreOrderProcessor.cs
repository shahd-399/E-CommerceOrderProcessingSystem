using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_CommerceOrderProcessingSystem.Interface;

namespace E_CommerceOrderProcessingSystem
{
    internal class InStoreOrderProcessor : IOrderProcessor
    {
        
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * 0.05m;
        }

        public string ProcessOrder()
        {
            return "Processes orders placed in physical stores.";
        }
    }
}
