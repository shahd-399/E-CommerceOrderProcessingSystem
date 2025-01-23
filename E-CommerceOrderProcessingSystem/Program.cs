using E_CommerceOrderProcessingSystem.Interface;

namespace E_CommerceOrderProcessingSystem
{
    internal class Program
    {
        public static void OrderProcessor(Order ord)
        {
            if("Processes orders placed online" == ord.OrderProcessor.ProcessOrder())
            {
                Console.WriteLine($"Order {ord.OrderId} processed for {ord.CustomerName}. " +
                                  $"Final amount after 10% discount: " +
                                  $"${ord.OrderAmount - ord.OrderProcessor.CalculateDiscount(ord.OrderAmount)}");
            }
            else
            {
                Console.WriteLine($"Order {ord.OrderId} processed for {ord.CustomerName}. " +
                                   $"Final amount after 5% discount: " +
                                   $"${ord.OrderAmount - ord.OrderProcessor.CalculateDiscount(ord.OrderAmount)}");
            }
        }
        static void Main(string[] args)
        {
            Order order01 = new Order
            {
                OrderId = 123,
                CustomerName = "shahd",
                OrderAmount = 100,
                OrderProcessor = new OnlineOrderProcessor()
            };

            OrderProcessor(order01);
            
        }
    }
}
